using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Exam.Utilities
{
    public static class ExtensionMethods
    {
        public static void SendText(this IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        public static void FindAndClick(this IWebElement element)
        {
            new Actions(ChromeRepository.Driver)
                .MoveToElement(element)
                .Click()
                .Perform();
        }
    }
}