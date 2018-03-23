using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory.EmailProvider
{
    public interface IEmailProvider
    {
        bool Send(string message, string[] to, string[] bccTo, string subject);
    }
}
