namespace Framework.Pages.Topocentras
{
    public class AddToCart
    {
        public static void Open()
        {
            Driver.OpenPage("https://www.topocentras.lt/");
        }

        public static void ClickOnProduct()
        {
            Common.HoverOnElement(Locators.AddToCart.butineTechnika);
            Common.Click(Locators.AddToCart.kaitlentes);
        }

        public static void AddProductsToCart()
        {
            Common.WaitUntilElementIsVisibleAndClickable(Locators.AddToCart.addToCart);
            Common.ScrollUntilElementIsClickable(Locators.AddToCart.addToCart);
            Common.ClickElementsInListAndClosePopUp(Locators.AddToCart.addToCart, Locators.AddToCart.closePopUp);
        }

        public static void CloseCookies()
        {
            Common.Click(Locators.AddToCart.cookies);
        }

        public static void GoToCart()
        {
            Common.ScrollUntilElementIsClickable(Locators.AddToCart.goToCart);
            Common.Click(Locators.AddToCart.goToCart);
        }

        public static string GetTotalProducts()
        {
            Common.WaitUntilElementIsVisibleAndClickable(Locators.AddToCart.totalProducts);
            return Common.CountElements(Locators.AddToCart.totalProducts);
        }
    }
}
