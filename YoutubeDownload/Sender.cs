namespace YoutubeDownload
{
    /// <summary>
    /// Отправитель команды
    /// </summary>
    class Sender
    {
        VideoCommand _command;
        string _videoURL;

        public void SetCommand(VideoCommand command, string videoURL)
        {
            _command = command;
            _videoURL = videoURL;
        }

        // Выполнить
        public async Task Run()
        {
            await _command.Run(_videoURL);
        }
    }
}