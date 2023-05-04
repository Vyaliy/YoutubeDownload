using YoutubeExplode;
using YoutubeExplode.Videos;

namespace YoutubeDownload
{
    /// <summary>
    /// Команда для просмотра информации о видео
    /// </summary>
    class CommandShowVideoInfo : VideoCommand
    {
        Receiver receiver;

        public CommandShowVideoInfo(Receiver receiver)
        {
            this.receiver = receiver;
        }

        // Выполнить
        public override void Run(string videoURL)
        {
            Video video = receiver.client.Videos.GetAsync(videoURL).Result;
            Console.WriteLine(
                $"Video name: {video.Title}" +
                $"\n\nDescription of video:\n{video.Description}"
                );
        }
    }
}