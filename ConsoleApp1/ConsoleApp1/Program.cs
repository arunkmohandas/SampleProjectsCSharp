using System;

namespace DelegatesAndEvents
{
    //https://www.youtube.com/watch?v=jQgwEsJISy0
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video1" };
            var videoEncoder = new VideEncoder();//publisher
            var mailService = new MailService();//subscriber
            var messageService = new MessageService();//sub

            videoEncoder.videoEncoded += mailService.OnVideoEncoded;
            videoEncoder.videoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }

    
}
