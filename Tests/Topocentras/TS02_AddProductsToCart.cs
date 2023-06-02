using Framework.Pages.Topocentras;
using NUnit.Framework;
using Tests.BaseTests;
namespace Tests.Topocentras
{
    internal class TS02_AddProductsToCart : BaseTest
    {
        [Test]
        public void TC01_AddProductsToCart()
        {
            AddToCart.Open();
            AddToCart.CloseCookies();
            AddToCart.ClickOnProduct();
            AddToCart.AddProductsToCart();
            AddToCart.GoToCart();
            string actualResult = AddToCart.GetTotalProducts();
            string expectedResult = "4";
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
