namespace Exam.Pages.AutomateThePlanetPage
{
    public partial class ATPMainPage : DefaultPage
    {
        public ATPMainPage() : base(@"https://www.automatetheplanet.com")
        {
        }

        public void OpenBlogSection()
        {
            BlogLink.Click();
        }
    }
}