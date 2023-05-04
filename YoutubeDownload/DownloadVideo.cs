using System.Diagnostics;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace YoutubeDownload
{
    /// <summary>
    /// Команда для скачивания видео
    /// </summary>
    class DownloadVideo : VideoCommand
    {
        Receiver receiver;

        public DownloadVideo(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public override async Task Run(string videoURL)
        {
            var progress = new Progress<double>();
            progress.ProgressChanged += (s, e) => Console.WriteLine($"Загружено: {e:P2}");

            var streamManifest = await receiver.client.Videos.Streams.GetManifestAsync(videoURL);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            await receiver.client.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}", progress);
        }
    }
}