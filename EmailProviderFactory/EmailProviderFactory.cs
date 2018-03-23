using PatternFactory.EmailProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory.EmailProviderFactory
{
    public class EmailProviderFactory
    {
        static EmailProviderFactory()
        { }

        public static IEmailProvider GetProvider(string ProviderType)
        {
            switch (ProviderType.ToLower())
            {
                case "service":
                    return new EmailProviderService();
                case "systemnet":
                    return new EmailProviderSystemNet();
                default:
                    throw new NotSupportedException(string.Format("ProviderType {0} is not supported", ProviderType));
            }
        }
    }
}
