using Microsoft.Extensions.Logging;
using Twilio.Rest.Api.V2010.Account;

namespace MailSendStartup.App.Logging; 
public static class LoggingMessaging
{
    public static void LoggingMessageError(this ILogger self, string nameSpaceName, string serviceName, string actionName, Exception exception, string pathRootApp)
    {
        var log = "[" + LogLevel.Error + "]" + " [" + DateTimeOffset.UtcNow.ToString("dd/MM/yyyy HH:mm:ss+00:00") + "] [" + nameSpaceName + "." + serviceName + "." + actionName + "]: Exception => " + exception + " : " + exception.Message;
        WriteLog(log, pathRootApp);
        self.LogError(log);
    }
    public static void LoggingMessageInfo(this ILogger self, string nameSpaceName, string serviceName, string actionName, MessageResource.StatusEnum statusEnum, string pathRootApp)
    {
        var log = "[" + LogLevel.Error + "]" + " [" + DateTimeOffset.UtcNow.ToString("dd/MM/yyyy HH:mm:ss+00:00") + "] [" + nameSpaceName + "." + serviceName + "." + actionName + "]: StatusEnum => " + statusEnum;
        WriteLog(log, pathRootApp);
        self.LogInformation(log);
    }

    private static void WriteLog(string log, string pathRootApp)
    {
        var directoryPath = Path.Combine(pathRootApp, "Log");
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }
        var fullPathLog = Path.Combine(directoryPath, "Log_" + DateTimeOffset.UtcNow.ToString("ddMMyyyy") + ".log");
        using (var streamWriter = new StreamWriter(fullPathLog, true))
        {
            streamWriter.WriteLine(log);
            streamWriter.WriteLine("---------------------------------------------------------------------------------------------------------------------");
        }
    }
}
