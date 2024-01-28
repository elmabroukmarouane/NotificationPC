using MailSendStartup.App.Models;
using MailSendStartup.App.Configuration;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using Microsoft.Extensions.Logging;
using MailSendStartup.App.Logging;
using MailSendStartup.App.Models.Configuration;
using MailSendStartup.App.Helpers;

namespace MailSendStartup.App.Services;
internal class SendMailService : ISendMailService
{
    #region Attributes
    private readonly ISmtpClient _smtpClient;
    private readonly ILogger _logger;
    private readonly EmailConfiguration _emailConfiguration;
    #endregion

    public SendMailService(ILogger logger, EmailConfigModel emailConfigModel)
    {
        _logger = logger;
        _smtpClient = new SmtpClient();
        _emailConfiguration = new(emailConfigModel.SmtpServer, emailConfigModel.SmtpPort, emailConfigModel.SmtpUsername, emailConfigModel.SmtpPassword, emailConfigModel.EnableSsl, emailConfigModel.UseDefaultCredentials);
    }
    public async Task Send(EmailMessage emailMessage)
    {
        try
        {
            var message = new MimeMessage();
            message.To.AddRange(emailMessage.ToAddresses?.Select(x => new MailboxAddress(x.Name, x.Address)));
            message.From.AddRange(emailMessage.FromAddresses?.Select(x => new MailboxAddress(x.Name, x.Address)));
            message.Subject = emailMessage.Subject!.Replace("__EMO_OPENED_DATE__", DateTime.Now.ToString(Helper.FormatDate)).Replace("__EMO_PC_NAME__", Environment.MachineName);
            var textPart = new TextPart(TextFormat.Html)
            {
                Text = emailMessage.Content!.Replace("__EMO_OPENED_DATE__", DateTime.Now.ToString(Helper.FormatDate)).Replace("__EMO_PC_NAME__", Environment.MachineName)
            };
            var multipart = new Multipart()
            {
                textPart
            };
            message.Body = multipart;
            _smtpClient.ServerCertificateValidationCallback = (s, c, h, e) => true;
            await _smtpClient.ConnectAsync(_emailConfiguration.SmtpServer, _emailConfiguration.SmtpPort, SecureSocketOptions.Auto);
            await _smtpClient.AuthenticateAsync(_emailConfiguration.SmtpUsername, _emailConfiguration.SmtpPassword);
            await _smtpClient.SendAsync(message);
            await _smtpClient.DisconnectAsync(true);
        }
        catch (Exception ex)
        {
            _logger.LoggingMessageError("MailSendStartup.App.Services", "SendMailService", "Send", ex, Path.Combine(AppDomain.CurrentDomain.BaseDirectory));
        }
    }
}
