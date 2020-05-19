using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEvents
{
    class MessageService
    {
        public void OnVideoEncoded(object obj, EventArgs e)
        {
            Console.WriteLine("Message Service Seding a message...");
        }
    }
}
