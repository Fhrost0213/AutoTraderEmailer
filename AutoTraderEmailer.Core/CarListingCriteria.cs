using System;
using System.Xml.Serialization;

namespace AutoTraderEmailer.Core
{
    [Serializable]
    public class CarListingCriteria
    {
        [XmlElement(ElementName = "ZipCode")]
        public int zip { get; set; }
        [XmlElement(ElementName = "StartYear")]
        public int startYear { get; set; }
        [XmlElement(ElementName = "EndYear")]
        public int endYear { get; set; }
        [XmlElement(ElementName = "NumberOfRecords")]
        public int numRecords { get; set; }
        [XmlElement(ElementName = "SortBy")]
        public string sortBy { get; set; }
        [XmlElement(ElementName = "ModelCode")]
        public ModelCode modelCodeList { get; set; }
        [XmlElement(ElementName = "MakeCode")]
        public MakeCode makeCodeList { get; set; }
        [XmlElement(ElementName = "SearchRadius")]
        public int searchRadius { get; set; }
        [XmlElement(ElementName = "MaxMileage")]
        public int maxMileage { get; set; }
        [XmlElement(ElementName = "TrimCode")]
        public string trimCodeList { get; set; }
    }
}
