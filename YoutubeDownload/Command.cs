namespace YoutubeDownload;

abstract class VideoCommand
{
    public abstract void Run(string videoURL);
}