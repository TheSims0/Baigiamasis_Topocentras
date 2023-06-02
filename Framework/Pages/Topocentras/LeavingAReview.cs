namespace Framework.Pages.Topocentras
{
    public class LeavingAReview
    {
        public static void Open()
        {
            Driver.OpenPage("https://www.topocentras.lt/");
        }

        public static void CloseCookies()
        {
            Common.Click(Locators.AddToCart.cookies);
        }

        public static void NavigateToProductPage()
        {
            Common.HoverOnElement(Locators.LeaveAReview.televizoriai);
            Common.Click(Locators.LeaveAReview.lGTelevizoriai);
            Common.WaitUntilElementIsVisibleAndClickable(Locators.LeaveAReview.lGProduct);
            Common.Click(Locators.LeaveAReview.lGProduct);
        }

        public static void WriteAReview()
        {
            Common.WaitUntilElementIsVisibleAndClickable(Locators.LeaveAReview.reviewButton);
            Common.ScrollUntilElementIsClickable(Locators.LeaveAReview.reviewButton);
            Common.Click(Locators.LeaveAReview.reviewButton);
            Common.WaitUntilElementIsVisibleAndClickable(Locators.LeaveAReview.starRating);
            Common.Click(Locators.LeaveAReview.starRating);
            Common.SendKeys(Locators.LeaveAReview.antraste, "Puiki preke");
            Common.SendKeys(Locators.LeaveAReview.apzvalga, "Puiki preke");
            Common.Click(Locators.LeaveAReview.rekomendacija);
            Common.Click(Locators.LeaveAReview.kokybe);
            Common.Click(Locators.LeaveAReview.verte);
            Common.SendKeys(Locators.LeaveAReview.vardas, "Simonas");
            Common.SendKeys(Locators.LeaveAReview.elpastas, "abcde@gmail.com");
            Common.Click(Locators.LeaveAReview.nuostatai);
            Common.Click(Locators.LeaveAReview.submitReview);
        }

        public static string GetReviewConfirmation(string expextedText)
        {
            Common.WaitUntilElementIsVisibleAndContainsExpectedText(Locators.LeaveAReview.reviewResult, expextedText);
            return Common.GetElementText(Locators.LeaveAReview.reviewResult);
        }
    }
}
