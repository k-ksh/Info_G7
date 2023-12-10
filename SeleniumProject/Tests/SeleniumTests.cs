using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumProject.Pages;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;

namespace SeleniumProject.Tests
{
    [TestFixture]
    public class SeleniumTests
    {
        IWebDriver driver;
        WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Manage().Window.Maximize();

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }


        //[Test]
        public void HW17()
        {
            // Arrange
            driver.Url = "https://www.globalsqa.com/samplepagetest/";

          
            IWebElement fileInput = driver.FindElement(By.XPath("//input[@name='file-553']"));

            fileInput.SendKeys("C:\\Users\\katia.shvachko\\Desktop\\test17.txt");

            
          
            IWebElement nameInput = driver.FindElement(By.XPath("//input[@name='g2599-name']"));
            nameInput.SendKeys("katia");

            
            IWebElement emailInput = driver.FindElement(By.XPath("//input[@name='g2599-email']"));
            emailInput.SendKeys("katya.shvacko@gmail.com");

       
            IWebElement experienceDropdown = driver.FindElement(By.XPath("//select[@name='g2599-experienceinyears']"));
            SelectElement experienceSelect = new SelectElement(experienceDropdown);
            experienceSelect.SelectByText("3-5");

            var functionalTestingCheckbox = driver.FindElement(By.CssSelector("[value='Functional Testing']"));
            var postGraduateRadiobutton = driver.FindElement(By.CssSelector("[value='Post Graduate']"));
            var submitButton = driver.FindElement(By.XPath("//button[@class='pushbutton-wide']"));
            var contactInfo = driver.FindElement(By.XPath("//h3[text()='Contact Info']"));

            var yCords = postGraduateRadiobutton.Location.Y;
            var windowHeight = driver.Manage().Window.Size.Height;

            Actions actions = new Actions(driver);

            
            actions.ScrollToElement(submitButton).Perform();

            functionalTestingCheckbox.Click();
            postGraduateRadiobutton.Click();

            actions.ScrollToElement(contactInfo).Perform();
            IWebElement commentInput = driver.FindElement(By.XPath("//textarea[@name='g2599-comment']"));
            commentInput.SendKeys("hw17");

            submitButton.Click();


            // Arrange
            
            IWebElement blockquote = driver.FindElement(By.XPath("//blockquote[@class='contact-form-submission']"));
      
            ReadOnlyCollection<IWebElement> paragraphs = blockquote.FindElements(By.XPath("./p"));


            Assert.Multiple(() =>
            {
                Assert.IsTrue(paragraphs.Any(p => p.Text.Contains("Name: katia")), "Name 'katia' not found in the blockquote.");
                Assert.IsTrue(paragraphs.Any(p => p.Text.Contains("Email: katya.shvacko@gmail.com")), "Email information not found in the blockquote.");
                Assert.IsTrue(paragraphs.Any(p => p.Text.Contains("Experience (In Years): 3-5")), "Experience information not found in the blockquote.");
                Assert.IsTrue(paragraphs.Any(p => p.Text.Contains("Expertise :: Functional Testing")), "expertise information not found in the blockquote.");
                Assert.IsTrue(paragraphs.Any(p => p.Text.Contains("Education: Post Graduate")), " Education information not found in the blockquote.");
                Assert.IsTrue(paragraphs.Any(p => p.Text.Contains("Comment: hw17")), " comment information not found in the blockquote.");
           

            });

        }


        //[Test]
        public void VerifyPercantageOnGlobalSqaMain()
        {
            // Arrange
            driver.Url = "https://www.globalsqa.com/";
            var expectedPercent1 = "95%";
            var expectedPercent2 = "92%";
            var expectedPercent3 = "87%";

            // Act
            var globalSqaMainPage = new GlobalSqaMainPage(driver);

            //var actuaPercent1 = $"{globalSqaMainPage.TestAutomationPercentNumber.GetAttribute("textContent")}{globalSqaMainPage.TestAutomationPercentElement.GetAttribute("textContent")}";
            //var actuaPercent2 = $"{globalSqaMainPage.TestingQaServicesPercentNumber.GetAttribute("textContent")}{globalSqaMainPage.TestingQaServicesPercentElement.GetAttribute("textContent")}";
            //var actuaPercent3 = $"{globalSqaMainPage.QaTrainingsPercentNumber.GetAttribute("textContent")}{globalSqaMainPage.QaTrainingsPercentElement.GetAttribute("textContent")}";

            var percentElements = driver.FindElements(By.CssSelector(".counter_percent_sign.shown"));

            foreach (var item in percentElements)
            {
                Console.WriteLine(item.GetAttribute("textContent"));
            }

            // Assert
            //Assert.Multiple(() => 
            //{
            //    Assert.True(actuaPercent1 == expectedPercent1, $"Actual Test Automation percent {actuaPercent1} is not {expectedPercent1}.");

            //    Assert.True(actuaPercent2 == expectedPercent2, $"Actual Testing Qa Services percent {actuaPercent2} is not {expectedPercent2}.");

            //    Assert.True(actuaPercent3 == expectedPercent3, $"Actual Qa Trainings percent {actuaPercent3} is not {expectedPercent3}.");
            //});
        }

