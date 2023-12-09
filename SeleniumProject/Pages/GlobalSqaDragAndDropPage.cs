using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumProject.Pages
{
    public class GlobalSqaDragAndDropPage : GlodalSqaBasePage
    {
        public GlobalSqaDragAndDropPage(IWebDriver driver) : base(driver) { }

        public IWebElement PhotoManagerIframe => driver.FindElement(By.CssSelector("iframe[data-src*='photo-manager.html']"));
        public IWebElement HighTatrasPictureElement => driver.FindElement(By.CssSelector("img[src='images/high_tatras_min.jpg']"));
        public IWebElement TrashElement => driver.FindElement(By.Id("trash"));
        public List<IWebElement> PictureInTrash => driver.FindElements(By.CssSelector("#trash img[src='images/high_tatras_min.jpg']")).ToList();

        public ComponentForPage2 ComponentForPage2 => new ComponentForPage2(driver);
    }
}
