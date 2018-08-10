using OpenQA.Selenium;

namespace Exam.Pages.DemoQaPage
{
    public partial class DemoQaPage
    {
        public IWebElement Tooltip => ElementBy("id", "menu-item-99");

        public IWebElement Datepicker => ElementBy("id", "menu-item-146");
    }
}