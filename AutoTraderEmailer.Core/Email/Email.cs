namespace AutoTraderEmailer.Core.Email
{
    public class Email
    {
        public string EmailSubject { get; set; }
        public string ToAddresses { get; set; }
        public string FromAddress { get; set; }
        public string Body { get; set; }
        public int Port { get; set; }
        public string Host { get; set; }
    }
}
