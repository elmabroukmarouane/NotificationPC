namespace MailSendStartup.App.Models;
public class EmailMessage : BaseModel
{
    public IList<EmailAddress>? ToAddresses { get; set; }
    public IList<EmailAddress>? FromAddresses { get; set; }
    public string? Subject { get; set; }
    public string? Content { get; set; }
}