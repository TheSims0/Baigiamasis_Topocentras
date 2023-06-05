using Framework.Pages.Topocentras;
using NUnit.Framework;
using System.Collections.Generic;
using Tests.BaseTests;
namespace Tests.Topocentras
{
    internal class TS03_CompareProducts : BaseTest
    {
        [Test]
        public void TC01_CompareThreeProducts()
        {
            CompareProducts.ClickOnProductPage();
            CompareProducts.AddProductsToCompare();
            CompareProducts.GoToComparePage();
            List<string> productNames = CompareProducts.GetElementText();

            Assert.That(productNames, Is.Unique);
        }
    }
}
