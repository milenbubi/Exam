using OpenQA.Selenium;
using System.Collections.Generic;

namespace Exam.Pages.AutomateThePlanetPage
{
    public partial class BlogPage
    {
        public IWebElement HeaderBar => WaitForElementBy("xpath", "//div[@class='bh clearfix fbh']");

        public IEnumerable<IWebElement> QuickNavigations => WaitForElementsBy("xpath", "//div[@class='tve_contents_table tve_clearfix']//a");

        public IWebElement ElementWith(string articleID)=> driver.FindElement(By.Id(articleID));
    }
}