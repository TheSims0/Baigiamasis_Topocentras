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
            string expectedResult = "4";

            AddToCart.ClickOnProduct();
            AddToCart.AddProductsToCart();
            AddToCart.GoToCart();
            string actualResult = AddToCart.GetTotalProducts();
            
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
