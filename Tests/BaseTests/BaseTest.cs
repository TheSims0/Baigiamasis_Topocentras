using Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework;
using Framework.Pages.Topocentras;

namespace Tests.BaseTests
{
    [Parallelizable]
    internal class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            HomePage.Open();
            HomePage.CloseCookies();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string screenshotFilePath = Driver.TakeScreenshot(TestContext.CurrentContext.Test.MethodName);
                TestContext.AddTestAttachment(screenshotFilePath);
            }
            Driver.ShutdownDriver();
        }
    }
}
