using System.Collections.Generic;

namespace Exam.Pages.DatepickerPage
{
    public partial class DatePickerPage : DefaultPage
    {
        public DatePickerPage() : base("")
        {
        }

        public void OpenFormatDateSubSection()
        {
            FormatDateSubSection.Click();
        }

        public void ClickDateInputField()
        {
            DateInput.Click();
        }

        public IEnumerable<string> GetDateFormats()
        {
            int optionsCount = FormatOptions.Options.Count;

            for (int i = 0; i < optionsCount; i++)
            {
                FormatOptions.SelectByIndex(i);
                yield return DateInput.GetAttribute("value");
            }
        }
    }
}