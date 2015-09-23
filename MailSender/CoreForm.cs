﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        public void ShowNotImplementedMessageBox()
        {
            MessageBox.Show(@"This function don worked now. Wait new version ;-)", @"Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNotImplementedMessageBox();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNotImplementedMessageBox();
        }

        private void fromXlsxToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNotImplementedMessageBox();
        }

        private void receiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNotImplementedMessageBox();
        }

        private void sendToMarkedEmailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNotImplementedMessageBox();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm sf = new SettingForm();
            if (sf.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sendToAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}