        //[Test]
        public void TestScrollToElement()
        {
            driver.Url = "https://www.globalsqa.com/samplepagetest/";

            var postGraduateRadiobutton = driver.FindElement(By.CssSelector("[value='Post Graduate']"));

            var submitButton = driver.FindElement(By.CssSelector("[type='submit']"));

            var yCords = postGraduateRadiobutton.Location.Y;
            var windowHeight = driver.Manage().Window.Size.Height;

            Actions actions = new Actions(driver);

            //actions.ScrollByAmount(0, windowHeight / 2).Perform();
            actions.ScrollToElement(submitButton).Perform();

            postGraduateRadiobutton.Click();
        }

        //[Test]
        public void TestWebDriverElementMethods()
        {
            IWebDriver driver = null;

            driver.Close();
            driver.Quit();
            driver.Dispose();

            var currentWindowId = driver.CurrentWindowHandle;
            var allWindowsId = driver.WindowHandles;

            foreach (var handle in allWindowsId)
            {
                if (handle != currentWindowId)
                {
                    driver.SwitchTo().Window(handle);
                }
            }

            driver.SwitchTo().Window(currentWindowId);

            var cookies = driver.Manage().Cookies;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(300);

            // For IJavaScriptExecutor ONLY !!!
            driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(10);
            ((IJavaScriptExecutor)driver).ExecuteAsyncScript("script");

            driver.Url = "https://www.ukr.net/";
            var currentUrl = driver.Url;

            driver.SwitchTo().NewWindow(WindowType.Tab);

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@name='mail widget']")));
            driver.SwitchTo().ParentFrame();
            driver.SwitchTo().DefaultContent();

            IWebElement element = driver.FindElement(By.Id("Some Id"));
            ReadOnlyCollection<IWebElement> elements = driver.FindElements(By.CssSelector("Some CSS"));

            // Dot before xpath
            element.FindElement(By.XPath(".//div"));
            element.GetAttribute("style");

            // The same
            var text1 = element.Text;
            var text2 = element.GetAttribute("innerText");

            // Work always
            var text3 = element.GetAttribute("textContent");

