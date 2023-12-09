using OpenQA.Selenium;

namespace SeleniumProject.Pages
{
    public class GlodalSqaBasePage
    {
        protected IWebDriver driver;

        public GlodalSqaBasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
