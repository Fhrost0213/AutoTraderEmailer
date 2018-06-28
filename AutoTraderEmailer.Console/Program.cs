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
            
            var carModelCode = ConfigurationManager.AppSettings["carModelCode"];
            var carMakeCode = ConfigurationManager.AppSettings["carMakeCode"];
            var startYear = ConfigurationManager.AppSettings["startYear"];
            var endYear = ConfigurationManager.AppSettings["endYear"];

            Console.WriteLine("Pulling car data from AutoTrader.com for " + carMakeCode + " " + carModelCode);

            var puller = new CarListingPuller(new CarListingCriteria
                {
                    endYear = int.Parse(endYear),  
                    startYear = int.Parse(startYear),
                    makeCodeList = (MakeCode)Enum.Parse(typeof(MakeCode), carMakeCode),
                    modelCodeList = (ModelCode)Enum.Parse(typeof(ModelCode), carModelCode),
                    numRecords = 100,
                    sortBy = "relevance",
                    searchRadius = 100,
                    zip = 75098
                }
            );

            var listings = puller.GetListings();

            Console.WriteLine("The API returned " + listings.Count + " listings.");

            var fromAddress = ConfigurationManager.AppSettings["fromAddress"];
            var toAddresses = ConfigurationManager.AppSettings["toAddresses"];

            Console.WriteLine("Emailing the top 10 lowest priced vehicles from " + fromAddress + " to " + toAddresses);

            // TODO: Properly secure this
            var credentials = new NetworkCredential(
                ConfigurationManager.AppSettings["emailCredentialUserName"], // This shouldn't include @gmail
                ConfigurationManager.AppSettings["emailCredentialPassword"]);

            var port = Int32.Parse(ConfigurationManager.AppSettings["emailPort"]);
            var host = ConfigurationManager.AppSettings["emailHost"];

            var email = new EmailBuilder(fromAddress, toAddresses, port, host, carModelCode, listings).Build();

            var emailSender = new EmailSender();
            emailSender.SendEmail(email, credentials);

            Console.WriteLine("Finished.");
        }
    }
}
