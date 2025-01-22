using HtmlAgilityPack;
using System.Text.Encodings.Web;
using System.Text.Json;
using Timer = System.Windows.Forms.Timer;

namespace FlashbackAvisering
{
    public partial class FrmSettings : Form
    {
        public List<string> users = [];
        public List<string> forums = [];
        public List<Topic> topics = [];

        TopicsUsersSnapshot currentSnapshot = new();

        private readonly string settingsFileName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\FlashBackAlertSettings.txt";
        private Settings settings = new();

        private Timer timer;

        private static readonly JsonSerializerOptions jsonSerializerOptions = new()
        {
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            WriteIndented = true
        };

        public FrmSettings()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Tick += async (source, eventArgs) => await TimerFunc();
        }

        private async Task TimerFunc()
        {
            if (numericUpDownInterval.Value > 0 && cklForums.CheckedItems.Count > 0)
            {
                await GetDataFromFlashback(false);

                var newSnapshot = GetSnapShot();

                CompareSnapshotsAndSendNotificationsIfNeeded(currentSnapshot, newSnapshot);
            }
        }

        private static void ShowNotification(string userName, string topic, string topicUrl)
        {
            FrmNotification a = new();
            a.UserNameLabel.Text = userName;
            a.Topic.Text = topic;
            a.Topic.Tag = topicUrl;
            a.Show();
        }

        private void PopulateForumList()
        {
            foreach (var forum in forums)
            {
                cklForums.Items.Add(forum);
            }
        }

        private async Task GetDataFromFlashback(bool firstExecution)
        {
            try
            {
                var url = "https://www.flashback.org";
                var web = new HtmlWeb();
                var doc = web.Load(url);

                lblError.Text = "";
            
                forums = doc.DocumentNode
                    .SelectNodes("//table//a//strong").Select(x => x.InnerText).ToList();

                topics = doc.DocumentNode
                    .SelectNodes("//a[starts-with(@href, '/t')]").Select(x => new Topic { Title = x.InnerText, Url = x.GetAttributeValue("href", "") }).SkipLast(1).ToList();

                users = doc.DocumentNode
                    .SelectNodes("//div[contains(text(),'av ')]//a[starts-with(@href, '/f')]").Select(x => x.InnerText).ToList();

            }
            catch (Exception)
            {
                lblError.Text = "Fel när data skulle hämtas från Flashback. Försöker igen...";

                await Task.Delay(5000);

                if (firstExecution)
                {
                    await GetDataFromFlashback(firstExecution);
                }
                else
                {
                    await TimerFunc();
                }
            }

            if (!(forums.Count == topics.Count && topics.Count == users.Count) || (forums.Count == 0 || topics.Count == 0 || users.Count == 0))
            {
                lblError.Text = "Data från Flashback kunde inte parsas korrekt. Programmet avslutas.";
                await Task.Delay(3000);
                Application.Exit();
            }
        }

