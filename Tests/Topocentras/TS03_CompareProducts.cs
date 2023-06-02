using Framework.Pages.Topocentras;
using NUnit.Framework;
using Tests.BaseTests;
namespace Tests.Topocentras
{
    internal class TS03_CompareProducts : BaseTest
    {
        [Test]
        public void TC01_CompareThreeProducts()
        {
            CompareProducts.Open();
            CompareProducts.CloseCookies();
            CompareProducts.ClickOnProductPage();
            CompareProducts.AddProductsToCompare();
            CompareProducts.GoToComparePage();
            Assert.That(CompareProducts.GetElementText(), Is.Unique);
        }
    }
}
