using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace Exam.Pages
{
    public abstract partial class DefaultPage
    {
        private By byLocator;

        protected IWebElement ElementBy(string locator, string locatorValue)
        {
            byLocator = IdentifyLocator(locator, locatorValue);
            return driver.FindElement(byLocator);
        }

        protected IWebElement WaitForElementBy(string locator, string locatorValue)
        {
            return wait.Until((d) => ElementBy(locator, locatorValue));
        }

        protected IEnumerable<IWebElement> ElementsBy(string locator, string locatorValue)
        {
            byLocator = IdentifyLocator(locator, locatorValue);
            return driver.FindElements(byLocator);
        }

        protected IEnumerable<IWebElement> WaitForElementsBy(string locator, string locatorValue)
        {
            return wait.Until((d) => ElementsBy(locator, locatorValue));
        }

        private By IdentifyLocator(string locator, string locatorValue)
        {
            switch (locator.ToLower())
            {
                case "id":
                    return By.Id(locatorValue);
                case "class":
                    return By.ClassName(locatorValue);
                case "xpath":
                    return By.XPath(locatorValue);
                case "link":
                    return By.LinkText(locatorValue);
                case "partial":
                    return By.PartialLinkText(locatorValue);
                case "name":
                    return By.Name(locatorValue);
                case "css":
                    return By.CssSelector(locatorValue);
                case "tag":
                    return By.TagName(locatorValue);
                default:
                    throw new ArgumentException("This locator does not exists!! :", locator);
            }
        }
    }
}