using System.Collections.Generic;
using System.Text;

namespace AutoTraderEmailer.Core.Email
{
    public class EmailBodyCreator
    {
        private readonly IEnumerable<JsonObjects.Listing> _listings;

        public EmailBodyCreator(IEnumerable<JsonObjects.Listing> listings)
        {
            _listings = listings;
        }

        public string CreateEmailBody()
        {
            var sb = new StringBuilder();

            foreach (var listing in _listings)
            {
                sb.AppendLine("Price: " + listing.derivedPrice);
                sb.AppendLine("Mileage: " + listing.maxMileage);
                sb.AppendLine("Condition: " + listing.listingType);
                sb.AppendLine("Color: " + listing.colorExteriorSimple);
                sb.AppendLine("Image URL: " + listing.imageURL);
                sb.AppendLine("");
            }

            return sb.ToString();
        }
    }
}
