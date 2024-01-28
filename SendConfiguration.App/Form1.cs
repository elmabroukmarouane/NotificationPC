using MailSendStartup.App.Configuration;
using MailSendStartup.App.Models;
using System.Text.Json;

namespace SendConfiguration.App
{
    public partial class Form1 : Form
    {
        #region Attributes
        public string? EmailConfigurationFilePath { get; set; }
        public EmailConfiguration? EmailConfiguration { get; set; }
        public string? SmsConfigurationFilePath { get; set; }
        public SmsConfiguration? SmsConfiguration { get; set; }
        public string? EmailMessageFilePath { get; set; }
        public EmailMessage? EmailMessage { get; set; }
        public string? SmsMessageFilePath { get; set; }
        public SmsMessage? SmsMessage { get; set; }
        public string? NotificationChannelFilePath { get; set; }
        public int NotificationChannel { get; set; } = -1;
        public string? SmsLockedFilePath { get; set; }
        public string? SmsLocked { get; set; }
        public string? ApplicationEnableFilePath { get; set; }
        public string? ApplicationEnable { get; set; }
        public int xpos = 0, ypos = 0;
        public string mode = "Left-to-Right";
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
            InitDialogBoxes();
            //EnableTextBoxes();
            EnableButtons();
            EnableRadios();
            MarqueeRightToLeft();
        }
        #endregion

        #region InitComponents
        private void InitDialogBoxes()
        {
            loadJsonConfiguration = new()
            {
                Filter = "JSON File (*.json)|*.json|All files (*.*)|*.*",
                DefaultExt = "json",
                Title = "Select Configuration JSON File"
            };

            loadTxtConfiguration = new()
            {
                Filter = "Text File (*.txt)|*.txt|All files (*.*)|*.*",
                DefaultExt = "txt",
                Title = "Select Configuration Text File"
            };
        }

        private void EnableTextBoxes()
        {
            // Email Configuration
            smtpUsername.Enabled = EmailConfiguration is not null;
            smtpPassword.Enabled = EmailConfiguration is not null;
            //SMS Configuration
            twilioAccountSid.Enabled = SmsConfiguration is not null;
            twilioAuthToken.Enabled = SmsConfiguration is not null;
        }

        private void EnableButtons()
        {
            // Email Configuration
            loadEmailConfigurationButton.Enabled = EmailConfiguration is null;
            modifierEmailConfiguration.Enabled = EmailConfiguration is not null;
            //SMS Configuration
            loadSmsConfigurationButton.Enabled = SmsConfiguration is null;
            modifierSmsConfiguration.Enabled = SmsConfiguration is not null;
            // Email Message
            loadEMailMessageButton.Enabled = EmailMessage is null;
            updateEMailMessageButton.Enabled = EmailMessage is not null;
            // Sms Message
            loadSmsMessageButton.Enabled = SmsMessage is null;
            updateSmsMessageButton.Enabled = SmsMessage is not null;
            // Notification Channel
            loadNotificationChannelButton.Enabled = NotificationChannel == -1;
            updateNotificationChannelButton.Enabled = NotificationChannel != -1;
            // SMS Locked
            loadSmsLockedButton.Enabled = SmsLocked is null;
            updateSmsLockedButton.Enabled = SmsLocked is not null;
            // Application Enabled
            loadApplicationIsEnableButton.Enabled = ApplicationEnable is null;
            updateApplicationIsEnableButton.Enabled = ApplicationEnable is not null;
        }

        private void EnableRadios()
        {
            // Notification Channel
            mailChannelRadio.Enabled = NotificationChannelFilePath is not null;
            smsChannelRadio.Enabled = NotificationChannelFilePath is not null;
            mailSmsChannelRadio.Enabled = NotificationChannelFilePath is not null;
            // SMS Locked
            smsLockedNo.Enabled = SmsLockedFilePath is not null;
            smsLockedYes.Enabled = SmsLockedFilePath is not null;
            // Application Enabled
            applicationIsEnableNoRadio.Enabled = ApplicationEnable is not null;
            applicationIsEnableYesRadio.Enabled = ApplicationEnable is not null;
        }

