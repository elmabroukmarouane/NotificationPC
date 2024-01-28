' CustomAction.vbs
Set objShell = CreateObject("WScript.Shell")
objShell.Run "cmd.exe /c ""C:\Program Files (x86)\MEL-Manuf\Notification PC\Batch\NotificationPcScheduledTask.bat""", 0, True
Set objShell = Nothing
