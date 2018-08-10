using Exam.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading.Tasks;

namespace Exam.Pages
{
    public abstract partial class DefaultPage
    {
        protected IWebDriver driver;
        protected IWait<IWebDriver> wait;
        protected string url;

        public DefaultPage(string url)
        {
            driver = ChromeRepository.Driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            this.url = url;
        }

        public void DelayForSeconds(int seconds)
        {
            int miliSeconds = seconds * 1000;
            Task.Delay(miliSeconds).Wait();
        }

        //  Virtual ??
        public virtual void NavigateTo(string innerPage = "")
        {
            driver.Url = url + "/" + innerPage;
        }
    }
}