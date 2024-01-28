using MailSendStartup.App.Configuration;
using MailSendStartup.App.Helpers;
using MailSendStartup.App.Logging;
using MailSendStartup.App.Models;
using MailSendStartup.App.Models.Configuration;
using Microsoft.Extensions.Logging;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace MailSendStartup.App.Services
{
    internal class SendSmsService : ISendSmsService
    {
        #region Attributes
        private readonly ILogger _logger;
        private readonly SmsConfiguration _smsConfiguration;
        #endregion

        public SendSmsService(ILogger logger, SmsConfigModel smsConfigModel)
        {
            _logger = logger;
            _smsConfiguration = new(smsConfigModel.TwilioAccountSid, smsConfigModel.TwilioAuthToken);
        }
        public async Task Send(SmsMessage smsMessage)
        {
            try
            {
                TwilioClient.Init(_smsConfiguration.TwilioAccountSid!, _smsConfiguration.TwilioAuthToken!);
                var messageResource = await MessageResource.CreateAsync(
                    to: new Twilio.Types.PhoneNumber(smsMessage.ToPhoneNumber!),
                    from: new Twilio.Types.PhoneNumber(smsMessage.FromPhoneNumber!),
                    body: smsMessage.Content!.Replace("__EMO_OPENED_DATE__", DateTime.Now.ToString(Helper.FormatDate)).Replace("__EMO_PC_NAME__", Environment.MachineName)
                    );
                const int amountOfPollingAttempts = 20;
                for (var i = 0; i < amountOfPollingAttempts; i++)
                {
                    messageResource = await MessageResource.FetchAsync(messageResource.Sid);
                    if (messageResource.Status == MessageResource.StatusEnum.Delivered)
                    {
                        _logger.LoggingMessageInfo("MailSendStartup.App.Services", "SendSmsService", "Send", messageResource.Status, Path.Combine(AppDomain.CurrentDomain.BaseDirectory));
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LoggingMessageError("MailSendStartup.App.Services", "SendSmsService", "Send", ex, Path.Combine(AppDomain.CurrentDomain.BaseDirectory));
            }
        }
    }
}
