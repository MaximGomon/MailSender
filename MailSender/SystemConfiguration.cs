using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender
{
    public class SystemConfiguration
    {
        public string Name { get; set; }
        public List<SmtpInfo> Servers { get; set; }

        private string ConfigurationFilePath
        {
            get { return Directory.GetCurrentDirectory() + @"\system.config"; }
        }

        public SystemConfiguration()
        {
            Servers = new List<SmtpInfo>();
        }

        public static SystemConfiguration LoadConfiguration()
        {
            throw new NotImplementedException();
        }

        public static SystemConfiguration SaveConfiguration(SystemConfiguration configuration)
        {
            throw new NotImplementedException();
        }
    }
}
