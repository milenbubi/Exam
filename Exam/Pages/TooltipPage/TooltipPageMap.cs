using OpenQA.Selenium;

namespace Exam.Pages.TooltipPage
{
    public partial class TooltipPage
    {
        public IWebElement InputField => ElementBy("id", "age");

        public IWebElement Tooltip=>ElementBy("xpath", "//div[5]/div");
    }
}