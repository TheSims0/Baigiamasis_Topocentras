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
            HomePage.Open();
            HomePage.ClickPrisijungti();
            HomePage.EnterEmail();
            HomePage.EnterPassword();
            HomePage.ClickPrisijungtiInLoginMenu();
            HomePage.ClickManoPaskyra();
            string expectedResult = "Simonas";
            string actualResult = HomePage.ReadUserName(expectedResult);
            StringAssert.Contains(expectedResult, actualResult);
        }
    }
}
