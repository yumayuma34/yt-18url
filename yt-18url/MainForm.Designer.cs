namespace yt_18url
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Button buttonFetch;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuUpdate;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.buttonFetch = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();

            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuUpdate,
                this.menuAbout
            });

            this.menuUpdate.Text = "yt-dlp の更新を確認";
            this.menuUpdate.Click += new System.EventHandler(this.menuUpdate_Click);

            this.menuAbout.Text = "バージョン情報";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);

            this.textBoxUrl.Location = new System.Drawing.Point(12, 40);
            this.textBoxUrl.Size = new System.Drawing.Size(500, 23);

            this.buttonFetch.Location = new System.Drawing.Point(520, 40);
            this.buttonFetch.Size = new System.Drawing.Size(75, 23);
            this.buttonFetch.Text = "取得";
            this.buttonFetch.Click += new System.EventHandler(this.buttonFetch_Click);

            this.textBoxResult.Location = new System.Drawing.Point(12, 80);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(580, 300);

            this.ClientSize = new System.Drawing.Size(604, 401);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.buttonFetch);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Text = "yt-18url";
        }
    }
}