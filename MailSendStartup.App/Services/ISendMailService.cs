using MailSendStartup.App.Models;

namespace MailSendStartup.App.Services;
internal interface ISendMailService
{
    Task Send(EmailMessage emailMessage);
}
