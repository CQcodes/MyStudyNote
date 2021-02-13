using System;

namespace CSharp
{
    public class Video
    {
        public string Title { get; set; }
    }

    public class VideoEventArgs: EventArgs
    {
        private Video _video;
        public VideoEventArgs(Video video)
        {
            _video = video;
        }
        public Video EncodedVideo { get { return _video; } }
    }

    // public delegate void VideoEncodedEventHandler(object sender, VideoEventArgs args);
    // No need to declare Delegate always
    // .net has inbuilt delegates => EventHandler, EventHandler<TEventArgs> where TEventArgs : EventArgs
    public class VideoEncoder
    {
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine($"Encoding video : {video.Title}");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine($"Encoded video : {video.Title}");

            // invoke event publicher method here
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            //publish event here
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs(video));
        }
    }

    public class MailService
    {
        public void SendMailOnVideoCoded(object sender, VideoEventArgs args)
        {
            Console.WriteLine($"Mail sent after encoding the video : {args.EncodedVideo.Title}");
        }
    }
    public class SlcakService
    {
        public void SendSlackMessageOnVideoCoded(object sender, VideoEventArgs args)
        {
            Console.WriteLine($"Slack Message sent after encoding the video : {args.EncodedVideo.Title}");
        }
    }

    public class SmsService
    {
        public void SendSmsOnVideoCoded(object sender, VideoEventArgs args)
        {
            Console.WriteLine($"SMS sent after encoding the video : {args.EncodedVideo.Title}");
        }
    }
}
