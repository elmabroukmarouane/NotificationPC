namespace MailSendStartup.App.Models.Configuration;
public class SmsConfigModel : BaseModel
{
    public string? TwilioAccountSid { get; set; }
    public string? TwilioAuthToken { get; set; }
}
