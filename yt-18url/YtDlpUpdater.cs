using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace yt_18url
{
    public static class YtDlpUpdater
    {
        private const string ApiUrl = "https://api.github.com/repos/yt-dlp/yt-dlp/releases/latest";
        private const string LocalExe = "yt-dlp.exe";

        public static string GetLocalVersion()
        {
            if (!File.Exists(LocalExe))
                return null;

            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = LocalExe,
                Arguments = "--version",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var p = System.Diagnostics.Process.Start(psi))
            {
                string output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();
                return output.Trim();
            }
        }

        public static (string version, string downloadUrl) GetLatestVersion()
        {
            var client = new WebClient();
            client.Headers.Add("User-Agent", "yt-18url");

            string json = client.DownloadString(ApiUrl);
            JObject data = JObject.Parse(json);

            string version = data["tag_name"].ToString();

            string url = null;
            foreach (var asset in data["assets"])
            {
                string name = asset["name"].ToString();
                if (name.EndsWith("yt-dlp.exe"))
                {
                    url = asset["browser_download_url"].ToString();
                    break;
                }
            }

            if (url == null)
                throw new Exception("Windows 用 yt-dlp.exe が見つかりませんでした。");

            return (version, url);
        }

        public static void DownloadLatest(string url)
        {
            var client = new WebClient();
            client.DownloadFile(url, LocalExe);
        }
    }
}