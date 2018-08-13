using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using System;

namespace Exam.Utilities
{
    public static class ChromeRepository
    {
        private static IWebDriver driver;
        private static string chromePath;

        static ChromeRepository()
        {
            chromePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    throw new NullReferenceException("ChromeDriver is not initialized! Please use appropriate methods to create one!");
                }
                else
                {
                    return driver;
                }
            }
            private set
            {
                driver = value;
            }
        }

        public static IWebDriver InitDriver()
        {
            driver = new ChromeDriver(chromePath);
            return Driver;
        }

        public static IWebDriver InitDriver(ChromeOptions options)
        {
            driver = new ChromeDriver(chromePath, options);
            return Driver;
        }

        public static void ShutDownDriver()
        {
            driver.Quit();
            driver = null;
        }
    }
}