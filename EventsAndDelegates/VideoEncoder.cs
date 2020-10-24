using System;
using System.Threading;

namespace EventsAndDelegates
{

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        //1- Define a delegate
        //2- Define a event based on that delegate
        //3- Raise the event
        //public delegate void VideoEncondedEventHandler(object source, VideoEventArgs args);
        
        //EventHandler<TEventArgs> 
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public void Encoded(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(2000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() {Video = video});
            }
        }
    }
}
