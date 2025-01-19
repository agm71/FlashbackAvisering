namespace FlashbackAvisering
{
    partial class FrmNotification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNewPost = new Label();
            lblUser = new Label();
            lnklblTopic = new LinkLabel();
            SuspendLayout();
            // 
            // lblNewPost
            // 
            lblNewPost.Font = new Font("Verdana", 10F);
            lblNewPost.Location = new Point(63, 19);
            lblNewPost.Name = "lblNewPost";
            lblNewPost.Size = new Size(218, 20);
            lblNewPost.TabIndex = 0;
            lblNewPost.Text = "postade ett inlägg i:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Verdana", 10F, FontStyle.Bold);
            lblUser.ForeColor = SystemColors.ActiveCaptionText;
            lblUser.Location = new Point(14, 19);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(0, 17);
            lblUser.TabIndex = 2;
            // 
            // lnklblTopic
            // 
            lnklblTopic.ActiveLinkColor = Color.Firebrick;
            lnklblTopic.AutoSize = true;
            lnklblTopic.Font = new Font("Verdana", 10F, FontStyle.Bold);
            lnklblTopic.LinkBehavior = LinkBehavior.NeverUnderline;
            lnklblTopic.LinkColor = Color.Firebrick;
            lnklblTopic.Location = new Point(14, 54);
            lnklblTopic.Name = "lnklblTopic";
            lnklblTopic.Size = new Size(648, 17);
            lnklblTopic.TabIndex = 3;
            lnklblTopic.TabStop = true;
            lnklblTopic.Text = "Är separerade föräldrar alltid lite sämre än sammanboende föräldrar för ett barn? ";
            lnklblTopic.VisitedLinkColor = Color.Firebrick;
            lnklblTopic.LinkClicked += LnklblTopic_LinkClicked;
            // 
            // FrmNotification
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(381, 109);
            Controls.Add(lnklblTopic);
            Controls.Add(lblNewPost);
            Controls.Add(lblUser);
            Font = new Font("Verdana", 9F);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNotification";
            Text = "Flashback Avisering";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNewPost;
        private Label lblUser;
        private LinkLabel lnklblTopic;
    }
}