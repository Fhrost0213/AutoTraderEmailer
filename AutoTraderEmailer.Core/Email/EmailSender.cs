using System.Net;
using System.Net.Mail;

namespace AutoTraderEmailer.Core.Email
{
    public class EmailSender
    {
        public void SendEmail(Email email, NetworkCredential credentials)
        {
            var client = new SmtpClient
            {
                Port = email.Port,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = email.Host,
                Credentials = credentials,
                EnableSsl = true
            };

            var mail = new MailMessage(email.FromAddress, email.ToAddress)
            {
                Subject = email.EmailSubject,
                Body = email.Body
            };

            client.Send(mail);
        }
    }
}
