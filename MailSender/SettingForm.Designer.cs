namespace MailSender
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpSmtp = new System.Windows.Forms.TabPage();
            this.scSmtpSetting = new System.Windows.Forms.SplitContainer();
            this.lvSmtpList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btRemove = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.scMainContainer = new System.Windows.Forms.SplitContainer();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tpSmtp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSmtpSetting)).BeginInit();
            this.scSmtpSetting.Panel1.SuspendLayout();
            this.scSmtpSetting.Panel2.SuspendLayout();
            this.scSmtpSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMainContainer)).BeginInit();
            this.scMainContainer.Panel1.SuspendLayout();
            this.scMainContainer.Panel2.SuspendLayout();
            this.scMainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpSmtp);
            this.tcMain.Controls.Add(this.tpGeneral);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(699, 345);
            this.tcMain.TabIndex = 0;
            // 
            // tpSmtp
            // 
            this.tpSmtp.Controls.Add(this.scSmtpSetting);
            this.tpSmtp.Location = new System.Drawing.Point(4, 22);
            this.tpSmtp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpSmtp.Name = "tpSmtp";
            this.tpSmtp.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpSmtp.Size = new System.Drawing.Size(691, 319);
            this.tpSmtp.TabIndex = 1;
            this.tpSmtp.Text = "SMTP";
            this.tpSmtp.UseVisualStyleBackColor = true;
            // 
            // scSmtpSetting
            // 
            this.scSmtpSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scSmtpSetting.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scSmtpSetting.IsSplitterFixed = true;
            this.scSmtpSetting.Location = new System.Drawing.Point(2, 2);
            this.scSmtpSetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scSmtpSetting.Name = "scSmtpSetting";
            // 
            // scSmtpSetting.Panel1
            // 
            this.scSmtpSetting.Panel1.Controls.Add(this.lvSmtpList);
            // 
            // scSmtpSetting.Panel2
            // 
            this.scSmtpSetting.Panel2.Controls.Add(this.btRemove);
            this.scSmtpSetting.Panel2.Controls.Add(this.btAdd);
            this.scSmtpSetting.Size = new System.Drawing.Size(687, 315);
            this.scSmtpSetting.SplitterDistance = 556;
            this.scSmtpSetting.SplitterWidth = 3;
            this.scSmtpSetting.TabIndex = 0;
            // 
            // lvSmtpList
            // 
            this.lvSmtpList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvSmtpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSmtpList.FullRowSelect = true;
            this.lvSmtpList.GridLines = true;
            this.lvSmtpList.Location = new System.Drawing.Point(0, 0);
            this.lvSmtpList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvSmtpList.MultiSelect = false;
            this.lvSmtpList.Name = "lvSmtpList";
            this.lvSmtpList.Size = new System.Drawing.Size(556, 315);
            this.lvSmtpList.TabIndex = 0;
            this.lvSmtpList.UseCompatibleStateImageBehavior = false;
            this.lvSmtpList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Server";
            this.columnHeader1.Width = 192;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Port";
            this.columnHeader2.Width = 44;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Login";
            this.columnHeader3.Width = 177;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Limit";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sleep time";
            this.columnHeader5.Width = 76;
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(9, 33);
            this.btRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(104, 19);
            this.btRemove.TabIndex = 1;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(9, 10);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(104, 19);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tpGeneral
            // 
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpGeneral.Size = new System.Drawing.Size(542, 319);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // scMainContainer
            // 
            this.scMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMainContainer.Location = new System.Drawing.Point(0, 0);
            this.scMainContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scMainContainer.Name = "scMainContainer";
            this.scMainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMainContainer.Panel1
            // 
            this.scMainContainer.Panel1.Controls.Add(this.tcMain);
            // 
            // scMainContainer.Panel2
            // 
            this.scMainContainer.Panel2.Controls.Add(this.btCancel);
            this.scMainContainer.Panel2.Controls.Add(this.btOk);
            this.scMainContainer.Size = new System.Drawing.Size(699, 380);
            this.scMainContainer.SplitterDistance = 345;
            this.scMainContainer.SplitterWidth = 3;
            this.scMainContainer.TabIndex = 1;
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(336, 6);
            this.btCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(104, 19);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(221, 6);
            this.btOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(104, 19);
            this.btOk.TabIndex = 1;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 380);
            this.Controls.Add(this.scMainContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.tcMain.ResumeLayout(false);
            this.tpSmtp.ResumeLayout(false);
            this.scSmtpSetting.Panel1.ResumeLayout(false);
            this.scSmtpSetting.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSmtpSetting)).EndInit();
            this.scSmtpSetting.ResumeLayout(false);
            this.scMainContainer.Panel1.ResumeLayout(false);
            this.scMainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMainContainer)).EndInit();
            this.scMainContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpSmtp;
        private System.Windows.Forms.SplitContainer scSmtpSetting;
        private System.Windows.Forms.ListView lvSmtpList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.SplitContainer scMainContainer;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
    }
}