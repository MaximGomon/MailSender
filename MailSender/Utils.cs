using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailSender
{
    public static class Utils
    {
        public static void ShowNotImplementedMessageBox()
        {
            MessageBox.Show(@"This function don worked now. Wait new version ;-)", @"Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
