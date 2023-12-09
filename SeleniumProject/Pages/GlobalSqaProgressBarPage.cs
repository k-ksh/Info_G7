using OpenQA.Selenium;

namespace SeleniumProject.Pages
{
    public class GlobalSqaProgressBarPage : GlodalSqaBasePage
    {        
        public GlobalSqaProgressBarPage(IWebDriver driver) : base(driver) { }

        public IWebElement DownloadIframe => driver.FindElement(By.CssSelector(".demo-frame.lazyloaded"));

        public IWebElement StartDownloadButton => driver.FindElement(By.Id("downloadButton"));
        public IWebElement ProgressBarElement => driver.FindElement(By.CssSelector(".progress-label"));

        public ComponentForPage1 ComponentForPage1 => new ComponentForPage1(driver);
    }
}
