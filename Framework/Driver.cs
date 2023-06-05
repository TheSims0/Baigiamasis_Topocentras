using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.IO;
using System;
using System.Threading;

namespace Framework
{
    public class Driver
    {
        private static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();
        
        public static void InitializeDriver()
        {
            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--window-size=1920,1080");
            //options.AddArgument("--headless");
            driver.Value = new ChromeDriver(options);
            driver.Value.Manage().Window.Maximize();
        }

        internal static IWebDriver GetDriver()
        {
            return driver.Value;
        }

        internal static void OpenPage(string url)
        {
            driver.Value.Url = url;
        }

        public static void ShutdownDriver()
        {
            driver.Value.Quit();
        }

        public static string TakeScreenshot(string methodName)
        {
            string screenshotDirectoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}Screenshots";
            string screenshotName = $"{methodName}-{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}-screenshot.png";
            string screenshotFilePath = $"{screenshotDirectoryPath}\\{screenshotName}";
            Directory.CreateDirectory(screenshotDirectoryPath);
            Screenshot screenshot = ((ITakesScreenshot)driver.Value).GetScreenshot();
            screenshot.SaveAsFile($"{screenshotFilePath}", ScreenshotImageFormat.Png);
            return screenshotFilePath;
        }
    }
}
