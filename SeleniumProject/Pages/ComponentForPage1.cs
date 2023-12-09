using OpenQA.Selenium;

namespace SeleniumProject.Pages
{
    public class ComponentForPage1
    {
        IWebDriver driver;

        public ComponentForPage1(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement ElementFromComponent1 => driver.FindElement(By.Id("ID for component  element 1"));
    }
}
