using System.Collections.Generic;
using System.Linq;

namespace AutoTraderEmailer.Core.Email
{
    public class EmailBuilder
    {
        private readonly ModelCode _carModel;
        private readonly string _fromAddress;
        private readonly string _toAddresses;
        private readonly int _port;
        private readonly string _host;
        private readonly List<JsonObjects.Listing> _listings;
        private MakeCode _carMake;
        private string _carTrim;

        public EmailBuilder(string fromAddress, string toAddresses, int port, string host, MakeCode carMake, ModelCode carModel, string carTrim, List<JsonObjects.Listing> listings)
        {
            _fromAddress = fromAddress;
            _toAddresses = toAddresses;
            _listings = listings;
            _port = port;
            _host = host;
            _carMake = carMake;
            _carModel = carModel;
            _carTrim = carTrim;
        }

        public Email Build()
        {
            var lowestPrice = _listings
                .Where(l => l.derivedPrice != null)
                .OrderBy(l => l.derivedPrice)
                .First()
                .derivedPrice;

            var email = new Email
            {
                ToAddresses = _toAddresses,
                FromAddress = _fromAddress,
                EmailSubject = new EmailSubjectCreator(_carMake, _carModel, _carTrim, lowestPrice).CreateEmailSubject(),
                Port = _port,
                Host = _host
            };


            var topListings = _listings.OrderBy(l => l.derivedPrice).Take(10);

            var emailBodyCreator = new EmailBodyCreator(topListings);
            email.Body = emailBodyCreator.CreateEmailBody();

            return email;
        }
    }
}
