using System;

namespace EventsExample
{
    public class MailService
    {
        //This method signature matches the delegate defined in the event publisher (VideoEncoder)
        //so it will be used to say: "hey.. do this when you finish encoding" (see line 13)
        //public void OnVideoEncodedEventHandler(object source, EventArgs eventArgs)
        public void OnVideoEncodedEventHandler(object source, VideoEncodedEventArgs veea)
        {
            Console.WriteLine($"MailService: sending an email for video {veea.VideoEncoded.Title}... #sqn");
        }
    }
}
