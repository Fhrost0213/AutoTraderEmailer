using System;
using System.Xml.Serialization;

namespace AutoTraderEmailer.Core
{
    [Serializable]
    [XmlRoot("CarListingCriteriaCollection")]
    public class CarListingCriteriaCollection
    {
        [XmlArray("CarListingCriterias")]
        [XmlArrayItem("CarListingCriteria", typeof(CarListingCriteria))]
        public CarListingCriteria[] Criterias { get; set; }
    }
}
