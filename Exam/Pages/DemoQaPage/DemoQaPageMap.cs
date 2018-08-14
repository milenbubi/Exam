using OpenQA.Selenium;

namespace Exam.Pages.DemoQaPage
{
    public partial class DemoQaPage
    {
        public IWebElement TooltipSection => ElementBy("id", "menu-item-99");

        public IWebElement DatepickerSection => ElementBy("id", "menu-item-146");
    }
}