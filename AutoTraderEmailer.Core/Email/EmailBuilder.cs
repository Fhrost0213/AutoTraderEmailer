using System.Collections.Generic;
using System.Linq;

namespace AutoTraderEmailer.Core.Email
{
    public class EmailBuilder
    {
        private readonly string _carModel;
        private readonly string _fromAddress;
        private readonly string _toAddress;
        private readonly int _port;
        private readonly string _host;
        private readonly List<JsonObjects.Listing> _listings;

        public EmailBuilder(string fromAddress, string toAddress, int port, string host, string carModel, List<JsonObjects.Listing> listings)
        {
            _fromAddress = fromAddress;
            _toAddress = toAddress;
            _listings = listings;
            _port = port;
            _host = host;
            _carModel = carModel;
        }

        public Email Build()
        {
            var lowestPrice = _listings.OrderBy(l => l.derivedPrice).First().derivedPrice;

            var email = new Email
            {
                ToAddress = _toAddress,
                FromAddress = _fromAddress,
                EmailSubject = new EmailSubjectCreator(_carModel, lowestPrice).CreateEmailSubject(),
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
