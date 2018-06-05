using System.Collections.Generic;
using System.Linq;

namespace AutoTraderEmailer.Core.Email
{
    public class EmailBuilder
    {
        private readonly string _fromAddress;
        private readonly string _toAddress;
        private readonly List<JsonObjects.Listing> _listings;

        public EmailBuilder(string fromAddress, string toAddress, List<JsonObjects.Listing> listings)
        {
            _fromAddress = fromAddress;
            _toAddress = toAddress;
            _listings = listings;
        }

        public Core.Email.Email Build()
        {
            var lowestPrice = _listings.OrderBy(l => l.derivedPrice).First().derivedPrice;

            var email = new Core.Email.Email();
            
            email.ToAddress = _toAddress;
            email.FromAddress = _fromAddress;
            email.EmailSubject = new EmailSubjectCreator(lowestPrice).CreateEmailSubject();

            var topTenListings = _listings.OrderBy(l => l.derivedPrice).Take(10);

            var emailBodyCreator = new EmailBodyCreator(topTenListings);
            email.Body = emailBodyCreator.CreateEmailBody();

            return email;
        }
    }
}
