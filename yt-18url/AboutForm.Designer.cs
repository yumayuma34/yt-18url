using System.Windows.Forms;

namespace yt_18url
{
    partial class AboutForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelAppName;
        private Label labelVersion;
        private Label labelAuthor;
        private Label labelYtDlpVersion;
        private TextBox textBoxDisclaimer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelAppName = new Label();
            this.labelVersion = new Label();
            this.labelAuthor = new Label();
            this.labelYtDlpVersion = new Label();
            this.textBoxDisclaimer = new TextBox();

            this.SuspendLayout();

            this.labelAppName.AutoSize = true;
            this.labelAppName.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelAppName.Location = new System.Drawing.Point(20, 20);

            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(22, 60);

            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(22, 90);

            this.labelYtDlpVersion.AutoSize = true;
            this.labelYtDlpVersion.Location = new System.Drawing.Point(22, 120);

            this.textBoxDisclaimer.Location = new System.Drawing.Point(25, 160);
            this.textBoxDisclaimer.Multiline = true;
            this.textBoxDisclaimer.ReadOnly = true;
            this.textBoxDisclaimer.ScrollBars = ScrollBars.Vertical;
            this.textBoxDisclaimer.Size = new System.Drawing.Size(350, 120);

            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.labelAppName);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelYtDlpVersion);
            this.Controls.Add(this.textBoxDisclaimer);
            this.Text = "バージョン情報";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
