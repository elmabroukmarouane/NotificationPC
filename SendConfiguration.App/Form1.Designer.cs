namespace SendConfiguration.App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox5 = new GroupBox();
            modifierEmailConfiguration = new Button();
            loadEmailConfigurationButton = new Button();
            label3 = new Label();
            smtpPassword = new TextBox();
            label2 = new Label();
            smtpUsername = new TextBox();
            tabPage2 = new TabPage();
            groupBox4 = new GroupBox();
            modifierSmsConfiguration = new Button();
            loadSmsConfigurationButton = new Button();
            twilioAuthToken = new TextBox();
            label4 = new Label();
            twilioAccountSid = new TextBox();
            label5 = new Label();
            tabPage3 = new TabPage();
            updateEMailMessageButton = new Button();
            loadEMailMessageButton = new Button();
            groupBox3 = new GroupBox();
            emailMessage = new TextBox();
            label10 = new Label();
            emailSubject = new TextBox();
            label11 = new Label();
            groupBox2 = new GroupBox();
            toAddressAddress = new TextBox();
            label8 = new Label();
            toAddressName = new TextBox();
            label9 = new Label();
            groupBox1 = new GroupBox();
            fromAddressAddress = new TextBox();
            label6 = new Label();
            fromAddressName = new TextBox();
            label7 = new Label();
            tabPage4 = new TabPage();
            updateSmsMessageButton = new Button();
            loadSmsMessageButton = new Button();
            groupBox6 = new GroupBox();
            smsMessage = new TextBox();
            label14 = new Label();
            toNumberPhone = new TextBox();
            label13 = new Label();
            fromNumberPhone = new TextBox();
            label12 = new Label();
            tabPage5 = new TabPage();
            groupBox7 = new GroupBox();
            loadNotificationChannelButton = new Button();
            updateNotificationChannelButton = new Button();
            mailSmsChannelRadio = new RadioButton();
            smsChannelRadio = new RadioButton();
            mailChannelRadio = new RadioButton();
            tabPage6 = new TabPage();
            groupBox8 = new GroupBox();
            loadSmsLockedButton = new Button();
            updateSmsLockedButton = new Button();
            smsLockedNo = new RadioButton();
            smsLockedYes = new RadioButton();
            tabPage7 = new TabPage();
            groupBox10 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label16 = new Label();
            label15 = new Label();
            groupBox9 = new GroupBox();
            loadApplicationIsEnableButton = new Button();
            updateApplicationIsEnableButton = new Button();
            applicationIsEnableNoRadio = new RadioButton();
            applicationIsEnableYesRadio = new RadioButton();
            tabPage8 = new TabPage();
            rightToLeft = new Button();
            leftToRight = new Button();
            label17 = new Label();
            loadJsonConfiguration = new OpenFileDialog();
            loadTxtConfiguration = new OpenFileDialog();
            toolTipApplication = new ToolTip(components);
            timerMarquee = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox5.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage4.SuspendLayout();
            groupBox6.SuspendLayout();
            tabPage5.SuspendLayout();
            groupBox7.SuspendLayout();
            tabPage6.SuspendLayout();
            groupBox8.SuspendLayout();
            tabPage7.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox9.SuspendLayout();
            tabPage8.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(387, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(593, 86);
            label1.TabIndex = 0;
            label1.Text = "Send Configurator";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Controls.Add(tabPage8);
            tabControl1.Location = new Point(36, 121);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1272, 574);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox5);
            tabPage1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(1264, 546);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Email Configuration";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(modifierEmailConfiguration);
            groupBox5.Controls.Add(loadEmailConfigurationButton);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(smtpPassword);
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(smtpUsername);
            groupBox5.Location = new Point(18, 17);
            groupBox5.Margin = new Padding(2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(2);
            groupBox5.Size = new Size(1228, 109);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = " Credentials ";
            // 
            // modifierEmailConfiguration
            // 
            modifierEmailConfiguration.Location = new Point(486, 35);
            modifierEmailConfiguration.Margin = new Padding(2);
            modifierEmailConfiguration.Name = "modifierEmailConfiguration";
            modifierEmailConfiguration.Size = new Size(211, 47);
            modifierEmailConfiguration.TabIndex = 10;
            modifierEmailConfiguration.Text = "Update";
            modifierEmailConfiguration.UseVisualStyleBackColor = true;
            modifierEmailConfiguration.Click += ModifierEmailConfiguration_Click;
            // 
            // loadEmailConfigurationButton
            // 
            loadEmailConfigurationButton.Location = new Point(986, 35);
            loadEmailConfigurationButton.Margin = new Padding(2);
            loadEmailConfigurationButton.Name = "loadEmailConfigurationButton";
            loadEmailConfigurationButton.Size = new Size(211, 47);
            loadEmailConfigurationButton.TabIndex = 4;
            loadEmailConfigurationButton.Text = "Load";
            loadEmailConfigurationButton.UseVisualStyleBackColor = true;
            loadEmailConfigurationButton.Click += loadEmailConfigurationButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 67);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 2;
            label3.Text = "Email Password";
            // 
            // smtpPassword
            // 
            smtpPassword.Location = new Point(132, 64);
            smtpPassword.Margin = new Padding(2);
            smtpPassword.Name = "smtpPassword";
            smtpPassword.PlaceholderText = "Password";
            smtpPassword.Size = new Size(330, 23);
            smtpPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 35);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 0;
            label2.Text = "Email Username";
            // 
            // smtpUsername
            // 
            smtpUsername.Location = new Point(132, 32);
            smtpUsername.Margin = new Padding(2);
            smtpUsername.Name = "smtpUsername";
            smtpUsername.PlaceholderText = "Username";
            smtpUsername.Size = new Size(330, 23);
            smtpUsername.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(1264, 546);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "SMS Configuration";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(modifierSmsConfiguration);
            groupBox4.Controls.Add(loadSmsConfigurationButton);
            groupBox4.Controls.Add(twilioAuthToken);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(twilioAccountSid);
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new Point(18, 17);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(1228, 109);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = " Credentials ";
            // 
            // modifierSmsConfiguration
            // 
            modifierSmsConfiguration.Location = new Point(485, 35);
            modifierSmsConfiguration.Margin = new Padding(2);
            modifierSmsConfiguration.Name = "modifierSmsConfiguration";
            modifierSmsConfiguration.Size = new Size(211, 47);
            modifierSmsConfiguration.TabIndex = 12;
            modifierSmsConfiguration.Text = "Update";
            modifierSmsConfiguration.UseVisualStyleBackColor = true;
            modifierSmsConfiguration.Click += modifierSmsConfiguration_Click;
            // 
            // loadSmsConfigurationButton
            // 
            loadSmsConfigurationButton.Location = new Point(985, 35);
            loadSmsConfigurationButton.Margin = new Padding(2);
            loadSmsConfigurationButton.Name = "loadSmsConfigurationButton";
            loadSmsConfigurationButton.Size = new Size(211, 47);
            loadSmsConfigurationButton.TabIndex = 11;
            loadSmsConfigurationButton.Text = "Load";
            loadSmsConfigurationButton.UseVisualStyleBackColor = true;
            loadSmsConfigurationButton.Click += loadSmsConfigurationButton_Click;
            // 
            // twilioAuthToken
            // 
            twilioAuthToken.Location = new Point(130, 63);
            twilioAuthToken.Margin = new Padding(2);
            twilioAuthToken.Name = "twilioAuthToken";
            twilioAuthToken.PlaceholderText = "Token";
            twilioAuthToken.Size = new Size(330, 23);
            twilioAuthToken.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 67);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 6;
            label4.Text = "SMS AuthToken";
            // 
            // twilioAccountSid
            // 
            twilioAccountSid.Location = new Point(130, 32);
            twilioAccountSid.Margin = new Padding(2);
            twilioAccountSid.Name = "twilioAccountSid";
            twilioAccountSid.PlaceholderText = "Account SID";
            twilioAccountSid.Size = new Size(330, 23);
            twilioAccountSid.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 35);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 4;
            label5.Text = "SMS Account ID";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(updateEMailMessageButton);
            tabPage3.Controls.Add(loadEMailMessageButton);
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1264, 546);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Mail";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // updateEMailMessageButton
            // 
            updateEMailMessageButton.Location = new Point(265, 475);
            updateEMailMessageButton.Margin = new Padding(2);
            updateEMailMessageButton.Name = "updateEMailMessageButton";
            updateEMailMessageButton.Size = new Size(211, 47);
            updateEMailMessageButton.TabIndex = 14;
            updateEMailMessageButton.Text = "Update";
            updateEMailMessageButton.UseVisualStyleBackColor = true;
            updateEMailMessageButton.Click += updateEMailMessageButton_Click;
            // 
            // loadEMailMessageButton
            // 
            loadEMailMessageButton.Location = new Point(765, 475);
            loadEMailMessageButton.Margin = new Padding(2);
            loadEMailMessageButton.Name = "loadEMailMessageButton";
            loadEMailMessageButton.Size = new Size(211, 47);
            loadEMailMessageButton.TabIndex = 13;
            loadEMailMessageButton.Text = "Load";
            loadEMailMessageButton.UseVisualStyleBackColor = true;
            loadEMailMessageButton.Click += loadEMailMessageButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(emailMessage);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(emailSubject);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(22, 253);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(1218, 200);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Message";
            // 
            // emailMessage
            // 
            emailMessage.Location = new Point(125, 56);
            emailMessage.Margin = new Padding(2);
            emailMessage.Multiline = true;
            emailMessage.Name = "emailMessage";
            emailMessage.PlaceholderText = "Message";
            emailMessage.Size = new Size(1075, 128);
            emailMessage.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 60);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(53, 15);
            label10.TabIndex = 10;
            label10.Text = "Message";
            // 
            // emailSubject
            // 
            emailSubject.Location = new Point(125, 22);
            emailSubject.Margin = new Padding(2);
            emailSubject.Name = "emailSubject";
            emailSubject.PlaceholderText = "Subject";
            emailSubject.Size = new Size(330, 23);
            emailSubject.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 26);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(46, 15);
            label11.TabIndex = 8;
            label11.Text = "Subject";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(toAddressAddress);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(toAddressName);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(22, 131);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(1218, 94);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = " To Address ";
            // 
            // toAddressAddress
            // 
            toAddressAddress.Location = new Point(125, 56);
            toAddressAddress.Margin = new Padding(2);
            toAddressAddress.Name = "toAddressAddress";
            toAddressAddress.PlaceholderText = "Address";
            toAddressAddress.Size = new Size(330, 23);
            toAddressAddress.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 60);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 10;
            label8.Text = "Address";
            // 
            // toAddressName
            // 
            toAddressName.Location = new Point(125, 22);
            toAddressName.Margin = new Padding(2);
            toAddressName.Name = "toAddressName";
            toAddressName.PlaceholderText = "Name";
            toAddressName.Size = new Size(330, 23);
            toAddressName.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 26);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 8;
            label9.Text = "Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(fromAddressAddress);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(fromAddressName);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(22, 17);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(1218, 94);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = " From Address ";
            // 
            // fromAddressAddress
            // 
            fromAddressAddress.Location = new Point(125, 56);
            fromAddressAddress.Margin = new Padding(2);
            fromAddressAddress.Name = "fromAddressAddress";
            fromAddressAddress.PlaceholderText = "Address";
            fromAddressAddress.Size = new Size(330, 23);
            fromAddressAddress.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 60);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 10;
            label6.Text = "Address";
            // 
            // fromAddressName
            // 
            fromAddressName.Location = new Point(125, 22);
            fromAddressName.Margin = new Padding(2);
            fromAddressName.Name = "fromAddressName";
            fromAddressName.PlaceholderText = "Name";
            fromAddressName.Size = new Size(330, 23);
            fromAddressName.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 26);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 8;
            label7.Text = "Name";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(updateSmsMessageButton);
            tabPage4.Controls.Add(loadSmsMessageButton);
            tabPage4.Controls.Add(groupBox6);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(2);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1264, 546);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "SMS";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // updateSmsMessageButton
            // 
            updateSmsMessageButton.Location = new Point(257, 337);
            updateSmsMessageButton.Margin = new Padding(2);
            updateSmsMessageButton.Name = "updateSmsMessageButton";
            updateSmsMessageButton.Size = new Size(211, 47);
            updateSmsMessageButton.TabIndex = 16;
            updateSmsMessageButton.Text = "Update";
            updateSmsMessageButton.UseVisualStyleBackColor = true;
            updateSmsMessageButton.Click += updateSmsMessageButton_Click;
            // 
            // loadSmsMessageButton
            // 
            loadSmsMessageButton.Location = new Point(757, 338);
            loadSmsMessageButton.Margin = new Padding(2);
            loadSmsMessageButton.Name = "loadSmsMessageButton";
            loadSmsMessageButton.Size = new Size(211, 47);
            loadSmsMessageButton.TabIndex = 15;
            loadSmsMessageButton.Text = "Load";
            loadSmsMessageButton.UseVisualStyleBackColor = true;
            loadSmsMessageButton.Click += loadSmsMessageButton_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(smsMessage);
            groupBox6.Controls.Add(label14);
            groupBox6.Controls.Add(toNumberPhone);
            groupBox6.Controls.Add(label13);
            groupBox6.Controls.Add(fromNumberPhone);
            groupBox6.Controls.Add(label12);
            groupBox6.Location = new Point(28, 20);
            groupBox6.Margin = new Padding(2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(2);
            groupBox6.Size = new Size(1209, 256);
            groupBox6.TabIndex = 0;
            groupBox6.TabStop = false;
            groupBox6.Text = "SMS Content";
            // 
            // smsMessage
            // 
            smsMessage.Location = new Point(168, 112);
            smsMessage.Margin = new Padding(2);
            smsMessage.Multiline = true;
            smsMessage.Name = "smsMessage";
            smsMessage.PlaceholderText = "Message";
            smsMessage.Size = new Size(1020, 125);
            smsMessage.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(24, 113);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(53, 15);
            label14.TabIndex = 2;
            label14.Text = "Message";
            // 
            // toNumberPhone
            // 
            toNumberPhone.Location = new Point(168, 67);
            toNumberPhone.Margin = new Padding(2);
            toNumberPhone.Name = "toNumberPhone";
            toNumberPhone.PlaceholderText = "To #Phone";
            toNumberPhone.Size = new Size(332, 23);
            toNumberPhone.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(24, 69);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(103, 15);
            label13.TabIndex = 2;
            label13.Text = "To Number Phone";
            // 
            // fromNumberPhone
            // 
            fromNumberPhone.Location = new Point(168, 29);
            fromNumberPhone.Margin = new Padding(2);
            fromNumberPhone.Name = "fromNumberPhone";
            fromNumberPhone.PlaceholderText = "From #Phone";
            fromNumberPhone.Size = new Size(332, 23);
            fromNumberPhone.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(24, 31);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(119, 15);
            label12.TabIndex = 0;
            label12.Text = "From Number Phone";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(groupBox7);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Margin = new Padding(2);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1264, 546);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Notification Channel";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(loadNotificationChannelButton);
            groupBox7.Controls.Add(updateNotificationChannelButton);
            groupBox7.Controls.Add(mailSmsChannelRadio);
            groupBox7.Controls.Add(smsChannelRadio);
            groupBox7.Controls.Add(mailChannelRadio);
            groupBox7.Location = new Point(23, 18);
            groupBox7.Margin = new Padding(2);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(2);
            groupBox7.Size = new Size(1219, 146);
            groupBox7.TabIndex = 0;
            groupBox7.TabStop = false;
            groupBox7.Text = " Notification Channel ";
            // 
            // loadNotificationChannelButton
            // 
            loadNotificationChannelButton.Location = new Point(974, 51);
            loadNotificationChannelButton.Margin = new Padding(2);
            loadNotificationChannelButton.Name = "loadNotificationChannelButton";
            loadNotificationChannelButton.Size = new Size(211, 47);
            loadNotificationChannelButton.TabIndex = 15;
            loadNotificationChannelButton.Text = "Load";
            loadNotificationChannelButton.UseVisualStyleBackColor = true;
            loadNotificationChannelButton.Click += loadNotificationChannelButton_Click;
            // 
            // updateNotificationChannelButton
            // 
            updateNotificationChannelButton.Location = new Point(470, 51);
            updateNotificationChannelButton.Margin = new Padding(2);
            updateNotificationChannelButton.Name = "updateNotificationChannelButton";
            updateNotificationChannelButton.Size = new Size(211, 47);
            updateNotificationChannelButton.TabIndex = 16;
            updateNotificationChannelButton.Text = "Update";
            updateNotificationChannelButton.UseVisualStyleBackColor = true;
            updateNotificationChannelButton.Click += updateNotificationChannelButton_Click;
            // 
            // mailSmsChannelRadio
            // 
            mailSmsChannelRadio.AutoSize = true;
            mailSmsChannelRadio.Location = new Point(34, 100);
            mailSmsChannelRadio.Margin = new Padding(2);
            mailSmsChannelRadio.Name = "mailSmsChannelRadio";
            mailSmsChannelRadio.Size = new Size(144, 19);
            mailSmsChannelRadio.TabIndex = 3;
            mailSmsChannelRadio.TabStop = true;
            mailSmsChannelRadio.Text = "Mail and SMS Channel";
            mailSmsChannelRadio.UseVisualStyleBackColor = true;
            mailSmsChannelRadio.CheckedChanged += mailSmsChannelRadio_CheckedChanged;
            // 
            // smsChannelRadio
            // 
            smsChannelRadio.AutoSize = true;
            smsChannelRadio.Location = new Point(34, 67);
            smsChannelRadio.Margin = new Padding(2);
            smsChannelRadio.Name = "smsChannelRadio";
            smsChannelRadio.Size = new Size(95, 19);
            smsChannelRadio.TabIndex = 2;
            smsChannelRadio.TabStop = true;
            smsChannelRadio.Text = "SMS Channel";
            smsChannelRadio.UseVisualStyleBackColor = true;
            smsChannelRadio.CheckedChanged += smsChannelRadio_CheckedChanged;
            // 
            // mailChannelRadio
            // 
            mailChannelRadio.AutoSize = true;
            mailChannelRadio.Location = new Point(34, 34);
            mailChannelRadio.Margin = new Padding(2);
            mailChannelRadio.Name = "mailChannelRadio";
            mailChannelRadio.Size = new Size(95, 19);
            mailChannelRadio.TabIndex = 1;
            mailChannelRadio.TabStop = true;
            mailChannelRadio.Text = "Mail Channel";
            mailChannelRadio.UseVisualStyleBackColor = true;
            mailChannelRadio.CheckedChanged += mailChannelRadio_CheckedChanged;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(groupBox8);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Margin = new Padding(2);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1264, 546);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "SMS Locked";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(loadSmsLockedButton);
            groupBox8.Controls.Add(updateSmsLockedButton);
            groupBox8.Controls.Add(smsLockedNo);
            groupBox8.Controls.Add(smsLockedYes);
            groupBox8.Location = new Point(24, 18);
            groupBox8.Margin = new Padding(2);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(2);
            groupBox8.Size = new Size(1219, 121);
            groupBox8.TabIndex = 1;
            groupBox8.TabStop = false;
            groupBox8.Text = " SMS Locked ? ";
            // 
            // loadSmsLockedButton
            // 
            loadSmsLockedButton.Location = new Point(930, 33);
            loadSmsLockedButton.Margin = new Padding(2);
            loadSmsLockedButton.Name = "loadSmsLockedButton";
            loadSmsLockedButton.Size = new Size(211, 47);
            loadSmsLockedButton.TabIndex = 17;
            loadSmsLockedButton.Text = "Load";
            loadSmsLockedButton.UseVisualStyleBackColor = true;
            loadSmsLockedButton.Click += loadSmsLockedButton_Click;
            // 
            // updateSmsLockedButton
            // 
            updateSmsLockedButton.Location = new Point(426, 33);
            updateSmsLockedButton.Margin = new Padding(2);
            updateSmsLockedButton.Name = "updateSmsLockedButton";
            updateSmsLockedButton.Size = new Size(211, 47);
            updateSmsLockedButton.TabIndex = 18;
            updateSmsLockedButton.Text = "Update";
            updateSmsLockedButton.UseVisualStyleBackColor = true;
            updateSmsLockedButton.Click += updateSmsLockedButton_Click;
            // 
            // smsLockedNo
            // 
            smsLockedNo.AutoSize = true;
            smsLockedNo.Location = new Point(34, 66);
            smsLockedNo.Margin = new Padding(2);
            smsLockedNo.Name = "smsLockedNo";
            smsLockedNo.Size = new Size(41, 19);
            smsLockedNo.TabIndex = 2;
            smsLockedNo.TabStop = true;
            smsLockedNo.Text = "No";
            smsLockedNo.UseVisualStyleBackColor = true;
            smsLockedNo.CheckedChanged += smsLockedNo_CheckedChanged;
            // 
            // smsLockedYes
            // 
            smsLockedYes.AutoSize = true;
            smsLockedYes.Location = new Point(34, 33);
            smsLockedYes.Margin = new Padding(2);
            smsLockedYes.Name = "smsLockedYes";
            smsLockedYes.Size = new Size(42, 19);
            smsLockedYes.TabIndex = 1;
            smsLockedYes.TabStop = true;
            smsLockedYes.Text = "Yes";
            smsLockedYes.UseVisualStyleBackColor = true;
            smsLockedYes.CheckedChanged += smsLockedYes_CheckedChanged;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(groupBox10);
            tabPage7.Controls.Add(groupBox9);
            tabPage7.Location = new Point(4, 24);
            tabPage7.Margin = new Padding(2);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(1264, 546);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Application Config";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(textBox2);
            groupBox10.Controls.Add(textBox1);
            groupBox10.Controls.Add(label16);
            groupBox10.Controls.Add(label15);
            groupBox10.Location = new Point(24, 170);
            groupBox10.Margin = new Padding(2);
            groupBox10.Name = "groupBox10";
            groupBox10.Padding = new Padding(2);
            groupBox10.Size = new Size(1219, 141);
            groupBox10.TabIndex = 3;
            groupBox10.TabStop = false;
            groupBox10.Text = " Variables to use in your messages ";
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.Hand;
            textBox2.Location = new Point(34, 86);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(285, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "__EMO_PC_NAME__";
            toolTipApplication.SetToolTip(textBox2, "Double click to copy the value");
            textBox2.DoubleClick += textBox2_DoubleClick;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.Hand;
            textBox1.Location = new Point(34, 35);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(285, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "__EMO_OPENED_DATE__";
            toolTipApplication.SetToolTip(textBox1, "Double click to copy the value");
            textBox1.DoubleClick += textBox1_DoubleClick;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(681, 74);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(418, 30);
            label16.TabIndex = 1;
            label16.Text = "__EMO_PC_NAME__ : For getting the PC name. \r\nDouble click on the field to copy value and use it in the message template.";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(681, 24);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(445, 30);
            label15.TabIndex = 0;
            label15.Text = "__EMO_OPENED_DATE__ : For having the current date and time. \r\nDouble click on the field text to copy value and use it in the message template.";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(loadApplicationIsEnableButton);
            groupBox9.Controls.Add(updateApplicationIsEnableButton);
            groupBox9.Controls.Add(applicationIsEnableNoRadio);
            groupBox9.Controls.Add(applicationIsEnableYesRadio);
            groupBox9.Location = new Point(24, 20);
            groupBox9.Margin = new Padding(2);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(2);
            groupBox9.Size = new Size(1219, 121);
            groupBox9.TabIndex = 2;
            groupBox9.TabStop = false;
            groupBox9.Text = " Application is enables ? ";
            // 
            // loadApplicationIsEnableButton
            // 
            loadApplicationIsEnableButton.Location = new Point(930, 33);
            loadApplicationIsEnableButton.Margin = new Padding(2);
            loadApplicationIsEnableButton.Name = "loadApplicationIsEnableButton";
            loadApplicationIsEnableButton.Size = new Size(211, 47);
            loadApplicationIsEnableButton.TabIndex = 17;
            loadApplicationIsEnableButton.Text = "Load";
            loadApplicationIsEnableButton.UseVisualStyleBackColor = true;
            loadApplicationIsEnableButton.Click += loadApplicationIsEnableButton_Click;
            // 
            // updateApplicationIsEnableButton
            // 
            updateApplicationIsEnableButton.Location = new Point(426, 33);
            updateApplicationIsEnableButton.Margin = new Padding(2);
            updateApplicationIsEnableButton.Name = "updateApplicationIsEnableButton";
            updateApplicationIsEnableButton.Size = new Size(211, 47);
            updateApplicationIsEnableButton.TabIndex = 18;
            updateApplicationIsEnableButton.Text = "Update";
            updateApplicationIsEnableButton.UseVisualStyleBackColor = true;
            updateApplicationIsEnableButton.Click += updateApplicationIsEnableButton_Click;
            // 
            // applicationIsEnableNoRadio
            // 
            applicationIsEnableNoRadio.AutoSize = true;
            applicationIsEnableNoRadio.Location = new Point(34, 66);
            applicationIsEnableNoRadio.Margin = new Padding(2);
            applicationIsEnableNoRadio.Name = "applicationIsEnableNoRadio";
            applicationIsEnableNoRadio.Size = new Size(41, 19);
            applicationIsEnableNoRadio.TabIndex = 2;
            applicationIsEnableNoRadio.TabStop = true;
            applicationIsEnableNoRadio.Text = "No";
            applicationIsEnableNoRadio.UseVisualStyleBackColor = true;
            applicationIsEnableNoRadio.CheckedChanged += applicationIsEnableNoRadio_CheckedChanged;
            // 
            // applicationIsEnableYesRadio
            // 
            applicationIsEnableYesRadio.AutoSize = true;
            applicationIsEnableYesRadio.Location = new Point(34, 33);
            applicationIsEnableYesRadio.Margin = new Padding(2);
            applicationIsEnableYesRadio.Name = "applicationIsEnableYesRadio";
            applicationIsEnableYesRadio.Size = new Size(42, 19);
            applicationIsEnableYesRadio.TabIndex = 1;
            applicationIsEnableYesRadio.TabStop = true;
            applicationIsEnableYesRadio.Text = "Yes";
            applicationIsEnableYesRadio.UseVisualStyleBackColor = true;
            applicationIsEnableYesRadio.CheckedChanged += applicationIsEnableYesRadio_CheckedChanged;
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(rightToLeft);
            tabPage8.Controls.Add(leftToRight);
            tabPage8.Controls.Add(label17);
            tabPage8.Location = new Point(4, 24);
            tabPage8.Margin = new Padding(2);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(1264, 546);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "About";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // rightToLeft
            // 
            rightToLeft.Location = new Point(724, 281);
            rightToLeft.Margin = new Padding(2);
            rightToLeft.Name = "rightToLeft";
            rightToLeft.Size = new Size(244, 46);
            rightToLeft.TabIndex = 2;
            rightToLeft.Text = "Right to Left";
            rightToLeft.UseVisualStyleBackColor = true;
            rightToLeft.Click += rightToLeft_Click;
            // 
            // leftToRight
            // 
            leftToRight.Location = new Point(291, 281);
            leftToRight.Margin = new Padding(2);
            leftToRight.Name = "leftToRight";
            leftToRight.Size = new Size(244, 46);
            leftToRight.TabIndex = 1;
            leftToRight.Text = "Left to Right";
            leftToRight.UseVisualStyleBackColor = true;
            leftToRight.Click += leftToRight_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(2, 224);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(1010, 21);
            label17.TabIndex = 0;
            label17.Text = "This application is a free GNU General Public License (GPL) software, made by EMO FREDY. You are free to do what ever you want :) !";
            // 
            // loadJsonConfiguration
            // 
            loadJsonConfiguration.DefaultExt = "json";
            loadJsonConfiguration.FileName = "openFileDialog1";
            loadJsonConfiguration.FilterIndex = 2;
            loadJsonConfiguration.RestoreDirectory = true;
            // 
            // loadTxtConfiguration
            // 
            loadTxtConfiguration.FileName = "openFileDialog1";
            // 
            // timerMarquee
            // 
            timerMarquee.Tick += timerMarquee_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 717);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Send Configuration";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabPage3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage4.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            tabPage5.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            tabPage6.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            tabPage7.ResumeLayout(false);
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            tabPage8.ResumeLayout(false);
            tabPage8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TextBox smtpUsername;
        private Label label2;
        private TextBox smtpPassword;
        private Label label3;
        private TextBox twilioAuthToken;
        private Label label4;
        private TextBox twilioAccountSid;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox fromAddressAddress;
        private Label label6;
        private TextBox fromAddressName;
        private Label label7;
        private GroupBox groupBox2;
        private TextBox toAddressAddress;
        private Label label8;
        private TextBox toAddressName;
        private Label label9;
        private GroupBox groupBox3;
        private TextBox emailMessage;
        private Label label10;
        private TextBox emailSubject;
        private Label label11;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private GroupBox groupBox6;
        private TextBox smsMessage;
        private Label label14;
        private TextBox toNumberPhone;
        private Label label13;
        private TextBox fromNumberPhone;
        private Label label12;
        private GroupBox groupBox7;
        private RadioButton mailSmsChannelRadio;
        private RadioButton smsChannelRadio;
        private RadioButton mailChannelRadio;
        private GroupBox groupBox8;
        private RadioButton smsLockedNo;
        private RadioButton smsLockedYes;
        private OpenFileDialog loadJsonConfiguration;
        private Button loadEmailConfigurationButton;
        private Button modifierEmailConfiguration;
        private Button modifierSmsConfiguration;
        private Button loadSmsConfigurationButton;
        private OpenFileDialog loadTxtConfiguration;
        private Button updateEMailMessageButton;
        private Button loadEMailMessageButton;
        private Button updateSmsMessageButton;
        private Button loadSmsMessageButton;
        private Button updateNotificationChannelButton;
        private Button loadNotificationChannelButton;
        private Button loadSmsLockedButton;
        private Button updateSmsLockedButton;
        private TabPage tabPage7;
        private GroupBox groupBox9;
        private Button loadApplicationIsEnableButton;
        private Button updateApplicationIsEnableButton;
        private RadioButton applicationIsEnableNoRadio;
        private RadioButton applicationIsEnableYesRadio;
        private GroupBox groupBox10;
        private Label label15;
        private Label label16;
        private TextBox textBox1;
        private ToolTip toolTipApplication;
        private TextBox textBox2;
        private TabPage tabPage8;
        private System.Windows.Forms.Timer timerMarquee;
        private Label label17;
        private Button rightToLeft;
        private Button leftToRight;
    }
}
