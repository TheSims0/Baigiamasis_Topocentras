using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace Framework.Pages
{
    public class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void Click(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void SendKeys(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void WaitUntilElementIsVisibleAndClickable(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(15));
            wait.Until(driver => GetElement(locator).Enabled && GetElement(locator).Displayed);
        }
      
        internal static void WaitUntilElementIsVisibleAndContainsExpectedText(string locator, string expectedText)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(driver => GetElement(locator).Displayed && GetElement(locator).Text.Contains(expectedText));
        }

        internal static void HoverOnElement(string locator)
        {
            IWebElement elementToHover = GetElement(locator);
            Actions action = new Actions(Driver.GetDriver());
            action.MoveToElement(elementToHover).Perform();
        }

        internal static void ClickElementsInListAndClosePopUp(string locator, string xpath)
        {
            IList<IWebElement> elements = Driver.GetDriver().FindElements(By.XPath(locator));
            foreach (IWebElement element in elements)
            {
                WaitUntilElementIsVisibleAndClickable(locator);
                element.Click();
                WaitUntilElementIsVisibleAndClickable(xpath);
                Click(xpath);
            }
        }

        internal static void ScrollUntilElementIsClickable(string locator)
        {
            var element = GetElement(locator);
            Actions actions = new Actions(Driver.GetDriver());
            actions.MoveToElement(element);
            actions.Perform();
        }

        internal static string CountElements(string locator)
        {
            ReadOnlyCollection<IWebElement> elements = Driver.GetDriver().FindElements(By.XPath(locator));
            int count = elements.Count;
            return count.ToString();
        }

        internal static void ClickElementsInList(string locator)
        {
            IList<IWebElement> elements = Driver.GetDriver().FindElements(By.XPath(locator));
            foreach (IWebElement element in elements)
            {
                WaitUntilElementIsVisibleAndClickable(locator);
                element.Click();
            }
        }

        internal static List<string> GetElementsTextList(string locator)
        {
            IList<IWebElement> elements = Driver.GetDriver().FindElements(By.XPath(locator));
            List<string> elementsText = new List<string>();
            foreach (IWebElement element in elements)
            {
                elementsText.Add(element.Text);
            }
            return elementsText;
        }

        internal static void SelectElementInDropDownMenu(string locator, int optionNumberByIndex)
        {
            IWebElement dropdown = GetElement(locator);
            SelectElement select = new SelectElement(dropdown);
            select.SelectByIndex(optionNumberByIndex);
        }
    }
}
