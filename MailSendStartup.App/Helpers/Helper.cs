namespace MailSendStartup.App.Helpers;
public class Helper
{
    public static string FormatDate
    {
        get
        {
            return "dddd dd MMMM yyyy 'at' HH':'mm 'and' ss's'"; // FR FORMAT : "dddd dd MMMM yyyy 'à' HH'h'mm 'et' ss's'"
        }
    }
}
