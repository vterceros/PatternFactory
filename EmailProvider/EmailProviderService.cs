using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory.EmailProvider
{
    class EmailProviderService : IEmailProvider
    {
        public EmailProviderService()
        {}
        public bool Send(string message, string[] to, string[] bccTo, string subject)
        {
            //call the service here
            Console.WriteLine("Sending email using a service");
            Console.WriteLine("Email sent");
            return true;
        }
    }
}
