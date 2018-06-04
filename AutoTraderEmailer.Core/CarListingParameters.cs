namespace AutoTraderEmailer.Core
{
    public class CarListingParameters
    {
        public int zip { get; set; }
        public int startYear { get; set; }
        public int endYear { get; set; }
        public int numRecords { get; set; }
        public string sortBy { get; set; }
        // TODO: Change to Enum
        public string modelCodeList { get; set; }
        // TODO: Change to Enum
        public string makeCodeList { get; set; }
        public int searchRadius { get; set; }
    }
}
