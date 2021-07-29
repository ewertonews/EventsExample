namespace EventsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Avengers.mp4" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            var messageService = new MessageService(); //subcriber

            //registering a handler for that event
            //behind the scenes VideoEncoded is a list of points to methods
            videoEncoder.VideoEncoded += mailService.OnVideoEncodedEventHandler;
            videoEncoder.VideoEncoded += messageService.OnVideoEncodedEventHandler;

            videoEncoder.Encode(video);
        }

    }
}