        private void CompareSnapshotsAndSendNotificationsIfNeeded(TopicsUsersSnapshot previousSnapshot, TopicsUsersSnapshot newSnapshop)
        {
            if (previousSnapshot.GetHashCode() != newSnapshop.GetHashCode())
            {
                for (int i = 0; i < newSnapshop.UsersAndTopics.Count; i++)
                {
                    if (settings.UsersShowAlerts.Count != 0)
                    {
                        if (newSnapshop.UsersAndTopics[i].topic != currentSnapshot.UsersAndTopics[i].topic && settings.Forums.Any(x => x.Key == i))
                        {
                            if (settings.UsersShowAlerts.Any(x => x == newSnapshop.UsersAndTopics[i].user))
                            {
                                ShowNotification(newSnapshop.UsersAndTopics[i].user, newSnapshop.UsersAndTopics[i].topic, topics[i].Url);
                            }
                        }
                    }
                    else if (settings.UsersDoNotShowAlerts.Count != 0)
                    {
                        if (newSnapshop.UsersAndTopics[i].topic != currentSnapshot.UsersAndTopics[i].topic && settings.Forums.Any(x => x.Key == i))
                        {
                            if (!settings.UsersDoNotShowAlerts.Any(x => x == newSnapshop.UsersAndTopics[i].user))
                            {
                                ShowNotification(newSnapshop.UsersAndTopics[i].user, newSnapshop.UsersAndTopics[i].topic, topics[i].Url);
                            }
                        }
                    }
                    else
                    {
                        if (newSnapshop.UsersAndTopics[i].topic != currentSnapshot.UsersAndTopics[i].topic && settings.Forums.Any(x => x.Key == i))
                        {
                            ShowNotification(newSnapshop.UsersAndTopics[i].user, newSnapshop.UsersAndTopics[i].topic, topics[i].Url);
                        }
                    }
                }

                currentSnapshot = newSnapshop;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeAsync();
        }

        private async Task InitializeAsync()
        {
            await GetDataFromFlashback(true);

            currentSnapshot = GetSnapShot();

            PopulateForumList();

            LoadSettings();

            timer.Start();
        }

        private TopicsUsersSnapshot GetSnapShot()
        {
            var snapshot = new TopicsUsersSnapshot();

            for (int i = 0; i < forums.Count; i++)
            {
                snapshot.UsersAndTopics.Add((users[i], topics[i].Title));
            }

            return snapshot;
        }

        private void BtnSaveSettings_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void GetSettingsFromFile()
        {
            try
            {
                if (File.Exists(settingsFileName))
                {
                    settings = JsonSerializer.Deserialize<Settings>(File.ReadAllText(settingsFileName));
                }
            }
            catch (JsonException)
            {
                lblError.Text = "Inställningsfilen är korrupt. Spara dina inställningar igen.";
            }
        }

        private void LoadSettings()
        {
            try
            {
                GetSettingsFromFile();

                for (var i = 0; i < settings.Forums.Count; i++)
                {
                    for (var j = 0; j < cklForums.Items.Count; j++)
                    {
                        if ((string)cklForums.Items[j] == settings.Forums.Values.ElementAt(i))
                        {
                            cklForums.SetItemChecked(j, true);
                            break;
                        }
                    }
                }

                List<string> clines = [.. settings.UsersShowAlerts];
                txtSpecificUsersShowAlerts.Lines = [.. clines];

                clines = [.. settings.UsersDoNotShowAlerts];
                txtSpecificUsersDoNotShowAlerts.Lines = [.. clines];

                numericUpDownInterval.Value = settings.Interval;
                timer.Interval = (int)numericUpDownInterval.Value * 1000;
            }
            catch
            {
                lblError.Text = "Något gick fel när sparade inställningar skulle laddas.";
            }
        }

        private void SaveSettings()
        {
            if (numericUpDownInterval.Value < 1)
            {
                lblError.Text = "Du måste ange ett intervall som är större än 0.";
                return;
            }

            List<string> duplicateUsers = [];

            foreach (var userToExclude in txtSpecificUsersDoNotShowAlerts.Lines)
            {
                if (txtSpecificUsersShowAlerts.Lines.Any(x => x == userToExclude))
                {
                    duplicateUsers.Add(userToExclude);
                }
            }

            if (duplicateUsers.Count != 0)
            {
                lblError.Text = "Det finns likadana användarnamn som förekommer i båda listorna.";
                return;
            }

            try
            {
                settings = new();

                foreach (string forum in cklForums.CheckedItems)
                {
                    for (int i = 0; i < forums.Count; i++)
                    {
                        if (forum == forums[i])
                        {
                            settings.Forums.Add(i, forum);
                            break;
                        }
                    }
                }

                settings.UsersShowAlerts.AddRange(txtSpecificUsersShowAlerts.Lines);
                settings.UsersDoNotShowAlerts.AddRange(txtSpecificUsersDoNotShowAlerts.Lines);

                settings.Interval = (int)numericUpDownInterval.Value;

                var json = JsonSerializer.Serialize(settings, jsonSerializerOptions);

                using var sw = File.CreateText(settingsFileName);
                sw.Write(json);
                sw.Close();

                lblSettingsSaved.ForeColor = Color.Green;
                lblSettingsSaved.Text = $"Dina inställningar har sparats.";
                lblError.Text = "";

                LoadSettings();
            }
            catch (Exception ex)
            {
                lblError.Text = "Något gick fel när inställningarna skulle sparas.";
            }
        }

        private void CklForums_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = cklForums.SelectedIndex;

            if (selectedIndex != -1)
            {
                var isChecked = cklForums.GetItemChecked(selectedIndex);
                cklForums.SetItemChecked(selectedIndex, !isChecked);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
                timer = null;
            }

            base.OnFormClosing(e);
        }

        private void ChkSelectDeselectAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cklForums.Items.Count; i++)
            {
                cklForums.SetItemChecked(i, chkSelectDeselectAll.Checked);
            }
        }
    }
}
