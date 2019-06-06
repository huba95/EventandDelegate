﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventandDelegate
{
    class VideoEncoder
    {

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //public event VideoEncodedEventHandler VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded !=null)
            {
                VideoEncoded(this, new VideoEventArgs() {Video = video });
            }
        }
    }
}
