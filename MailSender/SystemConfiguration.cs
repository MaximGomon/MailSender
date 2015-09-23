using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender
{
    public class SystemConfiguration
    {
        public string Name { get; set; }
        public List<SmtpInfo> Servers { get; set; }

        public SystemConfiguration()
        {
            Servers = new List<SmtpInfo>();
        }

        

    }
}
