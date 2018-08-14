namespace Exam.Pages.DemoQaPage
{
    public partial class DemoQaPage : DefaultPage
    {
        public DemoQaPage() : base(@"http://demoqa.com/")
        {
        }

        public void OpenTooltipSection()
        {
            TooltipSection.Click();
        }

        public void OpenDatePickerSection()
        {
            DatepickerSection.Click();
        }
    }
}