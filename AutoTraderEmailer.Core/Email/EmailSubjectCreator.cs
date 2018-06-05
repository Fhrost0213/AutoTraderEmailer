namespace AutoTraderEmailer.Core.Email
{
    public class EmailSubjectCreator
    {
        private string _lowestPrice;

        public EmailSubjectCreator(string lowestPrice)
        {
            _lowestPrice = lowestPrice;
        }

        public string CreateEmailSubject()
        {
            return "Traverses - Cheapest Is " + _lowestPrice;
        }
    }
}
