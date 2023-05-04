using YoutubeExplode;

namespace YoutubeDownload
{
    /// <summary>
    /// Адресат команды
    /// </summary>
    class Receiver
    {
        public YoutubeClient client;
        public Receiver()
        {
            this.client = new YoutubeClient();
        }
    }
}