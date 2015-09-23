namespace Flyman.MailSender
{
    partial class CoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoreForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromXlsxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToMarkedEmailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.spMain = new System.Windows.Forms.SplitContainer();
            this.lvEmails = new System.Windows.Forms.ListView();
            this.emailColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rtmEmailText = new System.Windows.Forms.RichTextBox();
            this.sendToAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spMain)).BeginInit();
            this.spMain.Panel1.SuspendLayout();
            this.spMain.Panel2.SuspendLayout();
            this.spMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.importToolStripMenuItem,
            this.emailToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromXlsxToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // fromXlsxToolStripMenuItem
            // 
            this.fromXlsxToolStripMenuItem.Name = "fromXlsxToolStripMenuItem";
            this.fromXlsxToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.fromXlsxToolStripMenuItem.Text = "From xlsx";
            this.fromXlsxToolStripMenuItem.Click += new System.EventHandler(this.fromXlsxToolStripMenuItem_Click);
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendToAllToolStripMenuItem,
            this.sendToolStripMenuItem,
            this.receiveToolStripMenuItem,
            this.sendToMarkedEmailsToolStripMenuItem});
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.emailToolStripMenuItem.Text = "Email";
            // 
            // sendToolStripMenuItem
            // 
            this.sendToolStripMenuItem.Name = "sendToolStripMenuItem";
            this.sendToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.sendToolStripMenuItem.Text = "Send";
            this.sendToolStripMenuItem.Click += new System.EventHandler(this.sendToolStripMenuItem_Click);
            // 
            // receiveToolStripMenuItem
            // 
            this.receiveToolStripMenuItem.Name = "receiveToolStripMenuItem";
            this.receiveToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.receiveToolStripMenuItem.Text = "Receive";
            this.receiveToolStripMenuItem.Click += new System.EventHandler(this.receiveToolStripMenuItem_Click);
            // 
            // sendToMarkedEmailsToolStripMenuItem
            // 
            this.sendToMarkedEmailsToolStripMenuItem.Name = "sendToMarkedEmailsToolStripMenuItem";
            this.sendToMarkedEmailsToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.sendToMarkedEmailsToolStripMenuItem.Text = "Send to marked e-mails ";
            this.sendToMarkedEmailsToolStripMenuItem.Click += new System.EventHandler(this.sendToMarkedEmailsToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 535);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(942, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(258, 20);
            this.toolStripStatusLabel1.Text = "Some status will be placed there later";
            // 
            // spMain
            // 
            this.spMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spMain.Location = new System.Drawing.Point(0, 28);
            this.spMain.Name = "spMain";
            // 
            // spMain.Panel1
            // 
            this.spMain.Panel1.Controls.Add(this.lvEmails);
            // 
            // spMain.Panel2
            // 
            this.spMain.Panel2.Controls.Add(this.rtmEmailText);
            this.spMain.Size = new System.Drawing.Size(942, 507);
            this.spMain.SplitterDistance = 314;
            this.spMain.TabIndex = 2;
            // 
            // lvEmails
            // 
            this.lvEmails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.emailColumn});
            this.lvEmails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEmails.FullRowSelect = true;
            this.lvEmails.GridLines = true;
            this.lvEmails.Location = new System.Drawing.Point(0, 0);
            this.lvEmails.Name = "lvEmails";
            this.lvEmails.Size = new System.Drawing.Size(314, 507);
            this.lvEmails.TabIndex = 0;
            this.lvEmails.UseCompatibleStateImageBehavior = false;
            this.lvEmails.View = System.Windows.Forms.View.Details;
            // 
            // emailColumn
            // 
            this.emailColumn.Text = "Email";
            this.emailColumn.Width = 308;
            // 
            // rtmEmailText
            // 
            this.rtmEmailText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtmEmailText.Location = new System.Drawing.Point(0, 0);
            this.rtmEmailText.Name = "rtmEmailText";
            this.rtmEmailText.Size = new System.Drawing.Size(624, 507);
            this.rtmEmailText.TabIndex = 0;
            this.rtmEmailText.Text = "";
            // 
            // sendToAllToolStripMenuItem
            // 
            this.sendToAllToolStripMenuItem.Name = "sendToAllToolStripMenuItem";
            this.sendToAllToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.sendToAllToolStripMenuItem.Text = "Send to all";
            this.sendToAllToolStripMenuItem.Click += new System.EventHandler(this.sendToAllToolStripMenuItem_Click);
            // 
            // CoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 560);
            this.Controls.Add(this.spMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CoreForm";
            this.Text = "Mail Sender";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.spMain.Panel1.ResumeLayout(false);
            this.spMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spMain)).EndInit();
            this.spMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromXlsxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SplitContainer spMain;
        private System.Windows.Forms.ListView lvEmails;
        private System.Windows.Forms.ColumnHeader emailColumn;
        private System.Windows.Forms.RichTextBox rtmEmailText;
        private System.Windows.Forms.ToolStripMenuItem receiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToMarkedEmailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToAllToolStripMenuItem;
    }
}

