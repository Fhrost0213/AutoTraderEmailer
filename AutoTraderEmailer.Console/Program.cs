using AutoTraderEmailer.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AutoTraderEmailer.Core.Email;

namespace TraverseSearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            var puller = new CarListingPuller(new CarListingParameters
                {
                    endYear = 2018,  
                    startYear = 2018,
                    makeCodeList = "CHEV",
                    modelCodeList = "TRAVERSE",
                    numRecords = 100,
                    sortBy = "relevance",
                    searchRadius = 100,
                    zip = 75098
                }
            );

            var listings = puller.GetListings();

            var fromAddress = ConfigurationManager.AppSettings["fromAddress"];
            var toAddress = ConfigurationManager.AppSettings["toAddress"];

            // TODO: Properly secure this
            var credentials = new NetworkCredential(ConfigurationManager.AppSettings["emailCredentialUserName"],
                ConfigurationManager.AppSettings["emailCredentialPassword"]);

            var email = new EmailBuilder(fromAddress, toAddress, listings).Build();

            var emailSender = new EmailSender();
            emailSender.SendEmail(email, credentials);
        }
    }
}
