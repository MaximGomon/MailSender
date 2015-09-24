using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailSender
{
    [DataContract]
    public class SmtpInfo
    {
        [DataMember]
        public string Server { get; set; }

        [DataMember]
        public int Port { get; set; }

        [DataMember]
        public int SleepTime { get; set; }

        [DataMember]
        public string Login { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public int LetterLimit { get; set; }

        [DataMember]
        public bool UseSsl { get; set; }
    }
}
