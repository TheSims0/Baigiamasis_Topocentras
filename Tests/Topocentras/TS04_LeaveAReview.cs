using Framework.Pages.Topocentras;
using NUnit.Framework;
using Tests.BaseTests;
namespace Tests.Topocentras
{
    internal class TS04_LeaveAReview : BaseTest
    {
        [Test]
        public void TC01_LeaveA5StarReview()
        {
            string expectedResult = "Jūsų apžvalga pateikta!";
            LeavingAReview.NavigateToProductPage();
            LeavingAReview.WriteAReview();
            string actualResult = LeavingAReview.GetReviewConfirmation(expectedResult);
            StringAssert.Contains(expectedResult, actualResult);
        }
    }
}
