using System.Diagnostics;

namespace FlashbackAvisering
{
    public partial class FrmNotification : Form
    {
        public FrmNotification()
        {
            InitializeComponent();
        }

        public Label UserNameLabel => lblUser;
        public LinkLabel Topic => lnklblTopic;

        private void Form2_Load(object sender, EventArgs e)
        {
            var screenBounds = Screen.PrimaryScreen.WorkingArea;
            Location = new Point(screenBounds.Right - Width, screenBounds.Bottom - Height);
            TopMost = true;
            ShowInTaskbar = false;
            lblNewPost.Left = lblUser.Left + lblUser.Width;
            lnklblTopic.MaximumSize = new Size(350, 0);
        }

        private void LnklblTopic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var linkLabel = sender as LinkLabel;

            var processInfo = new ProcessStartInfo
            {
                FileName = $"https://www.flashback.org{linkLabel!.Tag as string}",
                UseShellExecute = true
            };
            Process.Start(processInfo);
            this.Close();
        }
    }
}
