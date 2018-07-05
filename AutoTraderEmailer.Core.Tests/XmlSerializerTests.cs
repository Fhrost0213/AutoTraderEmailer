using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AutoTraderEmailer.Core.Tests
{
    [TestFixture]
    public class XmlSerializerTests
    {
        [Test]
        public void XmlSerializer_ShouldDeserializeFromString_ToCarListingCriteria()
        {
            // Arrange
            var xmlString = "<CarListingCriterias>\r\n\t<CarListingCriteria>\r\n\t\t<MakeCode>NISSAN</MakeCode>\r\n\t\t<ModelCode>PATH</ModelCode>\r\n\t\t<ZipCode>75098</ZipCode>\r\n\t\t<StartYear>2015</StartYear>\r\n\t\t<EndYear>2018</EndYear>\r\n\t\t<NumberOfRecords>100</NumberOfRecords>\r\n\t\t<SortBy>relevance</SortBy>\r\n\t\t<SearchRadius>100</SearchRadius>\r\n\t</CarListingCriteria>\r\n\t<CarListingCriteria>\r\n\t\t<MakeCode></MakeCode>\r\n\t\t<ModelCode></ModelCode>\r\n\t\t<ZipCode></ZipCode>\r\n\t\t<StartYear></StartYear>\r\n\t\t<EndYear></EndYear>\r\n\t\t<NumberOfRecords></NumberOfRecords>\r\n\t\t<SortBy></SortBy>\r\n\t\t<SearchRadius></SearchRadius>\r\n\t</CarListingCriteria>\r\n</CarListingCriterias>";
            var sut = new AutoTraderEmailer.Core.XmlSerializer();


            // Act
            var criteria = sut.DeserializeFromString<CarListingCriteria>(xmlString);

            // Assert
            Assert.That(criteria.makeCodeList == MakeCode.NISSAN);
        }
    }  
}