            // Text from input
            var text4 = element.GetAttribute("value");
        }

        //[Test]
        public void TestActionsAndIAction()
        {
            IWebElement element = null;
            IWebElement element1 = null;

            Actions actions = new Actions(driver);

            actions.Click().Perform();
            actions.Click(element).Perform();

            IAction chainOfActions = actions.Click().DoubleClick().ContextClick().Build();
            chainOfActions.Perform();
            chainOfActions.Perform();
            chainOfActions.Perform();
            chainOfActions.Perform();

            actions.ClickAndHold(element1).Perform();
            actions.MoveToElement(element).Perform();
            actions.Release().Perform();

            actions.DragAndDrop(element1, element).Perform();
            
            actions.SendKeys(element, Keys.Control + "V").Perform();
            actions.SendKeys("some text").Perform();
        }

        //[Test]
        public void VerifyNavigationAndCheckTitle()
        {
            // Arrange
            driver.Url = "https://www.ukr.net/";
            var expectedUrl = "https://www.ukr.net/";
            var expectedTitle = "UKR.NET: Всі новини України, останні новини дня в Україні та Світі";

            // Act
            var actualUrl = driver.Url;
            var titleElement = driver.FindElement(By.XPath("//meta[@content='UkrNet //www.ukr.net']/preceding-sibling::title"));
            var actualTitle = titleElement.GetAttribute("textContent");

            // Assert
            Assert.Multiple(() => 
            {
                Assert.True(actualUrl == expectedUrl, $"Actual URL '{actualUrl}' is not equal '{expectedUrl}'.");

                Assert.True(actualTitle == expectedTitle, $"Actual title '{actualTitle}' is not equal '{expectedTitle}'.");                
            });
        }

        //[Test]
        public void TestSelectElement()
        {
            IWebElement selectTagElement = driver.FindElement(By.CssSelector("path to select tag"));

            SelectElement dropdownElement = new SelectElement(selectTagElement);

            var selectedOption = dropdownElement.SelectedOption;
        }

        //[Test]
        public void VerifyDragAndDrop()
        {
            // Arrange
            driver.Url = "https://www.globalsqa.com/";

            // Act
            var testersHubMainMenuElement = driver.FindElement(By.Id("menu-item-2822"));
            var demoTestersSiteSubMenuElement = driver.FindElement(By.Id("menu-item-2823"));
            var dragAndDropSubSubMenuElement = driver.FindElement(By.Id("menu-item-2829"));

            // Navigate to Drag And Drop page
            var actions = new Actions(driver);
            actions
                .MoveToElement(testersHubMainMenuElement)
                .MoveToElement(demoTestersSiteSubMenuElement)
                .Click(dragAndDropSubSubMenuElement)
                .Perform();

            var photoManagerIframe = driver.FindElement(By.CssSelector("iframe[data-src*='photo-manager.html']"));
            driver.SwitchTo().Frame(photoManagerIframe);

            var highTatrasPictureElement = driver.FindElement(By.CssSelector("img[src='images/high_tatras_min.jpg']"));
            var trashElement = driver.FindElement(By.Id("trash"));

            actions.DragAndDrop(highTatrasPictureElement, trashElement).Perform();

            var pictureInTrash = driver.FindElements(By.CssSelector("#trash img[src='images/high_tatras_min.jpg']"));
            var expectedPicturesInTrashNumber = 1;

            // Assert
            Assert.Multiple(() =>
            {
                Assert.True(pictureInTrash.Count == expectedPicturesInTrashNumber, 
                    $"There is '{pictureInTrash.Count}' pictures in trash area. " +
                    $"Expected number is '{expectedPicturesInTrashNumber}'.");
            });
        }

        //[Test]
        public void VerifyDragAndDropWithPageObject()
        {
            // Arrange
            driver.Url = "https://www.globalsqa.com/";

            // Act
            var globalSqaMainPage = new GlobalSqaMainPage(driver);
            
            // Navigate to Drag And Drop page
            var actions = new Actions(driver);
            actions
                .MoveToElement(globalSqaMainPage.TestersHubMainMenuElement)
                .MoveToElement(globalSqaMainPage.DemoTestersSiteSubMenuElement)
                .Click(globalSqaMainPage.DragAndDropSubSubMenuElement)
                .Perform();

            // Another option
            var globalSqaDragAndDropPage1 = globalSqaMainPage.GoToDragAndDropPage1();

            var globalSqaDragAndDropPage = new GlobalSqaDragAndDropPage(driver);            
            driver.SwitchTo().Frame(globalSqaDragAndDropPage.PhotoManagerIframe);
            actions.DragAndDrop(globalSqaDragAndDropPage.HighTatrasPictureElement, globalSqaDragAndDropPage.TrashElement).Perform();           
            var expectedPicturesInTrashNumber = 1;

            // Assert
            Assert.Multiple(() =>
            {
                Assert.True(globalSqaDragAndDropPage.PictureInTrash.Count == expectedPicturesInTrashNumber,
                    $"There is '{globalSqaDragAndDropPage.PictureInTrash.Count}' pictures in trash area. " +
                    $"Expected number is '{expectedPicturesInTrashNumber}'.");
            });
        }

        [Test]
        public void VerifyDatePickerWithPageObject()
        {
            // Arrange
            driver.Url = "https://www.globalsqa.com/";

            // Act
            var globalSqaMainPage = new GlobalSqaMainPage(driver);

            // Navigate to Date Picker page
            var actions = new Actions(driver);
            actions
                .MoveToElement(globalSqaMainPage.TestersHubMainMenuElement)
                .MoveToElement(globalSqaMainPage.DemoTestersSiteSubMenuElement)
                .Click(globalSqaMainPage.DatePickerSubSubMenuElement)
                .Perform();

            // Another option
            //var globalSqaDragAndDropPage1 = globalSqaMainPage.GoToDragAndDropPage1();

            var globalSqaDatePickerPage = new GlobalSqaDatePickerPage(driver);
            driver.SwitchTo().Frame(globalSqaDatePickerPage.DatePickerIframe);

            actions
                .Click(globalSqaDatePickerPage.DatePickerElement)
                .Perform();

            // Choose the current day of the next month
            globalSqaDatePickerPage.ChooseNextMonthDate();

            // Get the selected date for verification
            var selectedDate = globalSqaDatePickerPage.GetSelectedDate();
            // Get the current date plus one month in the "MM/dd/yyyy" format
            var expectedDate = DateTime.Now.AddMonths(1).ToString("MM/dd/yyyy");

            expectedDate = expectedDate.Replace(".", "/");

            // Assert
            Assert.AreEqual(expectedDate, selectedDate, $"Selected date is not as expected. Expected: {expectedDate}, Actual: {selectedDate}");


        }



        //[Test]
        public void WorkWithComponents()
        {
            var globalSqaMainPage = new GlobalSqaMainPage(driver);
            var globalSqaDragAndDropPage = new GlobalSqaDragAndDropPage(driver);
            var globalSqaProgressBarPage = new GlobalSqaProgressBarPage(driver);

            // Access to component(s)
            IWebElement component1 = globalSqaMainPage.ComponentForPage1.ElementFromComponent1;
            IWebElement component2 = globalSqaMainPage.ComponentForPage2.ElementFromComponent2;

            IWebElement componentOnDragAndDrop = globalSqaDragAndDropPage.ComponentForPage2.ElementFromComponent2;
            IWebElement componentOnProgressBar = globalSqaProgressBarPage.ComponentForPage1.ElementFromComponent1;
        }

        //[Test]
        public void VerifyDownload()
        {
            // Arrange
            driver.Url = "https://www.globalsqa.com/";

            // Act
            var globalSqaMainPage = new GlobalSqaMainPage(driver);

            // Navigate to Download page
            var actions = new Actions(driver);
            actions
                .MoveToElement(globalSqaMainPage.TestersHubMainMenuElement)
                .MoveToElement(globalSqaMainPage.DemoTestersSiteSubMenuElement)
                .Click(globalSqaMainPage.ProgressBarSubSubMenuElement)
                .Perform();

            var globalSqaProgressBarPage = new GlobalSqaProgressBarPage(driver);

            driver.SwitchTo().Frame(globalSqaProgressBarPage.DownloadIframe);

            globalSqaProgressBarPage.StartDownloadButton.Click();

            // Bad solution
            //Thread.Sleep(10000);

            //wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            wait.Timeout = TimeSpan.FromSeconds(15);
            wait.PollingInterval = TimeSpan.FromSeconds(5);
            wait.Message = "Message if wait failed by timeout.";

            // Ignore specific exception(s)
            //wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ArgumentException));

            // Ignore all exceptions
            wait.IgnoreExceptionTypes(typeof(Exception));

            var expectedText = "Complete!";
            string actualText;

            bool IsDownloadComplete()
            {
                actualText = globalSqaProgressBarPage.ProgressBarElement.GetAttribute("textContent");
                return actualText == expectedText;
            }

            bool resultOfWait = wait.Until(driver => IsDownloadComplete());
            IWebElement resultOfWaitNew = wait.Until(driver => driver.FindElement(By.Id("test ID")));

            WaitForCondition(driver => IsDownloadComplete(),
                "Message if wait failed by timeout.", typeof(Exception), 15, 5);

            WaitForCondition(IsDownloadComplete,
                "Message if wait failed by timeout.", typeof(Exception), 15, 5);

            Assert.That(IsDownloadComplete(), "Actual text after " +
                $"downloading '{actualText}' is not equal '{expectedText}'.");
        }

        private void WaitForCondition(Func<IWebDriver, bool> func, string errorMessage,
            Type exceptionType, int timeout, int poolingInterval)
        {            
            wait.Timeout = TimeSpan.FromSeconds(timeout);
            wait.PollingInterval = TimeSpan.FromSeconds(poolingInterval);
            wait.Message = errorMessage;
            wait.IgnoreExceptionTypes(exceptionType);
            wait.Until(func);
        }

        private void WaitForCondition(Func<bool> func, string errorMessage, Type exceptionType, 
            int timeout, int poolingInterval) => WaitForCondition(driver => func(), errorMessage, exceptionType, timeout, poolingInterval);
    }
}