        private void ClearTextBoxes(int choice)
        {
            switch (choice)
            {
                case 1:
                    smtpUsername.Text = string.Empty;
                    smtpPassword.Text = string.Empty;
                    break;
                case 2:
                    twilioAccountSid.Text = string.Empty;
                    twilioAuthToken.Text = string.Empty;
                    break;
                case 3:
                    fromAddressName.Text = string.Empty;
                    fromAddressAddress.Text = string.Empty;
                    toAddressName.Text = string.Empty;
                    toAddressAddress.Text = string.Empty;
                    emailSubject.Text = string.Empty;
                    emailMessage.Text = string.Empty;
                    break;
                case 4:
                    fromNumberPhone.Text = string.Empty;
                    toNumberPhone.Text = string.Empty;
                    smsMessage.Text = string.Empty;
                    break;
                case 5:
                    mailChannelRadio.Checked = false;
                    smsChannelRadio.Checked = false;
                    mailSmsChannelRadio.Checked = false;
                    break;
                case 6:
                    smsLockedNo.Checked = false;
                    smsLockedYes.Checked = false;
                    break;
                case 7:
                    applicationIsEnableNoRadio.Checked = false;
                    applicationIsEnableYesRadio.Checked = false;
                    break;
            }
        }
        #endregion

        #region Events Handler

