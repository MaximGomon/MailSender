using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender
{
    public class SmtpInfo
    {
        public string Server { get; set; }
        public int Port { get; set; }
        public int SleepTime { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int LetterLimit { get; set; }
        public bool UseSsl { get; set; }
    }
}
