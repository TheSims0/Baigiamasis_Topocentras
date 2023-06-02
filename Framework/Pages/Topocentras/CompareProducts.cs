using System.Collections.Generic;
namespace Framework.Pages.Topocentras
{
    public class CompareProducts
    {
        public static void Open()
        {
            Driver.OpenPage("https://www.topocentras.lt/");
        }

        public static void CloseCookies()
        {
            Common.Click(Locators.AddToCart.cookies);
        }

        public static void ClickOnProductPage()
        {
            Common.HoverOnElement(Locators.CompareProducts.zaidimuErdve);
            Common.Click(Locators.CompareProducts.zaidimuMonitoriai);
        }

        public static void AddProductsToCompare()
        {
            Common.WaitUntilElementIsVisibleAndClickable(Locators.CompareProducts.addToCompare);
            Common.ClickElementsInList(Locators.CompareProducts.addToCompare);
        }

        public static void GoToComparePage()
        {
            Common.WaitUntilElementIsVisibleAndClickable(Locators.CompareProducts.comparePage);
            Common.Click(Locators.CompareProducts.comparePage);
        }

        public static List<string> GetElementText()
        {
            Common.WaitUntilElementIsVisibleAndClickable(Locators.CompareProducts.productNames);
            return Common.GetElementsTextList(Locators.CompareProducts.productNames);
        }
    }
}
