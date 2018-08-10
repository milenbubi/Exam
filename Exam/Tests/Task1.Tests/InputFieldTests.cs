using Exam.Pages.DemoQaPage;
using Exam.Pages.TooltipPage;
using Exam.Utilities;
using NUnit.Framework;

namespace Exam.Tests.Task1.Tests
{
    [TestFixture]
    class InputFieldTests : DefaultFixture
    {
        [Test]
        [Property("TaskOne", 1)]
        public void HoverInputField_VerifyToolTipTextIsCorrect()
        {
            //Arrange
            DemoQaPage demoQaMainPage = PageFactory.Get<DemoQaPage>();
            TooltipPage tooltipPage = PageFactory.Get<TooltipPage>();

            demoQaMainPage.NavigateTo();
            demoQaMainPage.OpenTooltipSection();

            string expectedTooltipText = "We ask for your age only for statistical purposes.";

            //Act
            tooltipPage.HoverInputField();
            string tooltipText = tooltipPage.Tooltip.Text;

            //Assert
            Assert.IsTrue(tooltipPage.Tooltip.Displayed);
            Assert.AreEqual(expectedTooltipText, tooltipText);
        }
    }
}