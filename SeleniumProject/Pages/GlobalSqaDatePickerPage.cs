using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.Pages
{

    public class GlobalSqaDatePickerPage : GlodalSqaBasePage
    {
        public GlobalSqaDatePickerPage(IWebDriver driver) : base(driver) { }
        public IWebElement DatePickerIframe => driver.FindElement(By.CssSelector("iframe[data-src*='datepicker/default.html']"));
        public IWebElement DatePickerElement => driver.FindElement(By.CssSelector("input[type='text'][id='datepicker'].hasDatepicker"));
        public IWebElement NextMonthButtonElement => driver.FindElement(By.CssSelector("a.ui-datepicker-next"));

        public void ChooseNextMonthDate()
        {
            NextMonthButtonElement.Click();
            
            // Assuming you want to select the current day, modify this logic as needed
            var currentDate = DateTime.Now.AddMonths(1).ToString("dd");
            var dateLocator = By.XPath($"//td[@class=' ' and @data-handler='selectDay' and @data-event='click' and @data-month='0' and @data-year='2024']/a[text()='{currentDate}']");

            


            driver.FindElement(dateLocator).Click();
        }

        public string GetSelectedDate()
        {
            // Get the selected date from the input field
            return DatePickerElement.GetAttribute("value");
        }

    }

    }
