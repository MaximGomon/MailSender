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
    public partial class SettingForm : Form
    {
        public SystemConfiguration Configuration { get; set; }
        public SettingForm()
        {
            InitializeComponent();
            lvSmtpList.Items.Clear();
            FillSmtpList();
        }
        private void FillSmtpList()
        {
            foreach (var item in Configuration.Servers)
            {
                AddItemToListView(item);
            }
        }

        private void AddItemToListView(SmtpInfo item)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = item.Server;
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem
            {
                Text = item.Port.ToString()
            });
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem
            {
                Text = item.Login
            });
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem
            {
                Text = item.LetterLimit.ToString()
            });
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem
            {
                Text = item.SleepTime.ToString()
            });
            lvSmtpList.Items.Add(lvi);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            SmtpForm sm = new SmtpForm();
            if (sm.ShowDialog() == DialogResult.OK)
            {
                AddItemToListView(sm.Info);
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            Utils.ShowNotImplementedMessageBox();
        }
    }
}
