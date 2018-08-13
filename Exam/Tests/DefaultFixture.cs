using Exam.Utilities;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

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
            options.AddArgument("--headless");

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