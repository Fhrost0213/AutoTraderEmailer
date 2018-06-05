namespace AutoTraderEmailer.Core
{
    public class JsonObjects
    {

        public class Rootobject
        {
            public Accelerateviewbean accelerateViewBean { get; set; }
            public string averagePrice { get; set; }
            public string averagePriceLabel { get; set; }
            public string biSearchString { get; set; }
            public Certifiedfiltertileviewbean[] certifiedFilterTileViewBeans { get; set; }
            public string checkWebsite { get; set; }
            public Endusermonitoring endUserMonitoring { get; set; }
            public Filtergroup[] filterGroups { get; set; }
            public string highestPrice { get; set; }
            public string highestPriceLabel { get; set; }
            public Listing[] listings { get; set; }
            public string locationHeading { get; set; }
            public string lowestPrice { get; set; }
            public string lowestPriceLabel { get; set; }
            public string matchListingCount { get; set; }
            public string myAtcSaveSearchString { get; set; }
            public Nosearchresultsviewbean noSearchResultsViewBean { get; set; }
            public Pagination pagination { get; set; }
            public string priceTitle { get; set; }
            public Referencedataviewbean referenceDataViewBean { get; set; }
            public string saveCarInstrText { get; set; }
            public string saveSearchInstrText { get; set; }
            public Searchsummary[] searchSummary { get; set; }
            public Selectedcriteria selectedCriteria { get; set; }
            public bool showAccelerateBanner { get; set; }
            public bool showAccelerateOverlay { get; set; }
            public Srpbrowseviewbean srpBrowseViewBean { get; set; }
            public bool suggestedMakeModelsAvailable { get; set; }
            public string sycUrl { get; set; }
            public string textModalDisclaimer { get; set; }
            public string totalListingCount { get; set; }
            public string windowTitle { get; set; }
            public string targetClass { get; set; }
            public string adProcessor { get; set; }
            public string alternateUrl { get; set; }
            public string canonicalUrl { get; set; }
            public Cobranddataviewbean cobrandDataViewBean { get; set; }
            public Dataisland dataIsland { get; set; }
            public string metaDescription { get; set; }
            public Mvtfeatureparameters mvtFeatureParameters { get; set; }
            public string openGraphDescription { get; set; }
            public string openGraphImage { get; set; }
            public string openGraphSiteName { get; set; }
            public string openGraphType { get; set; }
            public string openGraphUrl { get; set; }
            public Pageleveltargeting pageLevelTargeting { get; set; }
        }

        public class Accelerateviewbean
        {
            public string accelerateBackground1300 { get; set; }
            public string accelerateBackground768 { get; set; }
            public string accelerateBackgroundSrp { get; set; }
            public string accelerateLargeLogoUrl { get; set; }
            public string accelerateLogoUrl { get; set; }
            public string badgeUrl { get; set; }
            public string bannerCtaTxt { get; set; }
            public string bannerTitle { get; set; }
            public string bannerToggleTxt { get; set; }
            public string bannerTxt { get; set; }
            public string[] dmaList { get; set; }
            public string modalLeftButtonTxt { get; set; }
            public string modalRightButtonTxt { get; set; }
            public string modalTitle { get; set; }
            public string modalVideoUrl { get; set; }
        }

        public class Endusermonitoring
        {
            public string RUMBeaconURL { get; set; }
            public bool renderNRBrowser { get; set; }
            public string NRBrowserApplicationId { get; set; }
            public string NRBrowserLicenseKey { get; set; }
            public bool renderRUMBeacon { get; set; }
            public bool performResourceTiming { get; set; }
        }

        public class Nosearchresultsviewbean
        {
        }

        public class Pagination
        {
            public int currentPage { get; set; }
            public int totalPages { get; set; }
        }

        public class Referencedataviewbean
        {
            public Recordsperpageoptions recordsPerPageOptions { get; set; }
            public Searchurl searchURL { get; set; }
            public Sortingoptions sortingOptions { get; set; }
        }

        public class Recordsperpageoptions
        {
            public string _10 { get; set; }
            public string _25 { get; set; }
            public string _50 { get; set; }
            public string _75 { get; set; }
            public string _100 { get; set; }
        }

        public class Searchurl
        {
            public string startNewSearchURL { get; set; }
            public string editSearchURL { get; set; }
        }

        public class Sortingoptions
        {
            public string derivedpriceASC { get; set; }
            public string derivedpriceDESC { get; set; }
            public string distanceASC { get; set; }
            public string mileageASC { get; set; }
            public string mileageDESC { get; set; }
            public string relevance { get; set; }
            public string yearASC { get; set; }
            public string yearDESC { get; set; }
        }

        public class Selectedcriteria
        {
            public string zip { get; set; }
            public string startYear { get; set; }
            public string numRecords { get; set; }
            public string sortBy { get; set; }
            public string firstRecord { get; set; }
            public string endYear { get; set; }
            public string makeCodeList { get; set; }
            public string searchRadius { get; set; }
        }

        public class Srpbrowseviewbean
        {
            public Srpbrowsecitiescriteriaviewbean srpBrowseCitiesCriteriaViewBean { get; set; }
            public Srpbrowsemakescriteriaviewbean srpBrowseMakesCriteriaViewBean { get; set; }
            public Srpbrowseyearsmodelcriteriaviewbean srpBrowseYearsModelCriteriaViewBean { get; set; }
        }

        public class Srpbrowsecitiescriteriaviewbean
        {
            public Allcitiesinstate[] allCitiesInState { get; set; }
            public string listBirfCmp { get; set; }
            public string listTitle { get; set; }
            public Majorcity[] majorCities { get; set; }
        }

        public class Allcitiesinstate
        {
            public string description { get; set; }
            public string link { get; set; }
            public bool offsite { get; set; }
            public string text { get; set; }
            public string textWithoutHTMLTags { get; set; }
        }

        public class Majorcity
        {
            public string description { get; set; }
            public string link { get; set; }
            public bool offsite { get; set; }
            public string text { get; set; }
            public string textWithoutHTMLTags { get; set; }
        }

        public class Srpbrowsemakescriteriaviewbean
        {
            public Alllink[] allLinks { get; set; }
            public string linkBirfCmp { get; set; }
            public string linkTitle { get; set; }
            public string listBirfCmp { get; set; }
            public string listTitle { get; set; }
            public bool makeKnown { get; set; }
            public Popularlink[] popularLinks { get; set; }
        }

        public class Alllink
        {
            public string link { get; set; }
            public string searchParamCode { get; set; }
            public string subText { get; set; }
        }

        public class Popularlink
        {
            public string link { get; set; }
            public string searchParamCode { get; set; }
            public string subText { get; set; }
        }

        public class Srpbrowseyearsmodelcriteriaviewbean
        {
        }

        public class Cobranddataviewbean
        {
        }

        public class Dataisland
        {
            public Page page { get; set; }
        }

        public class Page
        {
            public Site site { get; set; }
            public Location location { get; set; }
            public Vehicle vehicle { get; set; }
            public Owner owner { get; set; }
            public Demographic demographic { get; set; }
            public BIRF BIRF { get; set; }
            public Doubleclick doubleclick { get; set; }
            public Comscore comscore { get; set; }
        }

        public class Site
        {
            public string environment { get; set; }
            public string site { get; set; }
            public string siteVersion { get; set; }
            public string superSection { get; set; }
            public string section { get; set; }
            public string pageName { get; set; }
            public string detailedPageName { get; set; }
            public string atcCookie { get; set; }
            public string myAtcId { get; set; }
            public string myAtc { get; set; }
            public string requestedPage { get; set; }
            public string referringPage { get; set; }
            public string search_lang { get; set; }
            public string deviceType { get; set; }
            public string sessionId { get; set; }
            public string ip { get; set; }
            public string camg_reqid { get; set; }
            public string camg_tranid { get; set; }
        }

        public class Location
        {
            public string address { get; set; }
            public string ipZipCode { get; set; }
            public string dma { get; set; }
            public string distance { get; set; }
        }

        public class Vehicle
        {
            public object[] body_code { get; set; }
            public string car_year { get; set; }
            public string car_id { get; set; }
            public string fuel { get; set; }
            public string[] make { get; set; }
            public string[] model { get; set; }
            public object[] trim { get; set; }
            public string price { get; set; }
            public string search_max_price { get; set; }
            public string search_max_year { get; set; }
            public string search_min_price { get; set; }
            public string search_min_year { get; set; }
            public object[] search_type { get; set; }
            public string Car_Type { get; set; }
            public string search_distance { get; set; }
            public object[] color { get; set; }
            public string chromeStyleId { get; set; }
        }

        public class Owner
        {
            public string dealer_id { get; set; }
            public string seller_type { get; set; }
        }

        public class Demographic
        {
            public string hispanic { get; set; }
        }

        public class BIRF
        {
            public string test_name { get; set; }
            public string test_nme { get; set; }
            public string disableImpressions { get; set; }
            public string browserPrefetch { get; set; }
            public string logDomain { get; set; }
            public string pg_inst { get; set; }
            public string rd_page { get; set; }
            public string pg { get; set; }
            public string lnx { get; set; }
            public string cid { get; set; }
            public string my { get; set; }
            public string ref_url { get; set; }
            public string my_lt { get; set; }
            public string my_id { get; set; }
            public string Log { get; set; }
            public string pdad_ton { get; set; }
            public string pdad_toc { get; set; }
            public string distance { get; set; }
            public string end_year { get; set; }
            public string[] make { get; set; }
            public string[] model { get; set; }
            public string first_rec_num { get; set; }
            public string num_records { get; set; }
            public string pn { get; set; }
            public object[] search_type { get; set; }
            public string ssrp { get; set; }
            public string start_year { get; set; }
            public string tlc { get; set; }
            public string tvc { get; set; }
            public string z { get; set; }
            public string pricesOnly { get; set; }
            public string advanced { get; set; }
            public string nat { get; set; }
            public string geo { get; set; }
            public string spt_pcnt { get; set; }
            public string spt_fcnt { get; set; }
            public string spt_bcnt { get; set; }
        }

        public class Doubleclick
        {
            public Sptlght sptlght { get; set; }
            public Fldlght fldlght { get; set; }
        }

        public class Sptlght
        {
            public string ON { get; set; }
            public string SRC { get; set; }
            public string Type { get; set; }
            public string CAT { get; set; }
            public string ORD { get; set; }
        }

        public class Fldlght
        {
            public string ON { get; set; }
            public string SRC { get; set; }
            public string Type { get; set; }
            public string CAT { get; set; }
            public string ORD { get; set; }
        }

        public class Comscore
        {
            public string c1 { get; set; }
            public string c2 { get; set; }
            public string c3 { get; set; }
            public string c4 { get; set; }
            public string c5 { get; set; }
            public string c6 { get; set; }
            public string c15 { get; set; }
        }

        public class Mvtfeatureparameters
        {
            public string DigitalRetailWidget { get; set; }
            public string showDRLink { get; set; }
            public string sycfreectrl { get; set; }
            public string INLINE_ALPHA_FEATURED_VEHICLE { get; set; }
            public string VIRTUAL_INVENTORY { get; set; }
            public string ownersPathStatic { get; set; }
            public string CPO_LANDING { get; set; }
            public string csFFcntl { get; set; }
            public string EDITORIAL_HOMEPAGE { get; set; }
            public string showLendingTree { get; set; }
            public string DISABLE_VDP_PRODUCTTILES { get; set; }
            public string GIGYA_EMAIL_VERIFICATION { get; set; }
            public string CONTACT_SELLER_FOR_PRICE { get; set; }
            public string RVDP_FIXED_HEADER_OFF { get; set; }
            public string PRICE_ADVISOR_ALL { get; set; }
            public string TURN_OFF_TITLE_AND_TRANSFER { get; set; }
            public string rmGMBDgrpA { get; set; }
            public string AMPHTML_LINK { get; set; }
            public string RSPFctrl { get; set; }
            public string fullscreenMediaViewerAllTypes { get; set; }
            public string agrOff { get; set; }
            public string PIXALL_COOKIE_VALUE_IN_ADS { get; set; }
            public string showPricingDetail { get; set; }
            public string fixedTitle { get; set; }
            public string DISABLE_SRP_LISTING_CPO { get; set; }
            public string PIXALL_OFFOFF_PIXALL { get; set; }
            public string showAccelerate { get; set; }
            public string LAZY_LOAD_ADS { get; set; }
            public string na { get; set; }
            public string atcEXPacc { get; set; }
            public string ENABLE_PREFETCH_DR_VDP { get; set; }
            public string showMakeMyDealWidget { get; set; }
            public string rSP3ctrl { get; set; }
            public string DISABLE_VDP_CPO { get; set; }
            public string REMOVE_GM_CPO { get; set; }
            public string TURN_OFF_PIXALL { get; set; }
            public string showPriceMath { get; set; }
            public string SHOW_PAPD_TILE { get; set; }
            public string INLINE_ALPHA_AD_ABOVE { get; set; }
            public string INLINE_ALPHA { get; set; }
            public string rSRPVDPctrl { get; set; }
            public string improveAlpha { get; set; }
            public string USE_REACT_RESEARCH_LANDING { get; set; }
        }

        public class Pageleveltargeting
        {
            public string tprice { get; set; }
            public string mke { get; set; }
            public string pginst { get; set; }
            public string toc { get; set; }
            public string cert { get; set; }
            public string yrange { get; set; }
            public string type { get; set; }
            public string styr { get; set; }
            public string pkgtyp { get; set; }
            public string bstyl { get; set; }
            public string fprice { get; set; }
            public string btc { get; set; }
            public string ton { get; set; }
            public string reg { get; set; }
            public string cat { get; set; }
            public string azne { get; set; }
            public string zip { get; set; }
            public string st { get; set; }
            public string anml { get; set; }
            public string lng { get; set; }
            public string list { get; set; }
            public string ownid { get; set; }
            public string mdl { get; set; }
            public string series { get; set; }
            public string dma { get; set; }
            public string betagrp { get; set; }
            public string ptnr { get; set; }
            public string eyr { get; set; }
        }

        public class Certifiedfiltertileviewbean
        {
            public string clickTracking { get; set; }
            public string content { get; set; }
            public string imageUrl { get; set; }
            public string impressionTracking { get; set; }
            public string make { get; set; }
            public string overlayImg { get; set; }
            public string primaryButtonText { get; set; }
            public string targetUrl { get; set; }
            public string title { get; set; }
        }

        public class Filtergroup
        {
            public bool collapsed { get; set; }
            public string displayName { get; set; }
            public Filter[] filters { get; set; }
            public Filtersublist[] filterSubList { get; set; }
            public string parameterName { get; set; }
            public bool countDisplayed { get; set; }
        }

        public class Filter
        {
            public bool disabled { get; set; }
            public string name { get; set; }
            public string value { get; set; }
            public int count { get; set; }
            public bool selected { get; set; }
        }

        public class Filtersublist
        {
            public bool disabled { get; set; }
            public string name { get; set; }
            public string value { get; set; }
            public int count { get; set; }
            public bool selected { get; set; }
        }

        public class Listing
        {
            public string birfLstgType { get; set; }
            public string birfParentId { get; set; }
            public string colorExteriorHexValue { get; set; }
            public string colorExteriorSimple { get; set; }
            public string contactEmail { get; set; }
            public string derivedPrice { get; set; }
            public string description { get; set; }
            public bool descriptionHasMore { get; set; }
            public float distanceFromSearch { get; set; }
            public string driveType { get; set; }
            public string emailPopUpUrl { get; set; }
            public string engine { get; set; }
            public string firstPrice { get; set; }
            public int imageCount { get; set; }
            public string imageURL { get; set; }
            public int listingId { get; set; }
            public string listingType { get; set; }
            public string makeCode { get; set; }
            public bool makeMyDealFlag { get; set; }
            public string maxMileage { get; set; }
            public string modelCode { get; set; }
            public int mpgCity { get; set; }
            public int mpgHighway { get; set; }
            public bool newlyListed { get; set; }
            public int ownerId { get; set; }
            public string ownerLogoUrl { get; set; }
            public string ownerName { get; set; }
            public string ownerPhone { get; set; }
            public bool ownerPhoneIsVisible { get; set; }
            public bool ownerPhonePrivate { get; set; }
            public string phonePopUpUrl { get; set; }
            public Pricingdetail pricingDetail { get; set; }
            public string salePrice { get; set; }
            public bool smartPaymentEnabled { get; set; }
            public bool smartPaymentViewable { get; set; }
            public bool startNewTier { get; set; }
            public string stockNumber { get; set; }
            public string tagline1 { get; set; }
            public string tagline2 { get; set; }
            public string tier { get; set; }
            public Tile[] tiles { get; set; }
            public string title { get; set; }
            public string trim { get; set; }
            public bool validPrice { get; set; }
            public string vdpSeoUrl { get; set; }
            public int videoCount { get; set; }
            public string vin { get; set; }
            public Birf1 birf { get; set; }
            public string ownerTextLabel { get; set; }
            public Srpdealerdiffviewbean srpDealerDiffViewBean { get; set; }
            public string winningPaymentOffer { get; set; }
            public string winningPaymentOfferText { get; set; }
            public string winningPaymentOfferDisclaimer { get; set; }
        }

        public class Pricingdetail
        {
            public string assetType { get; set; }
            public bool callForPricingInfoIndicator { get; set; }
            public bool ctaLinkVisible { get; set; }
            public int incentivePrice { get; set; }
            public int msrp { get; set; }
            public int primaryPrice { get; set; }
            public int salePrice { get; set; }
            public int specialOfferCount { get; set; }
            public int cashIncentive { get; set; }
            public int dealerAdjustment { get; set; }
            public Dealerpaymentpreference dealerPaymentPreference { get; set; }
        }

        public class Dealerpaymentpreference
        {
            public bool vdpDisplay { get; set; }
            public bool leaseDisplay { get; set; }
            public string defaultDealType { get; set; }
        }

        public class Birf1
        {
            public string isCertLogo { get; set; }
            public string isCertText { get; set; }
            public string isOwnerChatAvailble { get; set; }
            public string isDescriptionAvailable { get; set; }
            public string isCrossPromoSpecialUrlAvailable { get; set; }
            public string isCrossPromoSpecialUrlNvsAvailable { get; set; }
            public string isCrossPromoSpecialTextAvailable { get; set; }
            public string isOwnerLogoImg { get; set; }
            public string isOwnerLogoText { get; set; }
            public string isSpecialIds { get; set; }
            public string isMileageAvailable { get; set; }
            public string isNewlyListed { get; set; }
            public string isDerivedPrice { get; set; }
            public string isListingImageCountAvailable { get; set; }
            public string isPaymentOfferAvailable { get; set; }
            public string isPriceReduced { get; set; }
            public string isSpecialIdsAvailable { get; set; }
            public string isListingStockImageCountAvailble { get; set; }
            public string isListingVideoCountAvailable { get; set; }
            public string isStockVideoAvailable { get; set; }
            public string lstgType { get; set; }
            public string birfCert { get; set; }
        }

        public class Srpdealerdiffviewbean
        {
            public string contentId { get; set; }
            public bool ctaLinkInternalExternal { get; set; }
            public string tagline { get; set; }
        }

        public class Tile
        {
            public string birfEcommercePartnerName { get; set; }
            public string image { get; set; }
            public string moreInfoURL { get; set; }
            public bool productTileTypeOffsite { get; set; }
            public string text { get; set; }
            public string tileLink { get; set; }
            public bool tileModalViewable { get; set; }
            public bool tilePopupViewable { get; set; }
            public string tileType { get; set; }
            public string birfCommerceTileProduct { get; set; }
            public string thirdPartyImpression { get; set; }
            public int tilePopupHeight { get; set; }
            public int tilePopUpWidth { get; set; }
            public bool tileVdpModeViewable { get; set; }
        }

        public class Searchsummary
        {
            public int displayOrder { get; set; }
            public Filter1[] filters { get; set; }
            public string parameterName { get; set; }
        }

        public class Filter1
        {
            public string displayName { get; set; }
            public string value { get; set; }
        }

    }
}
