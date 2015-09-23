namespace MailSender
{
    partial class SmtpForm
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
            this.components = new System.ComponentModel.Container();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSmptServer = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbLimit = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbSleepTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(178, 153);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(260, 153);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "SMTP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Letter limit";
            // 
            // tbSmptServer
            // 
            this.tbSmptServer.Location = new System.Drawing.Point(113, 23);
            this.tbSmptServer.Name = "tbSmptServer";
            this.tbSmptServer.Size = new System.Drawing.Size(385, 22);
            this.tbSmptServer.TabIndex = 7;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(113, 52);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(56, 22);
            this.tbPort.TabIndex = 8;
            // 
            // tbLimit
            // 
            this.tbLimit.Location = new System.Drawing.Point(279, 52);
            this.tbLimit.Name = "tbLimit";
            this.tbLimit.Size = new System.Drawing.Size(56, 22);
            this.tbLimit.TabIndex = 9;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(113, 85);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(385, 22);
            this.tbLogin.TabIndex = 10;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(113, 119);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(385, 22);
            this.tbPassword.TabIndex = 11;
            // 
            // tbSleepTime
            // 
            this.tbSleepTime.Location = new System.Drawing.Point(442, 52);
            this.tbSleepTime.Name = "tbSleepTime";
            this.tbSleepTime.Size = new System.Drawing.Size(56, 22);
            this.tbSleepTime.TabIndex = 13;
            this.toolTip1.SetToolTip(this.tbSleepTime, "Time in second beetwen send letters");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sleep time";
            // 
            // SmtpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 188);
            this.ControlBox = false;
            this.Controls.Add(this.tbSleepTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbLimit);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbSmptServer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Name = "SmtpForm";
            this.ShowInTaskbar = false;
            this.Text = "Smtp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSmptServer;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbLimit;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbSleepTime;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
    }
}