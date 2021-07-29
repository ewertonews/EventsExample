using System;
using System.Threading;

namespace EventsExample
{
    //Requirement: implement an event in the video encoder 
    //such that when the encoding is finished it notifies anyone who 
    //is interested in that event.
    class VideoEncoder
    {
        //STEPS:
        //1 - Define a delegate that is the agreement between the publisher and the subscriber. 
        //that delegate will be called when the publisher publishes an event.
        //2 - Define an event based on that delegate
        //3 - Raise the event

        //1
        //[Before] public delegate void VideoEncodedEventHandler(object sender, VideoEncodedEventArgs args);

        //There is a newer way of creating a delegate for handling events:
        //EventHandler 
        //EventHandler<TEventArgs>

        //2
        //[Before] public event VideoEncodedEventHandler VideoEncoded;

        //We use type here if we want to send adicional data  with the event
        //This excludes the need for step 1
        public event EventHandler<VideoEncodedEventArgs> VideoEncoded;
        
       

        public void Encode(Video video)
        {
            Console.WriteLine($"Encoding video {video.Title}...");
            Thread.Sleep(3000);
            Console.WriteLine("Encode finished.");

            OnVideoEncoded(video);
        }

        //3
        //Specification of how we notify the subscribers
        protected virtual void OnVideoEncoded(Video video)
        {
            //if (VideoEncoded != null)
            //    VideoEncoded(this, EventArgs.Empty);

            //This is a simplification of the above
            VideoEncoded?.Invoke(this, new VideoEncodedEventArgs { VideoEncoded = video });
        }
    }
}
