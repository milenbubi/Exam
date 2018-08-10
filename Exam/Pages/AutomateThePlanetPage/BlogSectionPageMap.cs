using OpenQA.Selenium;
using System.Collections.Generic;

namespace Exam.Pages.AutomateThePlanetPage
{
  public partial  class BlogSectionPage
    {
        public IEnumerable <IWebElement> Blogs => WaitForElementsBy("xpath", "//div[@id='pgc-6453-0-0']//article[contains(@id,'post-')]");
    }
}