namespace shadownaive
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.naiveGroupBox = new System.Windows.Forms.GroupBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.domainLabel = new System.Windows.Forms.Label();
            this.accountText = new System.Windows.Forms.TextBox();
            this.accountLabel = new System.Windows.Forms.Label();
            this.domainText = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.socketGroupBox = new System.Windows.Forms.GroupBox();
            this.portText = new System.Windows.Forms.TextBox();
            this.addressAllRadio = new System.Windows.Forms.RadioButton();
            this.addressLocalRadio = new System.Windows.Forms.RadioButton();
            this.portLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.proxyOn = new System.Windows.Forms.Button();
            this.proxyOff = new System.Windows.Forms.Button();
            this.naiveStatusLabel = new System.Windows.Forms.Label();
            this.nginxStatusLabel = new System.Windows.Forms.Label();
            this.naiveStatus = new System.Windows.Forms.Label();
            this.nginxStatus = new System.Windows.Forms.Label();
            this.naiveGroupBox.SuspendLayout();
            this.socketGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 999;
            this.Timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "Naive";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.Click += new System.EventHandler(this.NotifyIconClick);
            // 
            // TrayMenu
            // 
            this.TrayMenu.Name = "TrayMenu";
            this.TrayMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // naiveGroupBox
            // 
            this.naiveGroupBox.Controls.Add(this.passwordText);
            this.naiveGroupBox.Controls.Add(this.domainLabel);
            this.naiveGroupBox.Controls.Add(this.accountText);
            this.naiveGroupBox.Controls.Add(this.accountLabel);
            this.naiveGroupBox.Controls.Add(this.domainText);
            this.naiveGroupBox.Controls.Add(this.passwordLabel);
            this.naiveGroupBox.Location = new System.Drawing.Point(12, 12);
            this.naiveGroupBox.Name = "naiveGroupBox";
            this.naiveGroupBox.Size = new System.Drawing.Size(224, 106);
            this.naiveGroupBox.TabIndex = 1;
            this.naiveGroupBox.TabStop = false;
            this.naiveGroupBox.Text = "NAIVE:";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(67, 73);
            this.passwordText.MaxLength = 32;
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(145, 21);
            this.passwordText.TabIndex = 3;
            // 
            // domainLabel
            // 
            this.domainLabel.AutoSize = true;
            this.domainLabel.Location = new System.Drawing.Point(18, 23);
            this.domainLabel.Name = "domainLabel";
            this.domainLabel.Size = new System.Drawing.Size(47, 12);
            this.domainLabel.TabIndex = 9;
            this.domainLabel.Text = "DOMAIN:";
            // 
            // accountText
            // 
            this.accountText.Location = new System.Drawing.Point(67, 46);
            this.accountText.MaxLength = 32;
            this.accountText.Name = "accountText";
            this.accountText.Size = new System.Drawing.Size(145, 21);
            this.accountText.TabIndex = 2;
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(12, 50);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(53, 12);
            this.accountLabel.TabIndex = 10;
            this.accountLabel.Text = "ACCOUNT:";
            // 
            // domainText
            // 
            this.domainText.Location = new System.Drawing.Point(67, 19);
            this.domainText.MaxLength = 255;
            this.domainText.Name = "domainText";
            this.domainText.Size = new System.Drawing.Size(145, 21);
            this.domainText.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(6, 77);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(59, 12);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "PASSWORD:";
            // 
            // socketGroupBox
            // 
            this.socketGroupBox.Controls.Add(this.portText);
            this.socketGroupBox.Controls.Add(this.addressAllRadio);
            this.socketGroupBox.Controls.Add(this.addressLocalRadio);
            this.socketGroupBox.Controls.Add(this.portLabel);
            this.socketGroupBox.Location = new System.Drawing.Point(247, 12);
            this.socketGroupBox.Name = "socketGroupBox";
            this.socketGroupBox.Size = new System.Drawing.Size(97, 106);
            this.socketGroupBox.TabIndex = 2;
            this.socketGroupBox.TabStop = false;
            this.socketGroupBox.Text = "SOCKS:";
            // 
            // portText
            // 
            this.portText.Location = new System.Drawing.Point(46, 19);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(38, 21);
            this.portText.TabIndex = 4;
            this.portText.Text = "1080";
            // 
            // addressAllRadio
            // 
            this.addressAllRadio.AutoSize = true;
            this.addressAllRadio.Location = new System.Drawing.Point(10, 75);
            this.addressAllRadio.Name = "addressAllRadio";
            this.addressAllRadio.Size = new System.Drawing.Size(65, 16);
            this.addressAllRadio.TabIndex = 6;
            this.addressAllRadio.Text = "0.0.0.0";
            this.addressAllRadio.UseVisualStyleBackColor = true;
            // 
            // addressLocalRadio
            // 
            this.addressLocalRadio.AutoSize = true;
            this.addressLocalRadio.Checked = true;
            this.addressLocalRadio.Location = new System.Drawing.Point(10, 48);
            this.addressLocalRadio.Name = "addressLocalRadio";
            this.addressLocalRadio.Size = new System.Drawing.Size(77, 16);
            this.addressLocalRadio.TabIndex = 5;
            this.addressLocalRadio.TabStop = true;
            this.addressLocalRadio.Text = "127.0.0.1";
            this.addressLocalRadio.UseVisualStyleBackColor = true;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(10, 23);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(35, 12);
            this.portLabel.TabIndex = 15;
            this.portLabel.Text = "PORT:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(13, 129);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(44, 30);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(111, 128);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(44, 30);
            this.stopButton.TabIndex = 9;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButtonClick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(62, 128);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(44, 30);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // proxyOn
            // 
            this.proxyOn.Location = new System.Drawing.Point(160, 128);
            this.proxyOn.Name = "proxyOn";
            this.proxyOn.Size = new System.Drawing.Size(36, 30);
            this.proxyOn.TabIndex = 10;
            this.proxyOn.Text = "ON";
            this.proxyOn.UseVisualStyleBackColor = true;
            this.proxyOn.Click += new System.EventHandler(this.ProxyOnClick);
            // 
            // proxyOff
            // 
            this.proxyOff.Location = new System.Drawing.Point(201, 128);
            this.proxyOff.Name = "proxyOff";
            this.proxyOff.Size = new System.Drawing.Size(36, 30);
            this.proxyOff.TabIndex = 11;
            this.proxyOff.Text = "OFF";
            this.proxyOff.UseVisualStyleBackColor = true;
            this.proxyOff.Click += new System.EventHandler(this.ProxyOffClick);
            // 
            // naiveStatusLabel
            // 
            this.naiveStatusLabel.AutoSize = true;
            this.naiveStatusLabel.Location = new System.Drawing.Point(245, 128);
            this.naiveStatusLabel.Name = "naiveStatusLabel";
            this.naiveStatusLabel.Size = new System.Drawing.Size(41, 12);
            this.naiveStatusLabel.TabIndex = 8;
            this.naiveStatusLabel.Text = "NAIVE:";
            // 
            // nginxStatusLabel
            // 
            this.nginxStatusLabel.AutoSize = true;
            this.nginxStatusLabel.Location = new System.Drawing.Point(245, 146);
            this.nginxStatusLabel.Name = "nginxStatusLabel";
            this.nginxStatusLabel.Size = new System.Drawing.Size(41, 12);
            this.nginxStatusLabel.TabIndex = 9;
            this.nginxStatusLabel.Text = "NGINX:";
            // 
            // naiveStatus
            // 
            this.naiveStatus.AutoSize = true;
            this.naiveStatus.Location = new System.Drawing.Point(281, 128);
            this.naiveStatus.Name = "naiveStatus";
            this.naiveStatus.Size = new System.Drawing.Size(0, 12);
            this.naiveStatus.TabIndex = 10;
            // 
            // nginxStatus
            // 
            this.nginxStatus.AutoSize = true;
            this.nginxStatus.Location = new System.Drawing.Point(281, 146);
            this.nginxStatus.Name = "nginxStatus";
            this.nginxStatus.Size = new System.Drawing.Size(0, 12);
            this.nginxStatus.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 171);
            this.Controls.Add(this.nginxStatus);
            this.Controls.Add(this.naiveStatus);
            this.Controls.Add(this.nginxStatusLabel);
            this.Controls.Add(this.naiveStatusLabel);
            this.Controls.Add(this.proxyOff);
            this.Controls.Add(this.proxyOn);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.socketGroupBox);
            this.Controls.Add(this.naiveGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shadownaive";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormClosed);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.naiveGroupBox.ResumeLayout(false);
            this.naiveGroupBox.PerformLayout();
            this.socketGroupBox.ResumeLayout(false);
            this.socketGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip TrayMenu;
        private System.Windows.Forms.GroupBox naiveGroupBox;
        private System.Windows.Forms.GroupBox socketGroupBox;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label domainLabel;
        private System.Windows.Forms.TextBox accountText;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.TextBox domainText;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.RadioButton addressAllRadio;
        private System.Windows.Forms.RadioButton addressLocalRadio;
        private System.Windows.Forms.TextBox portText;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button proxyOn;
        private System.Windows.Forms.Button proxyOff;
        private System.Windows.Forms.Label naiveStatusLabel;
        private System.Windows.Forms.Label nginxStatusLabel;
        private System.Windows.Forms.Label naiveStatus;
        private System.Windows.Forms.Label nginxStatus;
    }
}

