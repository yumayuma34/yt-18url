using System;
using System.Windows.Forms;

namespace yt_18url
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            labelAppName.Text = "yt-18url";
            labelVersion.Text = "バージョン: 1.0.0.0";
            labelAuthor.Text = "制作者: yumayuma34";
            labelYtDlpVersion.Text = "yt-dlp バージョン: " + GetYtDlpVersionSafe();
            textBoxDisclaimer.Text =
                "本ソフトウェアの使用により生じたいかなる損害についても、制作者は責任を負いません。\r\n" +
                "自己責任でご利用ください。";
        }

        private string GetYtDlpVersionSafe()
        {
            try
            {
                string v = YtDlpUpdater.GetLocalVersion();
                return v ?? "未インストール";
            }
            catch
            {
                return "取得できませんでした";
            }
        }
    }
}
