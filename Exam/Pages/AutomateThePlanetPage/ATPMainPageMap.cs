using OpenQA.Selenium;

namespace Exam.Pages.AutomateThePlanetPage
{
    public partial   class ATPMainPage
    {
        public IWebElement BlogLink => WaitForElementBy("xpath", "//ul[@id='menu-main-menu']//li[3]");
    }
}