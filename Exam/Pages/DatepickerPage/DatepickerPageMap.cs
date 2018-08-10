using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Exam.Pages.DatepickerPage
{
    public partial class DatePickerPage
    {
        public IWebElement FormatDateSubSection => ElementBy("id", "ui-id-4");

        public IWebElement DateInput => ElementBy("id", "datepicker4");

        public SelectElement FormatOptions => new SelectElement(ElementBy("id", "format"));
    }
}