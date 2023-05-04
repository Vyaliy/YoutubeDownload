namespace YoutubeDownload;

abstract class VideoCommand
{
    public abstract Task Run(string videoURL);
}