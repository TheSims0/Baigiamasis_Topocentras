namespace Framework.Pages.Topocentras
{
    public class BuyingAProduct
    {
        public static void Open()
        {
            Driver.OpenPage("https://www.topocentras.lt/");
        }

        public static void CloseCookies()
        {
            Common.Click(Locators.AddToCart.cookies);
        }

        public static void NavigateToProductPage()
        {
            Common.WaitUntilElementIsVisibleAndClickable(Locators.BuyingAProduct.telefonai);
            Common.HoverOnElement(Locators.BuyingAProduct.telefonai);
            Common.WaitUntilElementIsVisibleAndClickable(Locators.BuyingAProduct.onePlus);
            Common.Click(Locators.BuyingAProduct.onePlus);
            Common.WaitUntilElementIsVisibleAndClickable(Locators.BuyingAProduct.prodcutToBuy);
            Common.Click(Locators.BuyingAProduct.prodcutToBuy);
        }

        public static void LogIn()
        {
            Common.WaitUntilElementIsVisibleAndClickable(Locators.BuyingAProduct.prisijungti);
            Common.Click(Locators.BuyingAProduct.prisijungti);
            Common.WaitUntilElementIsVisibleAndClickable(Locators.BuyingAProduct.username);
            Common.SendKeys(Locators.BuyingAProduct.username, "baigiamasisms2023@gmail.com");
            Common.SendKeys(Locators.BuyingAProduct.password, "Nesakysiu123@");
            Common.Click(Locators.BuyingAProduct.confirmLogIn);
        }

        public static void AddProductToCart()
        {
            Common.WaitUntilElementIsVisibleAndClickable(Locators.BuyingAProduct.addToCart);
            Common.Click(Locators.BuyingAProduct.addToCart);
        }

        public static void GoToCheckOut()
        {
            Common.WaitUntilElementIsVisibleAndClickable(Locators.BuyingAProduct.buyAfterCart);
            Common.Click(Locators.BuyingAProduct.buyAfterCart);
        }

        public static void StartCheckOut()
        {
            Common.WaitUntilElementIsVisibleAndClickable(Locators.BuyingAProduct.topoFlex);
            Common.ScrollUntilElementIsClickable(Locators.BuyingAProduct.buyButton);
            Common.Click(Locators.BuyingAProduct.buyButton);
        }

        public static void FinishCheckOut()
        {
            Common.WaitUntilElementIsVisibleAndClickable(Locators.BuyingAProduct.firstName);
            Common.SendKeys(Locators.BuyingAProduct.firstName, "Ponas");
            Common.SendKeys(Locators.BuyingAProduct.lastName, "Testuotojas");
            Common.SendKeys(Locators.BuyingAProduct.phoneNumber, "61234567");
            Common.WaitUntilElementIsVisibleAndClickable(Locators.BuyingAProduct.shipping);
            Common.Click(Locators.BuyingAProduct.shipping);
            Common.WaitUntilElementIsVisibleAndClickable(Locators.BuyingAProduct.selectCity);
            Common.SelectElementInDropDownMenu(Locators.BuyingAProduct.selectCity, 2);
            Common.Click(Locators.BuyingAProduct.selectShop);
            Common.WaitUntilElementIsVisibleAndClickable(Locators.BuyingAProduct.apmokejimas);
            Common.Click(Locators.BuyingAProduct.apmokejimas);
            Common.WaitUntilElementIsVisibleAndClickable(Locators.BuyingAProduct.paymentMethod);
            Common.Click(Locators.BuyingAProduct.paymentMethod);
            Common.WaitUntilElementIsVisibleAndClickable(Locators.BuyingAProduct.review);
            Common.Click(Locators.BuyingAProduct.review);
        }

        public static string CheckIfSubmitOrderReached()
        {
            Common.WaitUntilElementIsVisibleAndClickable(Locators.BuyingAProduct.submitOrder);
            return Common.GetElementText(Locators.BuyingAProduct.submitOrder);
        }
    }
}
