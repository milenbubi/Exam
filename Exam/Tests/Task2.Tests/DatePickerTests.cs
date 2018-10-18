using Exam.Utilities;
using NUnit.Framework;
using Exam.Pages.DemoQaPage;
using Exam.Pages.DatepickerPage;
using System.Collections.Generic;

namespace Exam.Tests.Task2.Tests
{
    [TestFixture]
    class DatePickerTests : DefaultFixture
    {
        [Property("Task2", 1)]
        [TestCaseSource(nameof(ExpectedDateFormats))]
        public void ChooseDate_ChangeFormatOption_VerifyDateValueIsCorrect(string[] expectedDateFormats)
        {
            //Arrange
            DemoQaPage demoQaMainPage = PageFactory.Get<DemoQaPage>();
            CalendarPage calendarPage = PageFactory.Get<CalendarPage>();
            DatePickerPage datepickerPage = PageFactory.Get<DatePickerPage>();

            demoQaMainPage.Load();
            demoQaMainPage.OpenDatePickerSection();

            datepickerPage.OpenFormatDateSubSection();
            datepickerPage.ClickDateInputField();

            //Act
            calendarPage.EnterDate();
            IEnumerable<string> dateFormats = datepickerPage.GetDateFormats();

            //Assert
            CollectionAssert.AreEqual(expectedDateFormats, dateFormats);
        }

        private static string[][] ExpectedDateFormats()
        {
            return new string[][] {
                new string[] {
                    "March 1, 2018",
                    "2018-03-01",
                    "1 Mar, 18",
                    "1 March, 18",
                    "Thursday, 1 March, 2018",
                    "day 1 of March in the year 2018"
                }};
        }
    }
}