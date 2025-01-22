using System;

namespace FlashbackAvisering
{
    partial class FrmSettings
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cklForums = new CheckedListBox();
            grpForums = new GroupBox();
            chkSelectDeselectAll = new CheckBox();
            lblSelectForums = new Label();
            grpUsers = new GroupBox();
            lblDoNotShowAlertsForSpecificUsers = new Label();
            lblShowAlertsForSpecificUsers = new Label();
            label3 = new Label();
            txtSpecificUsersDoNotShowAlerts = new TextBox();
            txtSpecificUsersShowAlerts = new TextBox();
            btnSaveSettings = new Button();
            grpInterval = new GroupBox();
            label2 = new Label();
            numericUpDownInterval = new NumericUpDown();
            label1 = new Label();
            lblIntervalInfo = new Label();
            lblSettingsSaved = new Label();
            lblError = new Label();
            grpForums.SuspendLayout();
            grpUsers.SuspendLayout();
            grpInterval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInterval).BeginInit();
            SuspendLayout();
            // 
            // cklForums
            // 
            cklForums.Font = new Font("Verdana", 10F);
            cklForums.FormattingEnabled = true;
            cklForums.Location = new Point(13, 112);
            cklForums.Name = "cklForums";
            cklForums.Size = new Size(327, 289);
            cklForums.TabIndex = 1;
            cklForums.SelectedIndexChanged += CklForums_SelectedIndexChanged;
            // 
            // grpForums
            // 
            grpForums.Controls.Add(chkSelectDeselectAll);
            grpForums.Controls.Add(lblSelectForums);
            grpForums.Controls.Add(cklForums);
            grpForums.Font = new Font("Verdana", 10F);
            grpForums.Location = new Point(12, 12);
            grpForums.Name = "grpForums";
            grpForums.Size = new Size(356, 419);
            grpForums.TabIndex = 3;
            grpForums.TabStop = false;
            grpForums.Text = "Forum";
            // 
            // chkSelectDeselectAll
            // 
            chkSelectDeselectAll.AutoSize = true;
            chkSelectDeselectAll.Location = new Point(13, 68);
            chkSelectDeselectAll.Name = "chkSelectDeselectAll";
            chkSelectDeselectAll.Size = new Size(188, 21);
            chkSelectDeselectAll.TabIndex = 5;
            chkSelectDeselectAll.Text = "Markera/avmarkera alla";
            chkSelectDeselectAll.UseVisualStyleBackColor = true;
            chkSelectDeselectAll.CheckedChanged += ChkSelectDeselectAll_CheckedChanged;
            // 
            // lblSelectForums
            // 
            lblSelectForums.AutoSize = true;
            lblSelectForums.Location = new Point(13, 31);
            lblSelectForums.MaximumSize = new Size(350, 0);
            lblSelectForums.Name = "lblSelectForums";
            lblSelectForums.Size = new Size(298, 17);
            lblSelectForums.TabIndex = 4;
            lblSelectForums.Text = "Ange vilka forum du vill få aviseringar för.";
            // 
            // grpUsers
            // 
            grpUsers.Controls.Add(lblDoNotShowAlertsForSpecificUsers);
            grpUsers.Controls.Add(lblShowAlertsForSpecificUsers);
            grpUsers.Controls.Add(label3);
            grpUsers.Controls.Add(txtSpecificUsersDoNotShowAlerts);
            grpUsers.Controls.Add(txtSpecificUsersShowAlerts);
            grpUsers.Font = new Font("Verdana", 10F);
            grpUsers.Location = new Point(390, 12);
            grpUsers.Name = "grpUsers";
            grpUsers.Size = new Size(400, 451);
            grpUsers.TabIndex = 4;
            grpUsers.TabStop = false;
            grpUsers.Text = "Användare";
            // 
            // lblDoNotShowAlertsForSpecificUsers
            // 
            lblDoNotShowAlertsForSpecificUsers.AutoSize = true;
            lblDoNotShowAlertsForSpecificUsers.Location = new Point(11, 283);
            lblDoNotShowAlertsForSpecificUsers.Name = "lblDoNotShowAlertsForSpecificUsers";
            lblDoNotShowAlertsForSpecificUsers.Size = new Size(298, 17);
            lblDoNotShowAlertsForSpecificUsers.TabIndex = 15;
            lblDoNotShowAlertsForSpecificUsers.Text = "Visa inte aviseringar för dessa användare";
            // 
            // lblShowAlertsForSpecificUsers
            // 
            lblShowAlertsForSpecificUsers.AutoSize = true;
            lblShowAlertsForSpecificUsers.Location = new Point(11, 125);
            lblShowAlertsForSpecificUsers.Name = "lblShowAlertsForSpecificUsers";
            lblShowAlertsForSpecificUsers.Size = new Size(320, 17);
            lblShowAlertsForSpecificUsers.TabIndex = 14;
            lblShowAlertsForSpecificUsers.Text = "Visa endast aviseringar för dessa användare";
            // 
            // label3
            // 
            label3.Location = new Point(11, 31);
            label3.Name = "label3";
            label3.Size = new Size(384, 73);
            label3.TabIndex = 12;
            label3.Text = "Här kan du ange om du endast vill se aviseringar för specifika användare, eller om du inte vill se aviseringar för specifika användare. Ange ett (1) användarnamn per rad.";
            // 
            // txtSpecificUsersDoNotShowAlerts
            // 
            txtSpecificUsersDoNotShowAlerts.Location = new Point(11, 318);
            txtSpecificUsersDoNotShowAlerts.Multiline = true;
            txtSpecificUsersDoNotShowAlerts.Name = "txtSpecificUsersDoNotShowAlerts";
            txtSpecificUsersDoNotShowAlerts.Size = new Size(327, 111);
            txtSpecificUsersDoNotShowAlerts.TabIndex = 11;
            // 
            // txtSpecificUsersShowAlerts
            // 
            txtSpecificUsersShowAlerts.Location = new Point(11, 156);
            txtSpecificUsersShowAlerts.Multiline = true;
            txtSpecificUsersShowAlerts.Name = "txtSpecificUsersShowAlerts";
            txtSpecificUsersShowAlerts.Size = new Size(327, 109);
            txtSpecificUsersShowAlerts.TabIndex = 7;
            // 
            // btnSaveSettings
            // 
            btnSaveSettings.Font = new Font("Verdana", 10F);
            btnSaveSettings.Location = new Point(660, 465);
            btnSaveSettings.Name = "btnSaveSettings";
            btnSaveSettings.Size = new Size(130, 41);
            btnSaveSettings.TabIndex = 5;
            btnSaveSettings.Text = "Spara";
            btnSaveSettings.UseVisualStyleBackColor = true;
            btnSaveSettings.Click += BtnSaveSettings_Click;
            // 
            // grpInterval
            // 
            grpInterval.Controls.Add(label2);
            grpInterval.Controls.Add(numericUpDownInterval);
            grpInterval.Controls.Add(label1);
            grpInterval.Controls.Add(lblIntervalInfo);
            grpInterval.Font = new Font("Verdana", 10F);
            grpInterval.Location = new Point(12, 437);
            grpInterval.Name = "grpInterval";
            grpInterval.Size = new Size(357, 97);
            grpInterval.TabIndex = 7;
            grpInterval.TabStop = false;
            grpInterval.Text = "Intervall";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 62);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 9;
            label2.Text = "sekund";
            // 
            // numericUpDownInterval
            // 
            numericUpDownInterval.Location = new Point(45, 60);
            numericUpDownInterval.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
            numericUpDownInterval.Name = "numericUpDownInterval";
            numericUpDownInterval.Size = new Size(62, 24);
            numericUpDownInterval.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 62);
            label1.Name = "label1";
            label1.Size = new Size(31, 17);
            label1.TabIndex = 8;
            label1.Text = "Var";
            // 
            // lblIntervalInfo
            // 
            lblIntervalInfo.AutoSize = true;
            lblIntervalInfo.Location = new Point(6, 29);
            lblIntervalInfo.Name = "lblIntervalInfo";
            lblIntervalInfo.Size = new Size(218, 17);
            lblIntervalInfo.TabIndex = 8;
            lblIntervalInfo.Text = "Hur ofta vill du få aviseringar?";
            // 
            // lblSettingsSaved
            // 
            lblSettingsSaved.AutoSize = true;
            lblSettingsSaved.Font = new Font("Verdana", 10F, FontStyle.Bold);
            lblSettingsSaved.ForeColor = Color.Green;
            lblSettingsSaved.Location = new Point(390, 478);
            lblSettingsSaved.Name = "lblSettingsSaved";
            lblSettingsSaved.Size = new Size(0, 17);
            lblSettingsSaved.TabIndex = 8;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Verdana", 10F);
            lblError.ForeColor = Color.Firebrick;
            lblError.Location = new Point(12, 543);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 17);
            lblError.TabIndex = 9;
            // 
            // FrmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 573);
            Controls.Add(lblError);
            Controls.Add(lblSettingsSaved);
            Controls.Add(grpInterval);
            Controls.Add(btnSaveSettings);
            Controls.Add(grpUsers);
            Controls.Add(grpForums);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmSettings";
            Text = "Flashback Avisering";
            Load += Form1_Load;
            grpForums.ResumeLayout(false);
            grpForums.PerformLayout();
            grpUsers.ResumeLayout(false);
            grpUsers.PerformLayout();
            grpInterval.ResumeLayout(false);
            grpInterval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInterval).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox cklForums;
        private GroupBox grpForums;
        private Label lblSelectForums;
        private GroupBox grpUsers;
        private Button btnSaveSettings;
        private TextBox txtSpecificUsersShowAlerts;
        private GroupBox grpInterval;
        private Label lblIntervalInfo;
        private Label label1;
        private NumericUpDown numericUpDownInterval;
        private Label label2;
        private TextBox txtSpecificUsersDoNotShowAlerts;
        private Label label3;
        private Label lblDoNotShowAlertsForSpecificUsers;
        private Label lblShowAlertsForSpecificUsers;
        private Label lblSettingsSaved;
        private Label lblError;
        private CheckBox chkSelectDeselectAll;
    }
}
