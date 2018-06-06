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

            var mail = new MailMessage
            {
                From = new MailAddress(email.FromAddress),
                Subject = email.EmailSubject,
                Body = email.Body
            };
            mail.To.Add(email.ToAddresses);

            client.Send(mail);
        }
    }
}
