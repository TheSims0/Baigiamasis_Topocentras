using Framework.Pages.Topocentras;
using NUnit.Framework;
using Tests.BaseTests;
namespace Tests.Topocentras
{
    internal class TS05_BuyAProduct : BaseTest
    {
        [Test]
        public void TC01_BuyAProductWhileLoggedIn()
        {
            string expectedResult = "Patvirtinti užsakymą";
            BuyingAProduct.Open();
            BuyingAProduct.CloseCookies();
            BuyingAProduct.NavigateToProductPage();
            BuyingAProduct.AddProductToCart();
            BuyingAProduct.GoToCheckOut();
            BuyingAProduct.StartCheckOut();
            BuyingAProduct.LogIn();
            BuyingAProduct.FinishCheckOut();
            string actualResult = BuyingAProduct.CheckIfSubmitOrderReached();
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
