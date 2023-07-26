namespace Framework.Pages.Topocentras
{
    public class HomePage
    {

        public static void Open()
        {
            Driver.OpenPage("https://www.topocentras.lt/");
        }

        public static void CloseCookies()
        {
            Common.Click(Locators.Home.cookies);
        }

        public static void ClickPrisijungti()
        {
            Common.Click(Locators.Login.prisijungti);
        }

        public static void EnterEmail(string email)
        {
            Common.SendKeys(Locators.Login.enterEmail, email);
        }

        public static void EnterPassword(string password)
        {
            Common.SendKeys(Locators.Login.enterPassword, password);
        }

        public static void ClickPrisijungtiInLoginMenu()
        {
            Common.Click(Locators.Login.prisijungtiInLoginMenu);
        }

        public static void ClickManoPaskyra()
        {
            Common.WaitUntilElementIsVisibleAndClickable(Locators.Login.manoPaskyra);
            Common.Click(Locators.Login.manoPaskyra);
        }

        public static string ReadUserName(string expectedText)
        {
            Common.WaitUntilElementIsVisibleAndContainsExpectedText(Locators.Login.readUserName, expectedText);
            return Common.GetElementText(Locators.Login.readUserName);
        }
    }
}
