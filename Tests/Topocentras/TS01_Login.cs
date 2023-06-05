using Framework.Pages.Topocentras;
using NUnit.Framework;
using Tests.BaseTests;
namespace Tests.Topocentras
{
    internal class TS01_Login : BaseTest
    {
        [TestCase("baigiamasisms2023@gmail.com", "Nesakysiu123@")]
        public void TC01_LoginUsingValidData(string email, string password)
        {
            
            string expectedResult = "Simonas";

            HomePage.ClickPrisijungti();
            HomePage.EnterEmail(email);
            HomePage.EnterPassword(password);
            HomePage.ClickPrisijungtiInLoginMenu();
            HomePage.ClickManoPaskyra();
            string actualResult = HomePage.ReadUserName(expectedResult);
            
            StringAssert.Contains(expectedResult, actualResult);
        }
    }
}
