using PatternFactory.EmailProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your provider");
            SendEmail(Console.ReadLine());
            Console.ReadKey();
        }

        private static void SendEmail(string Provider)
        {
            try
            {
                IEmailProvider emailProvider = EmailProviderFactory.EmailProviderFactory.GetProvider(Provider);
                emailProvider.Send("hello", (new string[] { "hi@t.com", "hi@t.com" }), null, "subject");
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(string.Format("Not supported with message '{0}'", ex.Message));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
