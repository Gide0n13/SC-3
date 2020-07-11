using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.IO.Packaging;

namespace WpfMailSender.Model
{
    public class EMailInfo
    {
        public string SmtpClient { get; set; }
        public int Port { get; set; } 
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Sender { get; set; } 
        public string Password { get; set; }
        public string From { get; set; }
        public string To { get; set; }

        public EMailInfo(string smtpClient, int port, string subject, string body, string sender, 
            string password, string from, string to)
        {
            SmtpClient = smtpClient;
            Port = port;
            Subject = subject;
            Body = body;
            Sender = sender;
            Password = password;
            From = from;
            To = to;
        }
    }


    class EMailSendService
    {
        public string Status { get; private set; } = "OK";
        public string ErrorInfo { get; private set; } = "";

        public bool Send(EMailInfo eMailInfo)
        {
            MailMessage mm = new MailMessage(eMailInfo.From, eMailInfo.To);
            mm.Subject = eMailInfo.Subject;
            mm.Body = eMailInfo.Body;
            mm.IsBodyHtml = false;

            SmtpClient sc = new SmtpClient(eMailInfo.SmtpClient, eMailInfo.Port);
            sc.EnableSsl = true;
            sc.DeliveryMethod = SmtpDeliveryMethod.Network;
            sc.UseDefaultCredentials = false;
            sc.Credentials = new NetworkCredential(eMailInfo.Sender, eMailInfo.Password);
            try
            {
                sc.Send(mm);
            }
            catch (Exception exc)
            {
                Status = exc.Message;
                ErrorInfo = exc.StackTrace;
                return false;
            }
            Status = "OK";
            return true;
        }



        public bool SendAll(EMailInfo eMailInfo, string To)
        {
            MailMessage mm = new MailMessage(eMailInfo.From, To);
            mm.Subject = eMailInfo.Subject;
            mm.Body = eMailInfo.Body;
            mm.IsBodyHtml = false;

            SmtpClient sc = new SmtpClient(eMailInfo.SmtpClient, eMailInfo.Port);
            sc.EnableSsl = true;
            sc.DeliveryMethod = SmtpDeliveryMethod.Network;
            sc.UseDefaultCredentials = false;
            sc.Credentials = new NetworkCredential(eMailInfo.Sender, eMailInfo.Password);
            try
            {
                sc.Send(mm);
            }
            catch (Exception exc)
            {
                Status = exc.Message;
                ErrorInfo = exc.StackTrace;
                return false;
            }
            Status = "OK";
            return true;
        }
    }
}
