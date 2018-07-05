namespace AutoTraderEmailer.Core.Email
{
    public class EmailSubjectCreator
    {
        private readonly string _lowestPrice;
        private readonly ModelCode _carModel;

        public EmailSubjectCreator(ModelCode carModel, string lowestPrice)
        {
            _lowestPrice = lowestPrice;
            _carModel = carModel;
        }

        public string CreateEmailSubject()
        {
            return _carModel.ToString() + " - Cheapest Is " + _lowestPrice;
        }
    }
}
