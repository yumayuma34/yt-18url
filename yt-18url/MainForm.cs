using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yt_18url
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            CheckYtDlpOnStartup();
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            var about = new AboutForm();
            about.ShowDialog();
        }

        private async void CheckYtDlpOnStartup()
        {
            string local = YtDlpUpdater.GetLocalVersion();
            var latest = await Task.Run(() => YtDlpUpdater.GetLatestVersion());

            if (local == null)
            {
                if (MessageBox.Show(
                    $"yt-dlp が見つかりません。\n最新版 {latest.version} をダウンロードしますか？",
                    "yt-dlp 更新",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await Task.Run(() => YtDlpUpdater.DownloadLatest(latest.downloadUrl));
                    MessageBox.Show("ダウンロード完了");
                }
                return;
            }

            if (local != latest.version)
            {
                if (MessageBox.Show(
                    $"新しいバージョンがあります。\n現在: {local}\n最新: {latest.version}\n更新しますか？",
                    "yt-dlp 更新",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await Task.Run(() => YtDlpUpdater.DownloadLatest(latest.downloadUrl));
                    MessageBox.Show("更新完了");
                }
            }
        }
        private async void buttonFetch_Click(object sender, EventArgs e)
        {
            string url = textBoxUrl.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("URL を入力してください。");
                return;
            }

            textBoxResult.Text = "取得中…";

            var result = await Task.Run(() => Yt18UrlFetcher.Fetch(url));

            if (!string.IsNullOrEmpty(result.error))
            {
                textBoxResult.Text = "エラー:\r\n" + result.error;
                MessageBox.Show("yt-dlp がエラーを返しました:\n\n" + result.error);
                return;
            }

            textBoxResult.Text = result.output;

            if (!string.IsNullOrEmpty(result.output))
            {
                Clipboard.SetText(result.output);
            }
        }

        private async void menuUpdate_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "yt-dlp のバージョン確認中…";

            string local = YtDlpUpdater.GetLocalVersion();
            var latest = await Task.Run(() => YtDlpUpdater.GetLatestVersion());

            if (local == null)
            {
                if (MessageBox.Show(
                    $"yt-dlp が見つかりません。\n最新版 {latest.version} をダウンロードしますか？",
                    "yt-dlp 更新",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await Task.Run(() => YtDlpUpdater.DownloadLatest(latest.downloadUrl));
                    MessageBox.Show("ダウンロード完了");
                }
                return;
            }

            if (local != latest.version)
            {
                if (MessageBox.Show(
                    $"新しいバージョンがあります。\n現在: {local}\n最新: {latest.version}\n更新しますか？",
                    "yt-dlp 更新",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await Task.Run(() => YtDlpUpdater.DownloadLatest(latest.downloadUrl));
                    MessageBox.Show("更新完了");
                }
            }
            else
            {
                MessageBox.Show("yt-dlp は最新です。");
            }
        }
    }
}