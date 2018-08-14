using Exam.Pages.DatepickerPage;
using Exam.Pages.DemoQaPage;
using Exam.Utilities;
using NUnit.Framework;
using System.Collections.Generic;

namespace Exam.Tests.Task2.Tests
{
    [TestFixture]
    class DatePickerTests : DefaultFixture
    {
        [TestCaseSource(nameof(ExpectedDateFormats))]
        [Property("Task2", 1)]
        public void ChooseDate_ChangeFormatOption_VerifyDateValueIsCorrect(string[] expectedDateFormats)
        {
            //Arrange
            DemoQaPage demoQaMainPage = PageFactory.Get<DemoQaPage>();
            DatePickerPage datepickerPage = PageFactory.Get<DatePickerPage>();
            CalendarPage calendarPage = PageFactory.Get<CalendarPage>();

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