using OpenQA.Selenium;

namespace SeleniumProject.Pages
{
    public class ComponentForPage2
    {
        IWebDriver driver;

        public ComponentForPage2(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement ElementFromComponent2 => driver.FindElement(By.Id("ID for component element 2"));
    }
}
