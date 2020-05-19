using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DelegatesAndEvents
{
    class VideEncoder
    {
        //1. Define a Delegate
        //2. Define an event based on delegate
        //3. Publish Event

        public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        public event VideoEncodedEventHandler videoEncoded;



        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);
            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            if(videoEncoded!=null)
            {
                videoEncoded(this, EventArgs.Empty);
            }
        }
    }
}
