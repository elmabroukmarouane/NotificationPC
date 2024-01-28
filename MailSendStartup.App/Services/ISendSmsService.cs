using MailSendStartup.App.Models;

namespace MailSendStartup.App.Services;
internal interface ISendSmsService
{
    Task Send(SmsMessage smsMessage);
}
