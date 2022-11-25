//Inside SeleniumTest.cs

using NUnit.Framework;

using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;

using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

using System.Collections.ObjectModel;

using System.IO;

namespace TestProject1

{

    public class Tests

    {

        IWebDriver driver;

        [SetUp]

        public void Setup()

        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.tmsandbox.co.nz/");
            driver.Manage().Window.Maximize();

        }

        [Test]

        public void verifyBrowser()

        {
            IWebElement openContent = driver.FindElement (By.Id("SiteHeader_SiteTabs_browseDropDownLink"));
            openContent.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            IWebElement gaming = driver.FindElement(By.XPath("//a[contains(@href,'gaming')]"));
            gaming.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
           

        }

         [Test]
          public void createAccount()

          {
               IWebElement register = driver.FindElement(By.XPath("//a[contains(@href,'Register')]"));
               register.Click();
              driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
              IWebElement email = driver.FindElement(By.Id("LoginDetails_EmailAddressTextBox"));
              email.SendKeys("Deep123ND1@gmail.com");
              IWebElement password = driver.FindElement(By.Id("LoginDetails_PasswordTextBox"));
              password.SendKeys("Deee@12345");
              IWebElement confirmPassword = driver.FindElement(By.Id("LoginDetails_ConfirmPasswordTextBox"));
              confirmPassword.SendKeys("Deee@12345");
              IWebElement userName = driver.FindElement(By.Id("LoginDetails_UserNameTextBox"));
              userName.SendKeys("Deep123ND1");
              IWebElement firstName = driver.FindElement(By.Id("ContactDetails_FirstNameTextBox"));
              firstName.SendKeys("Deep123DD");
              IWebElement lastName = driver.FindElement(By.Id("ContactDetails_LastNameTextBox"));
              lastName.SendKeys("DDBBEEE");
              IWebElement gender = driver.FindElement(By.XPath("//label[contains(text(),'Female')]"));
              gender.Click();
            var day = driver.FindElement(By.Id("ContactDetails_DobDay"));
            SelectElement dayList = new SelectElement(day);
            dayList.SelectByText("9");

            SelectElement monthlist = new SelectElement(driver.FindElement(By.Id("ContactDetails_DobMonth")));
            monthlist.SelectByValue("9");
            IWebElement year = driver.FindElement(By.Id("ContactDetails_DobYear"));
            year.SendKeys("1989");
            IWebElement contact = driver.FindElement(By.Id("ContactDetails_ContactPhoneTextBox"));
            contact.SendKeys("02999997");
            IWebElement country = driver.FindElement(By.XPath("//label[contains(text(),'Zealand')]"));
            country.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement address = driver.FindElement(By.XPath("//input[@class='js-txt-search-address']"));
            address.SendKeys("99 Driver Crescent, Cannons Creek, Porirua");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement choose = driver.FindElement(By.XPath("//li[@tabindex='0'][1]/span[text()='99 Driver Crescent']"));
            choose.Click();

            SelectElement closestDristrict = new SelectElement(driver.FindElement(By.Id("ContactDetails_ClosestSuburbDropDown")));
            closestDristrict.SelectByValue("64");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement over18 = driver.FindElement(By.Id("TnCCheckbox"));
            over18.Click();
           
            IWebElement submit = driver.FindElement(By.Id("SubmitButton"));
            submit.Click();

        }

         [Test]


        public void listing()

         {

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(drv => drv.FindElement(By.XPath("//*[contains(text(),'Some book. Who reads anyway?')]")));
            IWebElement randomListing = driver.FindElement(By.XPath("//*[contains(text(),'Some book. Who reads anyway?')]"));
            randomListing.Click();
        }

      /* [TearDown]

       public void TearDown()

       {

           driver.Quit();

       }*/

    }

}