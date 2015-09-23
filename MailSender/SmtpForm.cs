using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailSender
{
    public partial class SmtpForm : Form
    {
        public SmtpInfo Info
        {
            get
            {
                var password = String.Empty;
                int i = 4;
                foreach (var item in tbPassword.Text)
                {
                    password += string.Format("{0}{1}{2}", item, i, i - 5);
                    i++;
                }
                return new SmtpInfo
                {
                    LetterLimit = int.Parse(tbLimit.Text.Trim()),
                    Login = tbLogin.Text.Trim(),
                    Password = password,
                    Port = int.Parse(tbPort.Text.Trim()),
                    Server = tbSmptServer.Text.Trim(),
                    SleepTime = int.Parse(tbSleepTime.Text.Trim())
                };
            }
            set
            {
                tbLimit.Text = value.LetterLimit.ToString();
                tbLogin.Text = value.Login;
                tbPassword.Text = @"*********";
                tbPort.Text = value.Port.ToString();
                tbSmptServer.Text = value.Server;
                tbSleepTime.Text = value.SleepTime.ToString();
            }
        }
        public SmtpForm()
        {
            InitializeComponent();
        }
    }
}
