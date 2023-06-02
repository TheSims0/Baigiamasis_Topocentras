using Framework.Pages.Topocentras;
using NUnit.Framework;
using Tests.BaseTests;
namespace Tests.Topocentras
{
    internal class TS01_Login : BaseTest
    {
        [Test]
        public void TC01_LoginUsingValidData()
        {
            TopocentrasHomePage.Open();
            TopocentrasHomePage.ClickPrisijungti();
            TopocentrasHomePage.EnterEmail();
            TopocentrasHomePage.EnterPassword();
            TopocentrasHomePage.ClickPrisijungtiInLoginMenu();
            TopocentrasHomePage.ClickManoPaskyra();
            string expectedResult = "Simonas";
            string actualResult = TopocentrasHomePage.ReadUserName(expectedResult);
            StringAssert.Contains(expectedResult, actualResult);
        }
    }
}
