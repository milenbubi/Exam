namespace Exam.Pages.DemoQaPage
{
    public partial class DemoQaPage : DefaultPage
    {
        public DemoQaPage() : base(@"http://demoqa.com/")
        {
        }

        public void OpenTooltipSection()
        {
            Tooltip.Click();
        }

        public void OpenDatePickerSection()
        {
            Datepicker.Click();
        }
    }
}