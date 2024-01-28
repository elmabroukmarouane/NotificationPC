namespace MailSendStartup.App.Models;
public class SmsMessage : BaseModel
{
    public string? FromPhoneNumber { get; set; }
    public string? ToPhoneNumber { get; set; }
    public string? Content { get; set; }
}
