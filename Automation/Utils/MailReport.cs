using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Utils
{
    class MailReport
    {
        public void Send_Report_In_Mail()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("sender_mail_address");
            mail.To.Add("mail_lists_of_recipients");

            StringBuilder TimeAndDate = new StringBuilder(DateTime.Now.ToString());
            TimeAndDate.Replace("/", "_");
            TimeAndDate.Replace(":", "_");

            mail.Subject = "Automation Test Report_"+TimeAndDate;

            mail.Body = "Please find the attached report to get details.";

            string actualPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\Test_Execution_Report"); //Reports should store in Test_Execution_Reports folder

            var mostRecentlyModified = Directory.GetFiles(actualPath, "*.html")
            .Select(f => new FileInfo(f))
            .OrderByDescending(fi => fi.LastWriteTime)
            .First()
            .FullName;

            Attachment attachment;
            attachment = new Attachment(mostRecentlyModified);
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("sender_mail_address", "sender_mail_account_password");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }
    }
}
