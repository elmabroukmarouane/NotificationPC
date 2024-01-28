@echo off
schtasks /create /tn "NotificationPcScheduledTask" /tr "C:\Program Files (x86)\MEL-Manuf\Notification PC\MailSendStartup.App.exe" /sc onlogon