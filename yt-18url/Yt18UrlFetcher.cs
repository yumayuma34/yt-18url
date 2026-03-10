using System.Diagnostics;

namespace yt_18url
{
    public static class Yt18UrlFetcher
    {
        public static (string output, string error) Fetch(string inputUrl)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "yt-dlp",
                Arguments = $"--no-warnings --get-url -f 18 \"{inputUrl}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var process = Process.Start(psi))
            {
                string output = process.StandardOutput.ReadToEnd().Trim();
                string error = process.StandardError.ReadToEnd().Trim();
                process.WaitForExit();

                return (output, error);
            }
        }
    }
}