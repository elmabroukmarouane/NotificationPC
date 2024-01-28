using MailSendStartup.App.Models;

namespace MailSendStartup.App.Configuration;
public class EmailConfiguration : BaseModel
{
    public string? SmtpServer { get; set; }
    public int SmtpPort { get; set; }
    public string? SmtpUsername { get; set; }
    public string? SmtpPassword { get; set; }
    public bool EnableSsl { get; set; }
    public bool UseDefaultCredentials { get; set; }

    public EmailConfiguration(string? smtpServer, int smtpPort, string? smtpUsername, string? smtpPassword, bool enableSsl, bool useDefaultCredentials)
    {
        SmtpServer = smtpServer;
        SmtpPort = smtpPort;
        SmtpUsername = smtpUsername;
        SmtpPassword = smtpPassword;
        EnableSsl = enableSsl;
        UseDefaultCredentials = useDefaultCredentials;
    }
}
