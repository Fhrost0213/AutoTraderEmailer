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

            puller.GetListings();
        }
    }
}
