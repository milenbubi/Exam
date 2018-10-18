using System.IO;
using Exam.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Reflection;
using OpenQA.Selenium.Chrome;
using NUnit.Framework.Interfaces;

namespace Exam.Tests
{
    public class DefaultFixture
    {
        private Screenshot screenshot;
        private string screenshotFolder;

        protected IWebDriver driver;
        protected string projectPath;

        public DefaultFixture()
        {
            projectPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\..\..\";
            screenshotFolder = projectPath + @"Screenshots\";
        }

        [SetUp]
        public void SetUpTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            // options.AddArgument("--headless");

            driver = ChromeRepository.InitDriver(options);
        }

        [TearDown]
        public void EndOfTest()
        {
            if (TestContext.CurrentContext.Result.Outcome == ResultState.Failure)
            {
                screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(screenshotFolder + GetTestName() + ".png", ScreenshotImageFormat.Png);
            }

            ChromeRepository.ShutDownDriver();
        }

        private string GetTestName()
        {
            string methodName = TestContext.CurrentContext.Test.Name;
            return methodName.Replace("\"", "''");
        }
    }
}