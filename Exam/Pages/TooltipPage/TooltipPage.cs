using OpenQA.Selenium.Interactions;

namespace Exam.Pages.TooltipPage
{
    public partial class TooltipPage : DefaultPage
    {
        public TooltipPage() : base("")
        {
        }

        public void HoverInputField()
        {
            Actions builder = new Actions(driver);
            builder.MoveToElement(InputField).Perform();
        }
    }
}