        #region EmailConfiguration Module
        private void loadEmailConfigurationButton_Click(object sender, EventArgs e)
        {
            loadJsonConfiguration.FileName = "emailConfiguration.json";
            loadJsonConfiguration.Filter = "Email Configuration JSON File|emailConfiguration.json|JSON File (*.json)|*.json|All files (*.*)|*.*";
            var dialogResult = loadJsonConfiguration.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                EmailConfigurationFilePath = loadJsonConfiguration.FileName;
                if (EmailConfigurationFilePath is not null)
                {
                    EmailConfiguration = GetDeserializedJson<EmailConfiguration>(EmailConfigurationFilePath);
                    smtpUsername.Text = EmailConfiguration?.SmtpUsername;
                    smtpPassword.Text = EmailConfiguration?.SmtpPassword;
                    //EnableTextBoxes();
                    EnableButtons();
                }
            }
        }

        private void ModifierEmailConfiguration_Click(object sender, EventArgs e)
        {
            if (EmailConfigurationFilePath is not null && EmailConfiguration is not null)
            {
                if (!string.IsNullOrEmpty(smtpUsername.Text) && !string.IsNullOrEmpty(smtpPassword.Text))
                {
                    PutInFile(EmailConfigurationFilePath);
                    EmailConfiguration.SmtpUsername = smtpUsername.Text.Trim();
                    EmailConfiguration.SmtpPassword = smtpPassword.Text.Trim();
                    var emailConfigurationString = GetSerializedJson(EmailConfiguration!);
                    PutInFile(EmailConfigurationFilePath, emailConfigurationString);
                    EmailConfiguration = null;
                    ClearTextBoxes(choice: 1);
                    //EnableTextBoxes();
                    EnableButtons();
                    MessageBox.Show("Email Configuration updated successfully !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    EmailConfiguration = null;
                    //EnableTextBoxes();
                    EnableButtons();
                    MessageBox.Show("Please fill the informations !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                EnableButtons();
                MessageBox.Show("Please load the Email Configuration !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region SMS Configuration Module
        private void loadSmsConfigurationButton_Click(object sender, EventArgs e)
        {
            loadJsonConfiguration.FileName = "smsConfiguration.json";
            loadJsonConfiguration.Filter = "SMS Configuration JSON File|smsConfiguration.json|JSON File (*.json)|*.json|All files (*.*)|*.*";
            var dialogResult = loadJsonConfiguration.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                SmsConfigurationFilePath = loadJsonConfiguration.FileName;
                if (SmsConfigurationFilePath is not null)
                {
                    SmsConfiguration = GetDeserializedJson<SmsConfiguration>(SmsConfigurationFilePath);
                    twilioAccountSid.Text = SmsConfiguration?.TwilioAccountSid;
                    twilioAuthToken.Text = SmsConfiguration?.TwilioAuthToken;
                    //EnableTextBoxes();
                    EnableButtons();
                }
            }
        }

        private void modifierSmsConfiguration_Click(object sender, EventArgs e)
        {
            if (SmsConfigurationFilePath is not null && SmsConfiguration is not null)
            {
                if (!string.IsNullOrEmpty(twilioAccountSid.Text) && !string.IsNullOrEmpty(twilioAuthToken.Text))
                {
                    PutInFile(SmsConfigurationFilePath);
                    SmsConfiguration.TwilioAccountSid = twilioAccountSid.Text.Trim();
                    SmsConfiguration.TwilioAuthToken = twilioAuthToken.Text.Trim();
                    var smsConfigurationString = GetSerializedJson(SmsConfiguration!);
                    PutInFile(SmsConfigurationFilePath, smsConfigurationString);
                    SmsConfiguration = null;
                    ClearTextBoxes(choice: 2);
                    //EnableTextBoxes();
                    EnableButtons();
                    MessageBox.Show("Sms Configuration updated successfully !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    EmailConfiguration = null;
                    //EnableTextBoxes();
                    EnableButtons();
                    MessageBox.Show("Please fill the informations !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                EnableButtons();
                MessageBox.Show("Please load the Email Configuration !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Email Message Module
        private void loadEMailMessageButton_Click(object sender, EventArgs e)
        {
            loadJsonConfiguration.FileName = "mail.json";
            loadJsonConfiguration.Filter = "Mail Template JSON File|mail.json|JSON File (*.json)|*.json|All files (*.*)|*.*";
            var dialogResult = loadJsonConfiguration.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                EmailMessageFilePath = loadJsonConfiguration.FileName;
                if (EmailMessageFilePath is not null)
                {
                    EmailMessage = GetDeserializedJson<EmailMessage>(EmailMessageFilePath);
                    var fromAdress = EmailMessage?.FromAddresses?.FirstOrDefault();
                    var toAdress = EmailMessage?.ToAddresses?.FirstOrDefault();
                    fromAddressName.Text = fromAdress?.Name;
                    fromAddressAddress.Text = fromAdress?.Address;
                    toAddressName.Text = toAdress?.Name;
                    toAddressAddress.Text = toAdress?.Address;
                    emailSubject.Text = EmailMessage?.Subject;
                    emailMessage.Text = EmailMessage?.Content;
                    //EnableTextBoxes();
                    EnableButtons();
                }
            }
        }

        private void updateEMailMessageButton_Click(object sender, EventArgs e)
        {
            if (EmailMessageFilePath is not null && EmailMessage is not null)
            {
                if (!string.IsNullOrEmpty(fromAddressName.Text) && !string.IsNullOrEmpty(fromAddressAddress.Text) && !string.IsNullOrEmpty(toAddressName.Text) && !string.IsNullOrEmpty(toAddressAddress.Text) && !string.IsNullOrEmpty(emailSubject.Text) && !string.IsNullOrEmpty(emailMessage.Text))
                {
                    PutInFile(EmailMessageFilePath);
                    EmailMessage.FromAddresses = new List<EmailAddress>();
                    EmailMessage?.FromAddresses?.Add(new()
                    {
                        Name = fromAddressName.Text.Trim(),
                        Address = fromAddressAddress.Text.Trim(),
                    });
                    EmailMessage!.ToAddresses = new List<EmailAddress>();
                    EmailMessage?.ToAddresses?.Add(new()
                    {
                        Name = toAddressName.Text.Trim(),
                        Address = toAddressAddress.Text.Trim(),
                    });
                    EmailMessage!.Subject = emailSubject.Text.Trim();
                    EmailMessage!.Content = emailMessage.Text;
                    var emailConfigurationString = GetSerializedJson(EmailMessage!);
                    PutInFile(EmailMessageFilePath, emailConfigurationString);
                    EmailMessage = null;
                    ClearTextBoxes(choice: 3);
                    //EnableTextBoxes();
                    EnableButtons();
                    MessageBox.Show("Email Template updated successfully !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    EmailConfiguration = null;
                    //EnableTextBoxes();
                    EnableButtons();
                    MessageBox.Show("Please fill the informations !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                EnableButtons();
                MessageBox.Show("Please load the Email Template !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region SMS Message Module
        private void loadSmsMessageButton_Click(object sender, EventArgs e)
        {
            loadJsonConfiguration.FileName = "sms.json";
            loadJsonConfiguration.Filter = "SMS Template JSON File|sms.json|JSON File (*.json)|*.json|All files (*.*)|*.*";
            var dialogResult = loadJsonConfiguration.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                SmsMessageFilePath = loadJsonConfiguration.FileName;
                if (SmsMessageFilePath is not null)
                {
                    SmsMessage = GetDeserializedJson<SmsMessage>(SmsMessageFilePath);
                    fromNumberPhone.Text = SmsMessage?.FromPhoneNumber;
                    toNumberPhone.Text = SmsMessage?.ToPhoneNumber;
                    smsMessage.Text = SmsMessage?.Content;
                    //EnableTextBoxes();
                    EnableButtons();
                }
            }
        }

        private void updateSmsMessageButton_Click(object sender, EventArgs e)
        {
            if (SmsMessageFilePath is not null && SmsMessage is not null)
            {
                if (!string.IsNullOrEmpty(fromNumberPhone.Text) && !string.IsNullOrEmpty(toNumberPhone.Text) && !string.IsNullOrEmpty(smsMessage.Text))
                {
                    PutInFile(SmsMessageFilePath);
                    SmsMessage.FromPhoneNumber = fromNumberPhone.Text.Trim();
                    SmsMessage.ToPhoneNumber = toNumberPhone.Text.Trim();
                    SmsMessage.Content = smsMessage.Text;
                    var smsConfigurationString = GetSerializedJson(SmsMessage!);
                    PutInFile(SmsMessageFilePath, smsConfigurationString);
                    SmsMessage = null;
                    ClearTextBoxes(choice: 4);
                    //EnableTextBoxes();
                    EnableButtons();
                    MessageBox.Show("SMS Template updated successfully !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    EmailConfiguration = null;
                    //EnableTextBoxes();
                    EnableButtons();
                    MessageBox.Show("Please fill the informations !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                EnableButtons();
                MessageBox.Show("Please load the SMS Template !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Notification Channel Module
        private void mailChannelRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (mailChannelRadio.Checked)
            {
                NotificationChannel = 0;
            }
        }

        private void smsChannelRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (smsChannelRadio.Checked)
            {
                NotificationChannel = 1;
            }
        }

        private void mailSmsChannelRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (mailSmsChannelRadio.Checked)
            {
                NotificationChannel = 2;
            }
        }

        private void loadNotificationChannelButton_Click(object sender, EventArgs e)
        {
            loadTxtConfiguration.FileName = "notificationChannel.txt";
            loadTxtConfiguration.Filter = "Notification Channel File|notificationChannel.txt|Text File (*.txt)|*.txt|All files (*.*)|*.*";
            var dialogResult = loadTxtConfiguration.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                NotificationChannelFilePath = loadTxtConfiguration.FileName;
                if (NotificationChannelFilePath is not null)
                {
                    NotificationChannel = int.Parse(GetFileContent(NotificationChannelFilePath) ?? "-1");
                    switch (NotificationChannel)
                    {
                        case 0:
                            mailChannelRadio.Checked = true;
                            break;
                        case 1:
                            smsChannelRadio.Checked = true;
                            break;
                        case 2:
                            mailSmsChannelRadio.Checked = true;
                            break;
                        default:
                            mailChannelRadio.Checked = true;
                            break;
                    }
                    EnableRadios();
                    EnableButtons();
                }
            }
        }

        private void updateNotificationChannelButton_Click(object sender, EventArgs e)
        {
            if (NotificationChannelFilePath is not null && NotificationChannel != -1)
            {
                PutInFile(NotificationChannelFilePath);
                PutInFile(NotificationChannelFilePath, NotificationChannel.ToString());
                NotificationChannel = -1;
                NotificationChannelFilePath = null;
                ClearTextBoxes(choice: 5);
                EnableRadios();
                EnableButtons();
                MessageBox.Show("Notification channel updated successfully !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                EnableRadios();
                EnableButtons();
                MessageBox.Show("Please load the Notification channel !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region SMS Locked Module
        private void smsLockedYes_CheckedChanged(object sender, EventArgs e)
        {
            if (smsLockedYes.Checked)
            {
                SmsLocked = "Yes";
            }
        }

        private void smsLockedNo_CheckedChanged(object sender, EventArgs e)
        {
            if (smsLockedNo.Checked)
            {
                SmsLocked = "No";
            }
        }

        private void loadSmsLockedButton_Click(object sender, EventArgs e)
        {
            loadTxtConfiguration.FileName = "smsLocked.txt";
            loadTxtConfiguration.Filter = "SMS Locked File|smsLocked.txt|Text File (*.txt)|*.txt|All files (*.*)|*.*";
            var dialogResult = loadTxtConfiguration.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                SmsLockedFilePath = loadTxtConfiguration.FileName;
                if (SmsLockedFilePath is not null)
                {
                    SmsLocked = GetFileContent(SmsLockedFilePath);
                    switch (SmsLocked)
                    {
                        case "Yes":
                            smsLockedYes.Checked = true;
                            break;
                        case "No":
                            smsLockedNo.Checked = true;
                            break;
                        default:
                            smsLockedYes.Checked = true;
                            break;
                    }
                    EnableRadios();
                    EnableButtons();
                }
            }
        }

        private void updateSmsLockedButton_Click(object sender, EventArgs e)
        {
            if (SmsLockedFilePath is not null && SmsLocked is not null)
            {
                PutInFile(SmsLockedFilePath);
                PutInFile(SmsLockedFilePath, SmsLocked);
                SmsLocked = null;
                SmsLockedFilePath = null;
                ClearTextBoxes(choice: 6);
                EnableRadios();
                EnableButtons();
                MessageBox.Show("SMS Locked updated successfully !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                EnableRadios();
                EnableButtons();
                MessageBox.Show("Please load the SMS Locked !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Application Configuration Module

        private void applicationIsEnableYesRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (applicationIsEnableYesRadio.Checked)
            {
                ApplicationEnable = "Yes";
            }
        }

        private void applicationIsEnableNoRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (applicationIsEnableNoRadio.Checked)
            {
                ApplicationEnable = "No";
            }
        }

        private void loadApplicationIsEnableButton_Click(object sender, EventArgs e)
        {
            loadTxtConfiguration.FileName = "applicationIsEnable.txt";
            loadTxtConfiguration.Filter = "Application Enabled File|applicationIsEnable.txt|Text File (*.txt)|*.txt|All files (*.*)|*.*";
            var dialogResult = loadTxtConfiguration.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                ApplicationEnableFilePath = loadTxtConfiguration.FileName;
                if (ApplicationEnableFilePath is not null)
                {
                    ApplicationEnable = GetFileContent(ApplicationEnableFilePath);
                    switch (ApplicationEnable)
                    {
                        case "Yes":
                            applicationIsEnableYesRadio.Checked = true;
                            break;
                        case "No":
                            applicationIsEnableNoRadio.Checked = true;
                            break;
                        default:
                            applicationIsEnableYesRadio.Checked = true;
                            break;
                    }
                    EnableRadios();
                    EnableButtons();
                }
            }
        }

        private void updateApplicationIsEnableButton_Click(object sender, EventArgs e)
        {
            if (ApplicationEnableFilePath is not null && ApplicationEnable is not null)
            {
                PutInFile(ApplicationEnableFilePath);
                PutInFile(ApplicationEnableFilePath, ApplicationEnable);
                ApplicationEnable = null;
                ApplicationEnableFilePath = null;
                ClearTextBoxes(choice: 7);
                EnableRadios();
                EnableButtons();
                MessageBox.Show("Application enabled configuration updated successfully !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                EnableRadios();
                EnableButtons();
                MessageBox.Show("Please load the Application enabled configuration !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
            MessageBox.Show("Copied", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
            MessageBox.Show("Copied", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #endregion

        #region Helpers
        private static string? GetFileContent(string pathFile)
        {
            try
            {
                using StreamReader stream = new(Path.Combine(pathFile));
                var str = stream.ReadToEnd();
                return str;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private static T? GetDeserializedJson<T>(string pathFile) where T : BaseModel
        {
            try
            {
                using StreamReader stream = new(Path.Combine(pathFile));
                var jsonStr = stream.ReadToEnd();
                var json = JsonSerializer.Deserialize<T>(jsonStr);
                return json;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private string GetSerializedJson<T>(T model) where T : BaseModel
        {
            return JsonSerializer.Serialize(model);
        }

        private void PutInFile(string filePath, string? content = default)
        {
            try
            {
                using StreamWriter writer = new(filePath);
                writer.Write(content);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region About Module
        private void leftToRight_Click(object sender, EventArgs e)
        {
            MarqueeLeftToRight();
        }

        private void rightToLeft_Click(object sender, EventArgs e)
        {
            MarqueeRightToLeft();
        }

        private void timerMarquee_Tick(object sender, EventArgs e)
        {
            if (mode == "Left-to-Right")
            {
                if (tabControl1.Width == xpos)
                {
                    label17.Location = new Point(0, ypos);
                    xpos = 0;
                }
                else
                {
                    label17.Location = new Point(xpos, ypos);
                    xpos += 5;
                }
            }
            else if (mode == "Right-to-Left")
            {
                if (xpos <= 0)
                {
                    label17.Location = new Point(tabControl1.Width, ypos);
                    xpos = tabControl1.Width;
                }
                else
                {
                    label17.Location = new Point(xpos, ypos);
                    xpos -= 5;
                }
            }
        }
        private void MarqueeLeftToRight()
        {
            xpos = label17.Location.X;
            ypos = label17.Location.Y;
            mode = "Left-to-Right";
            timerMarquee.Start();
        }

        private void MarqueeRightToLeft()
        {
            xpos = label17.Location.X;
            ypos = label17.Location.Y;
            mode = "Right-to-Left";
            timerMarquee.Start();
        }
        #endregion
    }
}
