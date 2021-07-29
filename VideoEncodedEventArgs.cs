using System;

namespace EventsExample
{
    public class VideoEncodedEventArgs : EventArgs
    {
        public Video VideoEncoded { get; set; }
    }
}
