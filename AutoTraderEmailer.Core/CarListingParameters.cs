namespace AutoTraderEmailer.Core
{
    public class CarListingParameters
    {
        public int ZipCode { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public int NumRecords { get; set; }
        public string SortBy { get; set; }
        // TODO: Change to Enum
        public string ModelCodeList { get; set; }
        // TODO: Change to Enum
        public string MakeCodeList { get; set; }
        public int StringRadius { get; set; }
    }
}
