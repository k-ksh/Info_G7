using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumProject.Pages
{
    public class GlobalSqaMainPage : GlodalSqaBasePage
    {
        public GlobalSqaMainPage(IWebDriver driver) : base(driver)
        {
            //ComponentForPage1 = new ComponentForPage1(driver);
        }

        public IWebElement TestersHubMainMenuElement => driver.FindElement(By.Id("menu-item-2822"));
        public IWebElement DemoTestersSiteSubMenuElement => driver.FindElement(By.Id("menu-item-2823"));
        public IWebElement DragAndDropSubSubMenuElement => driver.FindElement(By.Id("menu-item-2829"));
        public IWebElement ProgressBarSubSubMenuElement => driver.FindElement(By.Id("menu-item-2832"));

        public ComponentForPage1 ComponentForPage1 => new ComponentForPage1(driver);
        public ComponentForPage2 ComponentForPage2 => new ComponentForPage2(driver);

        // Another approach
        private IWebElement TestersHubMainMenuElement1 => driver.FindElement(By.Id("menu-item-2822"));
        private IWebElement DemoTestersSiteSubMenuElement1 => driver.FindElement(By.Id("menu-item-2823"));
        private IWebElement DragAndDropSubSubMenuElement1 => driver.FindElement(By.Id("menu-item-2829"));
        private string DragAndDropText => DragAndDropSubSubMenuElement1.Text;

        #region Element for percentage test

        public IWebElement TestAutomationPercentNumber => driver.FindElement(By.Id("circ_counter_text1"));
        public IWebElement TestAutomationPercentElement => driver.FindElement(By.XPath("//*[@id='circ_counter_text1']/following-sibling::span"));
        public IWebElement TestingQaServicesPercentNumber => driver.FindElement(By.Id("circ_counter_text2"));
        public IWebElement TestingQaServicesPercentElement => driver.FindElement(By.XPath("//*[@id='circ_counter_text2']/following-sibling::span"));
        public IWebElement QaTrainingsPercentNumber => driver.FindElement(By.Id("circ_counter_text3"));
        public IWebElement QaTrainingsPercentElement => driver.FindElement(By.XPath("//*[@id='circ_counter_text3']/following-sibling::span"));

        #endregion

        public void GoToDragAndDropPage()
        {
            var actions = new Actions(driver);
            actions
                .MoveToElement(TestersHubMainMenuElement1)
                .MoveToElement(DemoTestersSiteSubMenuElement1)
                .Click(DragAndDropSubSubMenuElement1)
                .Perform();
        }

        public GlobalSqaDragAndDropPage GoToDragAndDropPage1()
        {
            var actions = new Actions(driver);
            actions
                .MoveToElement(TestersHubMainMenuElement1)
                .MoveToElement(DemoTestersSiteSubMenuElement1)
                .Click(DragAndDropSubSubMenuElement1)
                .Perform();

            return new GlobalSqaDragAndDropPage(driver);
        }
    }
}
