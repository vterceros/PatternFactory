using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory.EmailProvider
{
    class EmailProviderSystemNet : IEmailProvider
    {
        public EmailProviderSystemNet()
        {
        }
        public bool Send(string message, string[] to, string[] bccTo, string subject)
        {
            //call System.Net.Mail.MailMessage
            Console.WriteLine("Sending email using a library named system.net");
            Console.WriteLine("Email sent");
            return true;
        }
    }
}
