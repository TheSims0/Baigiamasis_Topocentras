namespace Framework.Pages.Topocentras
{
    internal static class Locators
    {
        internal static class Login
        {
            internal static string prisijungti = "//*[@id='root']/header[1]/div[1]/div[1]/div[2]/button";
            internal static string enterEmail = "//*[@id='username']";
            internal static string enterPassword = "//*[@id='password']";
            internal static string prisijungtiInLoginMenu = "//*[@id='modal']/div[1]/div[2]/div/form/button";
            internal static string manoPaskyra = "//*[@id='root']/header[1]/div[1]/div[1]/div[2]/div/a";
            internal static string readUserName = "//*[@id='root']/main/div/div/div/h1";
        }

        internal static class AddToCart
        {
            internal static string butineTechnika = "(//*[@class='DesktopMenu-tabUrl-26S'])[2]";
            internal static string kaitlentes = "//*[@id='desktopMenu']/ul/li[1]/div/ul[3]/section[2]/h5[2]";
            internal static string addToCart = "(//*[@data-test-id='add-to-cart-btn'])[position()>=1 and position()<=4]";
            internal static string cookies = "//*[@class='CookieConsent-actions-F41']";
            internal static string goToCart = "(//*[@class='Cart-checkoutLink-1fD'])[1]";
            internal static string totalProducts = "//*[@class='Products-productInfoContainer-1yU']";
            internal static string closePopUp = "//*[@class='Modal-closeButton-Ri_']";
        }

        internal static class CompareProducts
        {
            internal static string zaidimuErdve = "//*[@id='desktopMenu']/ul/li[1]/div/ul[1]/li[6]/a";
            internal static string zaidimuMonitoriai = "//*[@id='desktopMenu']/ul/li[1]/div/ul[7]/section[1]/ul[1]/li[6]/a";
            internal static string addToCompare = "(//*[@class='ProductGridItem-compareContainer--7d'])[position()>=1 and position()<=3]";
            internal static string comparePage = "//*[@class='CompareModal-button-2EU']";
            internal static string productNames = "(//*[@class='TableHeaderItem-productTitle-2pf'])[position()>=4 and position()<=6]";
        }

        internal static class LeaveAReview
        {
            internal static string televizoriai = "(//*[@class='DesktopMenu-tabUrl-26S'])[3]";
            internal static string lGTelevizoriai = "(//*[@class='DesktopMenu-menuChildUrl-Fso'])[2]";
            internal static string lGProduct = "(//*[@class='ProductGridItem-link-3xD'])[1]";
            internal static string reviewButton = "//*[@id='BVRRContainer']/div/div/div/div/div[1]/div[1]/div/button";
            internal static string starRating = "//*[@id='bv-radio-rating-5']/span[1]";
            internal static string antraste = "//*[@id='bv-text-field-title']";
            internal static string apzvalga = "//*[@id='bv-textarea-field-reviewtext']";
            internal static string rekomendacija = "//*[@id='bv-radio-isrecommended-true-label']";
            internal static string kokybe = "//*[@id='bv-radio-rating_Quality-5']/span[1]";
            internal static string verte = "//*[@id='bv-radio-rating_Value-5']/span[1]";
            internal static string vardas = "//*[@id='bv-text-field-usernickname']";
            internal static string elpastas = "//*[@id='bv-email-field-hostedauthentication_authenticationemail']";
            internal static string nuostatai = "//*[@id='bv-checkbox-reviews-termsAndConditions']";
            internal static string submitReview = "//*[@name='bv-submit-button']";
            internal static string reviewResult = "//*[@id='bv-mbox-label-text']";
        }

        internal static class BuyingAProduct
        {
            internal static string homePage = "(//*[@class='Logo-logoWrapper-3GQ'])[1]";
            internal static string telefonai = "(//*[@data-test-id='dropdown-menu-item'])[5]";
            internal static string onePlus = "//*[@id='desktopMenu']/ul/li[1]/div/ul[6]/section[1]/ul[1]/li[6]/a";
            internal static string prodcutToBuy = "(//*[@class='ProductGridItem-productContainer-1RY'])[1]";
            internal static string addToCart = "(//*[@data-test-id='add-to-cart-btn'])[1]";
            internal static string buyAfterCart = "//*[@data-test-id='add-to-cart-modal-checkout-btn']";
            internal static string buyButton = "//*[@data-test-id='checkout-btn']";
            internal static string firstName = "//*[@data-test-id='firstname']";
            internal static string lastName = "//*[@data-test-id='lastname']";
            internal static string phoneNumber = "//*[@data-test-id='telephone']";
            internal static string topoFlex = "//*[@id=\"root\"]/div[1]/main/div[1]/div[3]/ul/div";
            internal static string prisijungti = "//*[@data-test-id='checkout-login-btn']";
            internal static string username = "//*[@data-test-id='username']";
            internal static string password = "//*[@data-test-id='password']";
            internal static string confirmLogIn = "//*[@data-test-id='login-btn']";
            internal static string shipping = "//*[@data-test-id='submit-user-details']";
            internal static string selectCity = "//*[@data-test-id='select-city']";
            internal static string selectShop = "(//*[@data-test-id='department-option'])[1]";
            internal static string apmokejimas = "//*[@data-test-id='submit-shipping-details']";
            internal static string paymentMethod = "(//*[@data-test-id='payment-option'])[1]";
            internal static string review = "//*[@data-test-id='submit-payment-method']";
            internal static string submitOrder = "//*[@data-test-id='submit-order']";
        }
    }
}
