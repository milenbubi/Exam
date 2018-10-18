using System.Linq;
using Exam.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using Exam.Pages.AutomateThePlanetPage;

namespace Exam.Tests.Task3.Tests
{
    [TestFixture]
    class BlogTests : DefaultFixture
    {
        private static int[] blogNumbers = { 2, 4, 5 };

        private string[] hTags = { "h2", "h3" };

        [Property("Task3", 1)]
        [TestCaseSource(nameof(blogNumbers))]
        public void OpenBlog_VerifyQuickNavigationTextsAreSameAsArticlesNames(int position)
        {
            //Arrange
            BlogPage blogPage = PageFactory.Get<BlogPage>();
            ATPMainPage mainPage = PageFactory.Get<ATPMainPage>();
            BlogSectionPage blogSectionPage = PageFactory.Get<BlogSectionPage>();

            mainPage.Load();
            mainPage.OpenBlogSection();
            blogSectionPage.OpenBlog(position);

            //Act
            foreach (IWebElement navigation in blogPage.QuickNavigations)
            {
                blogPage.ScrollTo(navigation);

                string navigationHref = navigation.GetAttribute("href");

                string articleID = navigationHref.Substring(navigationHref.IndexOf('#') + 1);

                navigation.Click();

                IWebElement articleName = blogPage.ElementWith(articleID);

                //Assert
                Assert.IsTrue(articleName.Text == navigation.Text);
                Assert.IsTrue(articleName.Displayed);
                Assert.IsTrue(hTags.Contains(articleName.TagName));
            }
        }
    }
}