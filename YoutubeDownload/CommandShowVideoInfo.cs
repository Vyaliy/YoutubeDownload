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
        public override async Task Run(string videoURL)
        {
            Video video;
            video = await receiver.client.Videos.GetAsync(videoURL);
            Console.WriteLine(
                $"Video name: {video.Title}" +
                $"\n\nDescription of video:\n{video.Description}"
                );
        }
    }
}