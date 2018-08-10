using OpenQA.Selenium;

namespace Exam.Pages.DatepickerPage
{
    public partial   class CalendarPage
    {
        public IWebElement LeftArrow => WaitForElementBy("xpath", "//span[@class='ui-icon ui-icon-circle-triangle-w']");

        public IWebElement Month => WaitForElementBy("xpath", "//span[@class='ui-datepicker-month']");

        public IWebElement FirstDayOfMonth => ElementBy("xpath", "//tbody//tr[1]//td[4]//a[1]");
    }
}
