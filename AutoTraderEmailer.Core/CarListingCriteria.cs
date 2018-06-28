namespace AutoTraderEmailer.Core
{
    public class CarListingCriteria
    {
        public int zip { get; set; }
        public int startYear { get; set; }
        public int endYear { get; set; }
        public int numRecords { get; set; }
        public string sortBy { get; set; }
        public ModelCode modelCodeList { get; set; }
        public MakeCode makeCodeList { get; set; }
        public int searchRadius { get; set; }
    }
}
