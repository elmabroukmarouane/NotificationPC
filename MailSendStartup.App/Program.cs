using MailSendStartup.App.Models;
using MailSendStartup.App.Services;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using MailSendStartup.App.Models.Configuration;
using MailSendStartup.App.Logging;

ServiceProvider serviceProvider = new ServiceCollection()
    .AddLogging((loggingBuilder) => loggingBuilder
        .SetMinimumLevel(LogLevel.Trace))
    .BuildServiceProvider();
var logger = serviceProvider.GetService<ILoggerFactory>()!.CreateLogger<Program>();
var basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
try
{
    using StreamReader streamReader = new(Path.Combine(basePath, "Configuration/Txt/notificationChannel.txt"));
    var notificationChannel = int.Parse(streamReader.ReadToEnd());
    using StreamReader stream = new(Path.Combine(basePath, "Configuration/Txt/applicationIsEnable.txt"));
    var applicationIsEnable = stream.ReadToEnd();
    if(applicationIsEnable == "Yes")
    {
        switch (notificationChannel)
        {
            case 0:
                await SendViaMail();
                break;
            case 1:
                await SendViaSms();
                break;
            case 2:
                await SendViaMail();
                await Task.Delay(TimeSpan.FromMinutes(5));
                await SendViaSms();
                break;
            default: break;
        }
    }
}
catch (Exception ex)
{
    logger.LoggingMessageError("MailSendStartup", "Program", "Main", ex, Path.Combine(AppDomain.CurrentDomain.BaseDirectory));
}
async Task SendViaSms()
{
    using StreamReader streamReader = new(Path.Combine(basePath, "Configuration/Txt/smsLocked.txt"));
    string text = streamReader.ReadToEnd();
    if (text == "No")
    {
        using StreamReader stream = new(Path.Combine(basePath, "Configuration/Json/sms.json"));
        string json = stream.ReadToEnd();
        var jsonStr = JsonSerializer.Deserialize<SmsMessage>(json);
        if (jsonStr != null)
        {
            using StreamReader reader = new(Path.Combine(basePath, "Configuration/Json/smsConfiguration.json"));
            string smsConfigurationString = reader.ReadToEnd();
            var smsConfiguration = JsonSerializer.Deserialize<SmsConfigModel>(smsConfigurationString);
            var sendSmsService = new SendSmsService(logger, smsConfiguration!);
            await sendSmsService.Send(jsonStr);
        }
    }
}
async Task SendViaMail()
{
    using StreamReader streamReader = new(Path.Combine(basePath, "Configuration/Json/mail.json"));
    string json = streamReader.ReadToEnd();
    var jsonStr = JsonSerializer.Deserialize<EmailMessage>(json);
    if (jsonStr != null)
    {
        using StreamReader stream = new(Path.Combine(basePath, "Configuration/Json/emailConfiguration.json"));
        string emailConfigurationString = stream.ReadToEnd();
        var emailConfiguration = JsonSerializer.Deserialize<EmailConfigModel>(emailConfigurationString);
        var sendMailService = new SendMailService(logger, emailConfiguration!);
        await sendMailService.Send(jsonStr);
    }
}
