namespace Framework.Pages.Topocentras
{
    public class TopocentrasHomePage
    {

        public static void Open()
        {
            Driver.OpenPage("https://www.topocentras.lt/");
        }

        public static void ClickPrisijungti()
        {
            Common.Click(Locators.Login.prisijungti);
        }

        public static void EnterEmail()
        {
            Common.SendKeys(Locators.Login.enterEmail, "baigiamasisms2023@gmail.com");
        }

        public static void EnterPassword()
        {
            Common.SendKeys(Locators.Login.enterPassword, "Nesakysiu123@");
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
