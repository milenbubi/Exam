using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace Exam.Utilities
{
    public static class ChromeRepository
    {
        public static IWebDriver Driver { get; private set; }

        public static IWebDriver InitDriver()
        {
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            return Driver;
        }

        public static IWebDriver InitDriver(ChromeOptions options)
        {
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options);
            return Driver;
        }
    }
}