namespace Exam.Pages.DatepickerPage
{
    public partial class CalendarPage : DefaultPage
    {
        public CalendarPage() : base("")
        {
        }

        public void EnterDate()
        {
            while (Month.Text != "March")
            {
                LeftArrow.Click();
            }

            FirstDayOfMonth.Click();
        }
    }
}