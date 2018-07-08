using System;

namespace AutoTraderEmailer.Core.Email
{
    public class EmailSubjectCreator
    {
        private readonly string _lowestPrice;
        private readonly ModelCode _carModel;
        private MakeCode _carMake;
        private string _carTrim;

        public EmailSubjectCreator(MakeCode makeCode, ModelCode carModel, string trim, string lowestPrice)
        {
            _lowestPrice = lowestPrice;
            _carMake = makeCode;
            _carModel = carModel;
            _carTrim = trim;
        }

        public string CreateEmailSubject()
        {
            return _carMake.GetDescription() + " " + _carModel.GetDescription() + " " + _carTrim + " - Cheapest Is " + _lowestPrice;
        }
    }
}
