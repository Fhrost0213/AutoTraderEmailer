using AutoTraderEmailer.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using AutoTraderEmailer.Core.Email;

namespace TraverseSearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fromAddress = ConfigurationManager.AppSettings["fromAddress"];
            var toAddresses = ConfigurationManager.AppSettings["toAddresses"];

            // TODO: Properly secure this
            var credentials = new NetworkCredential(
                ConfigurationManager.AppSettings["emailCredentialUserName"], // This shouldn't include @gmail
                ConfigurationManager.AppSettings["emailCredentialPassword"]);

            var port = Int32.Parse(ConfigurationManager.AppSettings["emailPort"]);
            var host = ConfigurationManager.AppSettings["emailHost"];

            var criteriasPath = ConfigurationManager.AppSettings["carCriteriasFilePath"];

            var criteriaCollection = new XmlSerializer().DeserializeFromPath<CarListingCriteriaCollection>(criteriasPath);

            foreach (var criteria in criteriaCollection.Criterias)
            {
                var carMakeCode = criteria.makeCodeList;
                var carModelCode = criteria.modelCodeList;
 
                Console.WriteLine("Pulling car data from AutoTrader.com for " + carMakeCode + " " + carModelCode);

                var puller = new CarListingPuller(criteria);

                var listings = puller.GetListings();

                Console.WriteLine("The API returned " + listings.Count + " listings.");

                Console.WriteLine("Emailing the top 10 lowest priced vehicles from " + fromAddress + " to " + toAddresses);

                var email = new EmailBuilder(fromAddress, toAddresses, port, host, carModelCode, listings).Build();

                var emailSender = new EmailSender();
                emailSender.SendEmail(email, credentials);
            }

            Console.WriteLine("Finished.");
        }
    }
}
