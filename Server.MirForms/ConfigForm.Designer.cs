﻿namespace Server
{
    partial class ConfigForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.configTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DBVersionLabel = new System.Windows.Forms.Label();
            this.ServerVersionLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RelogDelayTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.VersionCheckBox = new System.Windows.Forms.CheckBox();
            this.VPathBrowseButton = new System.Windows.Forms.Button();
            this.VPathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.StartHTTPCheckBox = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.HTTPTrustedIPAddressTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.HTTPIPAddressTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.MaxUserTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TimeOutTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IPAddressTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Resolution_textbox = new System.Windows.Forms.TextBox();
            this.AllowArcherCheckBox = new System.Windows.Forms.CheckBox();
            this.AllowAssassinCheckBox = new System.Windows.Forms.CheckBox();
            this.StartGameCheckBox = new System.Windows.Forms.CheckBox();
            this.DCharacterCheckBox = new System.Windows.Forms.CheckBox();
            this.NCharacterCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginCheckBox = new System.Windows.Forms.CheckBox();
            this.PasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.AccountCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.SaveDelayTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.gameMasterEffect_CheckBox = new System.Windows.Forms.CheckBox();
            this.SafeZoneHealingCheckBox = new System.Windows.Forms.CheckBox();
            this.SafeZoneBorderCheckBox = new System.Windows.Forms.CheckBox();
            this.VPathDialog = new System.Windows.Forms.OpenFileDialog();
            this.configTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(411, 450);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(87, 30);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "保存并关闭";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // configTabs
            // 
            this.configTabs.Controls.Add(this.tabPage1);
            this.configTabs.Controls.Add(this.tabPage2);
            this.configTabs.Controls.Add(this.tabPage3);
            this.configTabs.Controls.Add(this.tabPage4);
            this.configTabs.Controls.Add(this.tabPage5);
            this.configTabs.Location = new System.Drawing.Point(14, 16);
            this.configTabs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.configTabs.Name = "configTabs";
            this.configTabs.SelectedIndex = 0;
            this.configTabs.Size = new System.Drawing.Size(484, 426);
            this.configTabs.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.RelogDelayTextBox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.VersionCheckBox);
            this.tabPage1.Controls.Add(this.VPathBrowseButton);
            this.tabPage1.Controls.Add(this.VPathTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(476, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "版本";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.DBVersionLabel);
            this.groupBox1.Controls.Add(this.ServerVersionLabel);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(7, 300);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(461, 84);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "版本信息";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Database";
            // 
            // DBVersionLabel
            // 
            this.DBVersionLabel.AutoSize = true;
            this.DBVersionLabel.Location = new System.Drawing.Point(89, 55);
            this.DBVersionLabel.Name = "DBVersionLabel";
            this.DBVersionLabel.Size = new System.Drawing.Size(52, 17);
            this.DBVersionLabel.TabIndex = 24;
            this.DBVersionLabel.Text = "Version";
            // 
            // ServerVersionLabel
            // 
            this.ServerVersionLabel.AutoSize = true;
            this.ServerVersionLabel.Location = new System.Drawing.Point(89, 25);
            this.ServerVersionLabel.Name = "ServerVersionLabel";
            this.ServerVersionLabel.Size = new System.Drawing.Size(52, 17);
            this.ServerVersionLabel.TabIndex = 7;
            this.ServerVersionLabel.Text = "Version";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Server";
            // 
            // RelogDelayTextBox
            // 
            this.RelogDelayTextBox.Location = new System.Drawing.Point(104, 85);
            this.RelogDelayTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RelogDelayTextBox.MaxLength = 5;
            this.RelogDelayTextBox.Name = "RelogDelayTextBox";
            this.RelogDelayTextBox.Size = new System.Drawing.Size(108, 23);
            this.RelogDelayTextBox.TabIndex = 21;
            this.RelogDelayTextBox.TextChanged += new System.EventHandler(this.CheckUShort);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "重登录延迟:";
            // 
            // VersionCheckBox
            // 
            this.VersionCheckBox.AutoSize = true;
            this.VersionCheckBox.Location = new System.Drawing.Point(104, 55);
            this.VersionCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VersionCheckBox.Name = "VersionCheckBox";
            this.VersionCheckBox.Size = new System.Drawing.Size(111, 21);
            this.VersionCheckBox.TabIndex = 3;
            this.VersionCheckBox.Text = "检测客户端版本";
            this.VersionCheckBox.UseVisualStyleBackColor = true;
            // 
            // VPathBrowseButton
            // 
            this.VPathBrowseButton.Location = new System.Drawing.Point(435, 18);
            this.VPathBrowseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VPathBrowseButton.Name = "VPathBrowseButton";
            this.VPathBrowseButton.Size = new System.Drawing.Size(33, 30);
            this.VPathBrowseButton.TabIndex = 2;
            this.VPathBrowseButton.Text = "...";
            this.VPathBrowseButton.UseVisualStyleBackColor = true;
            this.VPathBrowseButton.Click += new System.EventHandler(this.VPathBrowseButton_Click);
            // 
            // VPathTextBox
            // 
            this.VPathTextBox.Location = new System.Drawing.Point(104, 21);
            this.VPathTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VPathTextBox.Name = "VPathTextBox";
            this.VPathTextBox.ReadOnly = true;
            this.VPathTextBox.Size = new System.Drawing.Size(324, 23);
            this.VPathTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "版本路径:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.StartHTTPCheckBox);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.HTTPTrustedIPAddressTextBox);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.HTTPIPAddressTextBox);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.MaxUserTextBox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.TimeOutTextBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.PortTextBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.IPAddressTextBox);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(476, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "网络";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // StartHTTPCheckBox
            // 
            this.StartHTTPCheckBox.AutoSize = true;
            this.StartHTTPCheckBox.Location = new System.Drawing.Point(28, 204);
            this.StartHTTPCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartHTTPCheckBox.Name = "StartHTTPCheckBox";
            this.StartHTTPCheckBox.Size = new System.Drawing.Size(105, 21);
            this.StartHTTPCheckBox.TabIndex = 23;
            this.StartHTTPCheckBox.Text = "开启HTTP服务";
            this.StartHTTPCheckBox.UseVisualStyleBackColor = true;
            this.StartHTTPCheckBox.CheckedChanged += new System.EventHandler(this.StartHTTPCheckBox_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 323);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(182, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "(http服务只允许受信任的IP访问)";
            // 
            // HTTPTrustedIPAddressTextBox
            // 
            this.HTTPTrustedIPAddressTextBox.Location = new System.Drawing.Point(150, 279);
            this.HTTPTrustedIPAddressTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HTTPTrustedIPAddressTextBox.MaxLength = 30;
            this.HTTPTrustedIPAddressTextBox.Name = "HTTPTrustedIPAddressTextBox";
            this.HTTPTrustedIPAddressTextBox.Size = new System.Drawing.Size(198, 23);
            this.HTTPTrustedIPAddressTextBox.TabIndex = 21;
            this.HTTPTrustedIPAddressTextBox.TextChanged += new System.EventHandler(this.HTTPTrustedIPAddressTextBox_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 285);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "HTTP 信任IP地址:";
            // 
            // HTTPIPAddressTextBox
            // 
            this.HTTPIPAddressTextBox.Location = new System.Drawing.Point(150, 239);
            this.HTTPIPAddressTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HTTPIPAddressTextBox.MaxLength = 30;
            this.HTTPIPAddressTextBox.Name = "HTTPIPAddressTextBox";
            this.HTTPIPAddressTextBox.Size = new System.Drawing.Size(198, 23);
            this.HTTPIPAddressTextBox.TabIndex = 19;
            this.HTTPIPAddressTextBox.TextChanged += new System.EventHandler(this.HTTPIPAddressTextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(46, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "HTTP IP 地址:";
            // 
            // MaxUserTextBox
            // 
            this.MaxUserTextBox.Location = new System.Drawing.Point(104, 123);
            this.MaxUserTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaxUserTextBox.MaxLength = 5;
            this.MaxUserTextBox.Name = "MaxUserTextBox";
            this.MaxUserTextBox.Size = new System.Drawing.Size(48, 23);
            this.MaxUserTextBox.TabIndex = 17;
            this.MaxUserTextBox.TextChanged += new System.EventHandler(this.CheckUShort);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "最大用户:";
            // 
            // TimeOutTextBox
            // 
            this.TimeOutTextBox.Location = new System.Drawing.Point(104, 89);
            this.TimeOutTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TimeOutTextBox.MaxLength = 5;
            this.TimeOutTextBox.Name = "TimeOutTextBox";
            this.TimeOutTextBox.Size = new System.Drawing.Size(108, 23);
            this.TimeOutTextBox.TabIndex = 15;
            this.TimeOutTextBox.TextChanged += new System.EventHandler(this.CheckUShort);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "超时:";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(104, 55);
            this.PortTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PortTextBox.MaxLength = 5;
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(48, 23);
            this.PortTextBox.TabIndex = 13;
            this.PortTextBox.TextChanged += new System.EventHandler(this.CheckUShort);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "端口:";
            // 
            // IPAddressTextBox
            // 
            this.IPAddressTextBox.Location = new System.Drawing.Point(104, 21);
            this.IPAddressTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IPAddressTextBox.MaxLength = 15;
            this.IPAddressTextBox.Name = "IPAddressTextBox";
            this.IPAddressTextBox.Size = new System.Drawing.Size(108, 23);
            this.IPAddressTextBox.TabIndex = 11;
            this.IPAddressTextBox.TextChanged += new System.EventHandler(this.IPAddressCheck);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "IP地址:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.Resolution_textbox);
            this.tabPage3.Controls.Add(this.AllowArcherCheckBox);
            this.tabPage3.Controls.Add(this.AllowAssassinCheckBox);
            this.tabPage3.Controls.Add(this.StartGameCheckBox);
            this.tabPage3.Controls.Add(this.DCharacterCheckBox);
            this.tabPage3.Controls.Add(this.NCharacterCheckBox);
            this.tabPage3.Controls.Add(this.LoginCheckBox);
            this.tabPage3.Controls.Add(this.PasswordCheckBox);
            this.tabPage3.Controls.Add(this.AccountCheckBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(476, 396);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "权限";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "最大分辨率";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "label8";
            // 
            // Resolution_textbox
            // 
            this.Resolution_textbox.Location = new System.Drawing.Point(98, 302);
            this.Resolution_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Resolution_textbox.Name = "Resolution_textbox";
            this.Resolution_textbox.Size = new System.Drawing.Size(93, 23);
            this.Resolution_textbox.TabIndex = 14;
            this.Resolution_textbox.TextChanged += new System.EventHandler(this.Resolution_textbox_TextChanged);
            // 
            // AllowArcherCheckBox
            // 
            this.AllowArcherCheckBox.AutoSize = true;
            this.AllowArcherCheckBox.Location = new System.Drawing.Point(28, 258);
            this.AllowArcherCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AllowArcherCheckBox.Name = "AllowArcherCheckBox";
            this.AllowArcherCheckBox.Size = new System.Drawing.Size(99, 21);
            this.AllowArcherCheckBox.TabIndex = 13;
            this.AllowArcherCheckBox.Text = "允许建立射手";
            this.AllowArcherCheckBox.UseVisualStyleBackColor = true;
            // 
            // AllowAssassinCheckBox
            // 
            this.AllowAssassinCheckBox.AutoSize = true;
            this.AllowAssassinCheckBox.Location = new System.Drawing.Point(28, 227);
            this.AllowAssassinCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AllowAssassinCheckBox.Name = "AllowAssassinCheckBox";
            this.AllowAssassinCheckBox.Size = new System.Drawing.Size(99, 21);
            this.AllowAssassinCheckBox.TabIndex = 12;
            this.AllowAssassinCheckBox.Text = "允许建立刺客";
            this.AllowAssassinCheckBox.UseVisualStyleBackColor = true;
            // 
            // StartGameCheckBox
            // 
            this.StartGameCheckBox.AutoSize = true;
            this.StartGameCheckBox.Location = new System.Drawing.Point(28, 177);
            this.StartGameCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartGameCheckBox.Name = "StartGameCheckBox";
            this.StartGameCheckBox.Size = new System.Drawing.Size(99, 21);
            this.StartGameCheckBox.TabIndex = 11;
            this.StartGameCheckBox.Text = "允许开始游戏";
            this.StartGameCheckBox.UseVisualStyleBackColor = true;
            // 
            // DCharacterCheckBox
            // 
            this.DCharacterCheckBox.AutoSize = true;
            this.DCharacterCheckBox.Location = new System.Drawing.Point(28, 146);
            this.DCharacterCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DCharacterCheckBox.Name = "DCharacterCheckBox";
            this.DCharacterCheckBox.Size = new System.Drawing.Size(99, 21);
            this.DCharacterCheckBox.TabIndex = 10;
            this.DCharacterCheckBox.Text = "允许删除人物";
            this.DCharacterCheckBox.UseVisualStyleBackColor = true;
            // 
            // NCharacterCheckBox
            // 
            this.NCharacterCheckBox.AutoSize = true;
            this.NCharacterCheckBox.Location = new System.Drawing.Point(28, 116);
            this.NCharacterCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NCharacterCheckBox.Name = "NCharacterCheckBox";
            this.NCharacterCheckBox.Size = new System.Drawing.Size(99, 21);
            this.NCharacterCheckBox.TabIndex = 9;
            this.NCharacterCheckBox.Text = "允许新建人物";
            this.NCharacterCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoginCheckBox
            // 
            this.LoginCheckBox.AutoSize = true;
            this.LoginCheckBox.Location = new System.Drawing.Point(28, 86);
            this.LoginCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginCheckBox.Name = "LoginCheckBox";
            this.LoginCheckBox.Size = new System.Drawing.Size(99, 21);
            this.LoginCheckBox.TabIndex = 8;
            this.LoginCheckBox.Text = "允许账户登录";
            this.LoginCheckBox.UseVisualStyleBackColor = true;
            // 
            // PasswordCheckBox
            // 
            this.PasswordCheckBox.AutoSize = true;
            this.PasswordCheckBox.Location = new System.Drawing.Point(28, 57);
            this.PasswordCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordCheckBox.Name = "PasswordCheckBox";
            this.PasswordCheckBox.Size = new System.Drawing.Size(123, 21);
            this.PasswordCheckBox.TabIndex = 7;
            this.PasswordCheckBox.Text = "允许用户更改密码";
            this.PasswordCheckBox.UseVisualStyleBackColor = true;
            // 
            // AccountCheckBox
            // 
            this.AccountCheckBox.AutoSize = true;
            this.AccountCheckBox.Location = new System.Drawing.Point(28, 25);
            this.AccountCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AccountCheckBox.Name = "AccountCheckBox";
            this.AccountCheckBox.Size = new System.Drawing.Size(99, 21);
            this.AccountCheckBox.TabIndex = 6;
            this.AccountCheckBox.Text = "允许创建账户";
            this.AccountCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.SaveDelayTextBox);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Size = new System.Drawing.Size(476, 396);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "数据库";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(200, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "分";
            // 
            // SaveDelayTextBox
            // 
            this.SaveDelayTextBox.Location = new System.Drawing.Point(86, 22);
            this.SaveDelayTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveDelayTextBox.MaxLength = 5;
            this.SaveDelayTextBox.Name = "SaveDelayTextBox";
            this.SaveDelayTextBox.Size = new System.Drawing.Size(108, 23);
            this.SaveDelayTextBox.TabIndex = 25;
            this.SaveDelayTextBox.TextChanged += new System.EventHandler(this.CheckUShort);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "保存延迟:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.gameMasterEffect_CheckBox);
            this.tabPage5.Controls.Add(this.SafeZoneHealingCheckBox);
            this.tabPage5.Controls.Add(this.SafeZoneBorderCheckBox);
            this.tabPage5.Location = new System.Drawing.Point(4, 26);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage5.Size = new System.Drawing.Size(476, 396);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "可选";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // gameMasterEffect_CheckBox
            // 
            this.gameMasterEffect_CheckBox.AutoSize = true;
            this.gameMasterEffect_CheckBox.Location = new System.Drawing.Point(28, 86);
            this.gameMasterEffect_CheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gameMasterEffect_CheckBox.Name = "gameMasterEffect_CheckBox";
            this.gameMasterEffect_CheckBox.Size = new System.Drawing.Size(72, 21);
            this.gameMasterEffect_CheckBox.TabIndex = 2;
            this.gameMasterEffect_CheckBox.Text = "GM特效";
            this.gameMasterEffect_CheckBox.UseVisualStyleBackColor = true;
            // 
            // SafeZoneHealingCheckBox
            // 
            this.SafeZoneHealingCheckBox.AutoSize = true;
            this.SafeZoneHealingCheckBox.Location = new System.Drawing.Point(28, 57);
            this.SafeZoneHealingCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SafeZoneHealingCheckBox.Name = "SafeZoneHealingCheckBox";
            this.SafeZoneHealingCheckBox.Size = new System.Drawing.Size(135, 21);
            this.SafeZoneHealingCheckBox.TabIndex = 1;
            this.SafeZoneHealingCheckBox.Text = "开启安全区自动治愈";
            this.SafeZoneHealingCheckBox.UseVisualStyleBackColor = true;
            this.SafeZoneHealingCheckBox.CheckedChanged += new System.EventHandler(this.SafeZoneHealingCheckBox_CheckedChanged);
            // 
            // SafeZoneBorderCheckBox
            // 
            this.SafeZoneBorderCheckBox.AutoSize = true;
            this.SafeZoneBorderCheckBox.Location = new System.Drawing.Point(28, 25);
            this.SafeZoneBorderCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SafeZoneBorderCheckBox.Name = "SafeZoneBorderCheckBox";
            this.SafeZoneBorderCheckBox.Size = new System.Drawing.Size(111, 21);
            this.SafeZoneBorderCheckBox.TabIndex = 0;
            this.SafeZoneBorderCheckBox.Text = "显示安全区边界";
            this.SafeZoneBorderCheckBox.UseVisualStyleBackColor = true;
            this.SafeZoneBorderCheckBox.CheckedChanged += new System.EventHandler(this.SafeZoneBorderCheckBox_CheckedChanged);
            // 
            // VPathDialog
            // 
            this.VPathDialog.FileName = "Mir2.Exe";
            this.VPathDialog.Filter = "Executable Files (*.exe)|*.exe";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 487);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.configTabs);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ConfigForm";
            this.Text = "服务器设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfigForm_FormClosed);
            this.configTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TabControl configTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox RelogDelayTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox VersionCheckBox;
        private System.Windows.Forms.Button VPathBrowseButton;
        private System.Windows.Forms.TextBox VPathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox MaxUserTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TimeOutTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IPAddressTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog VPathDialog;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox StartGameCheckBox;
        private System.Windows.Forms.CheckBox DCharacterCheckBox;
        private System.Windows.Forms.CheckBox NCharacterCheckBox;
        private System.Windows.Forms.CheckBox LoginCheckBox;
        private System.Windows.Forms.CheckBox PasswordCheckBox;
        private System.Windows.Forms.CheckBox AccountCheckBox;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox SaveDelayTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox SafeZoneBorderCheckBox;
        private System.Windows.Forms.CheckBox SafeZoneHealingCheckBox;
        private System.Windows.Forms.CheckBox AllowArcherCheckBox;
        private System.Windows.Forms.CheckBox AllowAssassinCheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Resolution_textbox;
        private System.Windows.Forms.Label ServerVersionLabel;
        private System.Windows.Forms.Label DBVersionLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox gameMasterEffect_CheckBox;
        private System.Windows.Forms.TextBox HTTPIPAddressTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox HTTPTrustedIPAddressTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox StartHTTPCheckBox;
    }
}