using CliWrap;
using System.Text;
using YoutubeExplode.Converter;
using YoutubeExplode.Search;

namespace YoutubeDownload
{
    internal partial class Program
    {
        static async Task Main(string[] args)
        {
            // создаем строку со ссылкой на видео
            string videoURL = "https://www.youtube.com/watch?v=jNQXAC9IVRw";

            // создадим отправителя
            var sender = new Sender();

            // создадим получателя
            var receiver = new Receiver();

            // создадим команды
            var showVideoDesc = new CommandShowVideoInfo(receiver);
            var downloadVideo = new DownloadVideo(receiver);

            // инициализация команды для отображения информации о видео
            sender.SetCommand(showVideoDesc, videoURL);


            // выполнение команды
            await Run(sender);

            // инициализация команды для скачивания видео
            sender.SetCommand(downloadVideo, videoURL);

            // выполнение команды
            await Run(sender);

            Console.WriteLine("Успешно!");
            Console.ReadKey();
        }
        public static async Task Run(Sender sender)
        {
            await sender.Run();
        }
    }
}