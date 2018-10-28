using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Infrastructure.Utility
{
    public static class MailUtilities
    {
        public static bool IsValid(string email)
        {
            return Regex.IsMatch(email,
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
        }

        public static void SendMail(MailMessage message)
        {
            message.From = new MailAddress("estudia@itu.local");

            SmtpClient SmtpServer = new SmtpClient("localhost");
            SmtpServer.Port = 25;
            SmtpServer.Credentials = new System.Net.NetworkCredential("estudia@itu.local", "ituitu");
            SmtpServer.EnableSsl = false;

            SmtpServer.Send(message);
        }

        public static Task SendMailAsync(MailMessage message)
        {
            message.From = new MailAddress("informatech@itu.local");

            SmtpClient SmtpServer = new SmtpClient("localhost");
            SmtpServer.Port = 25;
            SmtpServer.Credentials = new System.Net.NetworkCredential("informatech@itu.local", "ituitu");
            SmtpServer.EnableSsl = false;

            return SmtpServer.SendMailAsync(message);
        }
    }
}
