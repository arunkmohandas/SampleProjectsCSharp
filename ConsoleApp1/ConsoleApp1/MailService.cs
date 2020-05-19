using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEvents
{
    public class MailService
    {
        public void OnVideoEncoded(object obj, EventArgs e)
        {
            Console.WriteLine("Mail Service Seding an email...");
        }
    }
}
