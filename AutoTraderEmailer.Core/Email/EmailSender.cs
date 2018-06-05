using System.Net;
using System.Net.Mail;

namespace AutoTraderEmailer.Core.Email
{
    public class EmailSender
    {
        public void SendEmail(Core.Email.Email email, NetworkCredential credentials)
        {
            MailMessage mail = new MailMessage(email.FromAddress, email.ToAddress);
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = "smtp.gmail.com";
            client.Credentials = credentials;
            mail.Subject = email.EmailSubject;
            mail.Body = email.Body;
            client.Send(mail);
        }
    }
}
