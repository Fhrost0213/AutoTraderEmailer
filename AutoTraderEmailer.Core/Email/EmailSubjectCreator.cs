namespace AutoTraderEmailer.Core.Email
{
    public class EmailSubjectCreator
    {
        private readonly string _lowestPrice;
        private readonly string _carModel;

        public EmailSubjectCreator(string carModel, string lowestPrice)
        {
            _lowestPrice = lowestPrice;
            _carModel = carModel;
        }

        public string CreateEmailSubject()
        {
            return _carModel + " - Cheapest Is " + _lowestPrice;
        }
    }
}
