using System;

namespace EventsExample
{
    public class MessageService
    {
        public void OnVideoEncodedEventHandler(object source, VideoEncodedEventArgs veea)
        {
            Console.WriteLine($"MessageService: Sending a text message for video {veea.VideoEncoded.Title}... #sqn");
        }
    }
}
