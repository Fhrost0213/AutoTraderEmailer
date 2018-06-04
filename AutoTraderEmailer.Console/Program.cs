using AutoTraderEmailer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraverseSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var puller = new CarListingPuller(new CarListingParameters
                {
                    EndYear = 2018,  
                    StartYear = 2018,
                    MakeCodeList = "CHEV",
                    ModelCodeList = "TRAVERSE",
                    NumRecords = 100,
                    SortBy = "Relevance",
                    StringRadius = 100,
                    ZipCode = 75098
                }
            );

            puller.GetListings();
        }
    }
}
