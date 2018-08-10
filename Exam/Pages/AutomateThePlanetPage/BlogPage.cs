using OpenQA.Selenium;

namespace Exam.Pages.AutomateThePlanetPage
{
    public partial class BlogPage : DefaultPage
    {
        private IJavaScriptExecutor jse;

        public BlogPage() : base("")
        {
            jse = (IJavaScriptExecutor)driver;
        }

        public void ScrollTo(IWebElement navigation)
        {
            DelayForSeconds(1);

            jse.ExecuteScript("arguments[0].scrollIntoView();", navigation);
            jse.ExecuteScript($"window.scrollBy(0,-{HeaderBar.Size.Height})");
        }
    }
}