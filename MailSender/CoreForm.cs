using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailSender;

namespace Flyman.MailSender
{
    public partial class CoreForm : Form
    {
        public CoreForm()
        {
            InitializeComponent();
            Configuration = SystemConfiguration.LoadConfiguration();
        }

        public SmtpInfo CurreentServer { get; set; }

        public SystemConfiguration Configuration { get; set; }

        private void LoadEmailsToForm(string fileName)
        {
            var emails = Utils.ReadMailFromExcel(fileName);
            foreach (var email in emails)
            {
                AddNewItemToEmailListView(email);
            }
        }

        private void SendMailTo(string email)
        {
            if (CurreentServer.LetterLimit == 0)
            {
                GetNextSmtpServer();
            }
            if (CurreentServer.LetterLimit > 0)
            {
                var client = new SmtpClient();
                client.Port = CurreentServer.Port;
                client.Host = CurreentServer.Server;
                client.EnableSsl = CurreentServer.UseSsl;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;

                string password = String.Empty;
                for (int i = 0; i < CurreentServer.Password.Length; i += 3)
                {
                    password += CurreentServer.Password[i];
                }
                client.Credentials = new System.Net.NetworkCredential(CurreentServer.Login, password);

                var mailMessage = new MailMessage(CurreentServer.Login, email, tbMailSubject.Text, rtbEmailText.Text);
                mailMessage.BodyEncoding = UTF8Encoding.UTF8;
                mailMessage.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                client.Send(mailMessage);

                CurreentServer.LetterLimit--;
            }
        }

        private void GetNextSmtpServer()
        {
            bool isFindNewServer = false;
            foreach (var server in Configuration.Servers)
            {
                if (server.LetterLimit > 0)
                {
                    isFindNewServer = true;
                    CurreentServer = server;
                }
            }

            if (!isFindNewServer)
            {
                MessageBox.Show(@"Cannot found any free servers for today!\r\nMessage not send!!", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void AddNewItemToEmailListView(string email)
        {
            var item = new ListViewItem();
            item.Text = email;
            lvEmails.Items.Add(item);
        }

        private void BrowseExcelFileToLoad()
        {
            var opf = new OpenFileDialog();
            opf.Filter = @"Excel filex (.xlsx)| *.xlsx";
            opf.Multiselect = false;
            if (opf.ShowDialog() == DialogResult.OK)
            {
                LoadEmailsToForm(opf.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.ShowNotImplementedMessageBox();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.ShowNotImplementedMessageBox();
        }

        private void fromXlsxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowseExcelFileToLoad();
        }

        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.ShowNotImplementedMessageBox();
        }

        private void receiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.ShowNotImplementedMessageBox();
        }

        private void sendToMarkedEmailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.ShowNotImplementedMessageBox();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm sf = new SettingForm();
            if (sf.ShowDialog() == DialogResult.OK)
            {
                Configuration = sf.Configuration;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sendToAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem email in lvEmails.Items)
            {
                SendMailTo(email.Text);
            }
        }


        private void CoreForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemConfiguration.SaveConfiguration(Configuration);
        }
    }
}
