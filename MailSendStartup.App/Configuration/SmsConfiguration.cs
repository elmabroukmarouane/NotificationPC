using MailSendStartup.App.Models;

namespace MailSendStartup.App.Configuration;
public class SmsConfiguration : BaseModel
{
    public string? TwilioAccountSid { get; set; }
    public string? TwilioAuthToken { get; set; }

    public SmsConfiguration(string? twilioAccountSid, string? twilioAuthToken)
    {
        TwilioAccountSid = twilioAccountSid;
        TwilioAuthToken = twilioAuthToken;
    }
}
