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
            this.sendToAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.rtbEmailText = new System.Windows.Forms.RichTextBox();
            this.scMailCompose = new System.Windows.Forms.SplitContainer();
            this.scMailSubject = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMailSubject = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spMain)).BeginInit();
            this.spMain.Panel1.SuspendLayout();
            this.spMain.Panel2.SuspendLayout();
            this.spMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMailCompose)).BeginInit();
            this.scMailCompose.Panel1.SuspendLayout();
            this.scMailCompose.Panel2.SuspendLayout();
            this.scMailCompose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMailSubject)).BeginInit();
            this.scMailSubject.Panel1.SuspendLayout();
            this.scMailSubject.Panel2.SuspendLayout();
            this.scMailSubject.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromXlsxToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // fromXlsxToolStripMenuItem
            // 
            this.fromXlsxToolStripMenuItem.Name = "fromXlsxToolStripMenuItem";
            this.fromXlsxToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
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
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.emailToolStripMenuItem.Text = "Email";
            // 
            // sendToAllToolStripMenuItem
            // 
            this.sendToAllToolStripMenuItem.Name = "sendToAllToolStripMenuItem";
            this.sendToAllToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.sendToAllToolStripMenuItem.Text = "Send to all";
            this.sendToAllToolStripMenuItem.Click += new System.EventHandler(this.sendToAllToolStripMenuItem_Click);
            // 
            // sendToolStripMenuItem
            // 
            this.sendToolStripMenuItem.Name = "sendToolStripMenuItem";
            this.sendToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.sendToolStripMenuItem.Text = "Send";
            this.sendToolStripMenuItem.Click += new System.EventHandler(this.sendToolStripMenuItem_Click);
            // 
            // receiveToolStripMenuItem
            // 
            this.receiveToolStripMenuItem.Name = "receiveToolStripMenuItem";
            this.receiveToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.receiveToolStripMenuItem.Text = "Receive";
            this.receiveToolStripMenuItem.Click += new System.EventHandler(this.receiveToolStripMenuItem_Click);
            // 
            // sendToMarkedEmailsToolStripMenuItem
            // 
            this.sendToMarkedEmailsToolStripMenuItem.Name = "sendToMarkedEmailsToolStripMenuItem";
            this.sendToMarkedEmailsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.sendToMarkedEmailsToolStripMenuItem.Text = "Send to marked e-mails ";
            this.sendToMarkedEmailsToolStripMenuItem.Click += new System.EventHandler(this.sendToMarkedEmailsToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 433);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(706, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(202, 17);
            this.toolStripStatusLabel1.Text = "Some status will be placed there later";
            // 
            // spMain
            // 
            this.spMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spMain.Location = new System.Drawing.Point(0, 24);
            this.spMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.spMain.Name = "spMain";
            // 
            // spMain.Panel1
            // 
            this.spMain.Panel1.Controls.Add(this.lvEmails);
            // 
            // spMain.Panel2
            // 
            this.spMain.Panel2.Controls.Add(this.scMailCompose);
            this.spMain.Size = new System.Drawing.Size(706, 409);
            this.spMain.SplitterDistance = 235;
            this.spMain.SplitterWidth = 3;
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
            this.lvEmails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvEmails.Name = "lvEmails";
            this.lvEmails.Size = new System.Drawing.Size(235, 409);
            this.lvEmails.TabIndex = 0;
            this.lvEmails.UseCompatibleStateImageBehavior = false;
            this.lvEmails.View = System.Windows.Forms.View.Details;
            // 
            // emailColumn
            // 
            this.emailColumn.Text = "Email";
            this.emailColumn.Width = 308;
            // 
            // rtbEmailText
            // 
            this.rtbEmailText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbEmailText.Location = new System.Drawing.Point(0, 0);
            this.rtbEmailText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbEmailText.Name = "rtbEmailText";
            this.rtbEmailText.Size = new System.Drawing.Size(468, 380);
            this.rtbEmailText.TabIndex = 0;
            this.rtbEmailText.Text = "";
            // 
            // scMailCompose
            // 
            this.scMailCompose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMailCompose.Location = new System.Drawing.Point(0, 0);
            this.scMailCompose.Name = "scMailCompose";
            this.scMailCompose.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMailCompose.Panel1
            // 
            this.scMailCompose.Panel1.Controls.Add(this.scMailSubject);
            // 
            // scMailCompose.Panel2
            // 
            this.scMailCompose.Panel2.Controls.Add(this.rtbEmailText);
            this.scMailCompose.Size = new System.Drawing.Size(468, 409);
            this.scMailCompose.SplitterDistance = 25;
            this.scMailCompose.TabIndex = 1;
            // 
            // scMailSubject
            // 
            this.scMailSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMailSubject.Location = new System.Drawing.Point(0, 0);
            this.scMailSubject.Name = "scMailSubject";
            // 
            // scMailSubject.Panel1
            // 
            this.scMailSubject.Panel1.Controls.Add(this.label1);
            // 
            // scMailSubject.Panel2
            // 
            this.scMailSubject.Panel2.Controls.Add(this.tbMailSubject);
            this.scMailSubject.Size = new System.Drawing.Size(468, 25);
            this.scMailSubject.SplitterDistance = 48;
            this.scMailSubject.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject";
            // 
            // tbMailSubject
            // 
            this.tbMailSubject.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbMailSubject.Location = new System.Drawing.Point(0, 5);
            this.tbMailSubject.Name = "tbMailSubject";
            this.tbMailSubject.Size = new System.Drawing.Size(416, 20);
            this.tbMailSubject.TabIndex = 0;
            // 
            // CoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 455);
            this.Controls.Add(this.spMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CoreForm";
            this.Text = "Mail Sender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CoreForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.spMain.Panel1.ResumeLayout(false);
            this.spMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spMain)).EndInit();
            this.spMain.ResumeLayout(false);
            this.scMailCompose.Panel1.ResumeLayout(false);
            this.scMailCompose.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMailCompose)).EndInit();
            this.scMailCompose.ResumeLayout(false);
            this.scMailSubject.Panel1.ResumeLayout(false);
            this.scMailSubject.Panel1.PerformLayout();
            this.scMailSubject.Panel2.ResumeLayout(false);
            this.scMailSubject.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMailSubject)).EndInit();
            this.scMailSubject.ResumeLayout(false);
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
        private System.Windows.Forms.RichTextBox rtbEmailText;
        private System.Windows.Forms.ToolStripMenuItem receiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToMarkedEmailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToAllToolStripMenuItem;
        private System.Windows.Forms.SplitContainer scMailCompose;
        private System.Windows.Forms.SplitContainer scMailSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMailSubject;
    }
}

