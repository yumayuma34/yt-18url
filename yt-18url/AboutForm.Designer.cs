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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.labelAppName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelYtDlpVersion = new System.Windows.Forms.Label();
            this.textBoxDisclaimer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAppName
            // 
            this.labelAppName.AutoSize = true;
            this.labelAppName.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelAppName.Location = new System.Drawing.Point(20, 20);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(0, 25);
            this.labelAppName.TabIndex = 0;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(22, 60);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(0, 12);
            this.labelVersion.TabIndex = 1;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(22, 90);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(0, 12);
            this.labelAuthor.TabIndex = 2;
            // 
            // labelYtDlpVersion
            // 
            this.labelYtDlpVersion.AutoSize = true;
            this.labelYtDlpVersion.Location = new System.Drawing.Point(22, 120);
            this.labelYtDlpVersion.Name = "labelYtDlpVersion";
            this.labelYtDlpVersion.Size = new System.Drawing.Size(0, 12);
            this.labelYtDlpVersion.TabIndex = 3;
            // 
            // textBoxDisclaimer
            // 
            this.textBoxDisclaimer.Location = new System.Drawing.Point(25, 160);
            this.textBoxDisclaimer.Multiline = true;
            this.textBoxDisclaimer.Name = "textBoxDisclaimer";
            this.textBoxDisclaimer.ReadOnly = true;
            this.textBoxDisclaimer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDisclaimer.Size = new System.Drawing.Size(350, 120);
            this.textBoxDisclaimer.TabIndex = 4;
            // 
            // AboutForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.labelAppName);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelYtDlpVersion);
            this.Controls.Add(this.textBoxDisclaimer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.Text = "バージョン情報";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
