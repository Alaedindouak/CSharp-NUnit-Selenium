using System;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace Test_1
{
    public class TestBase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL = "https://dev.to";
        private bool acceptNextAlert = true;
        
        [OneTimeSetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            verificationErrors = new StringBuilder();
            OpenPageHome();
        }
        
        [OneTimeTearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        public void CreatePost(PostData post)
        {
            driver.FindElement(By.LinkText("Write your first post now")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("article-form-title")).Click();
            driver.FindElement(By.Id("article-form-title")).Clear();
            driver.FindElement(By.Id("article-form-title")).SendKeys(post.Title);
            driver.FindElement(By.Id("tag-input")).Clear();
            driver.FindElement(By.Id("tag-input")).SendKeys(post.Tag);
            driver.FindElement(By.Id("article_body_markdown")).Click();
            driver.FindElement(By.Id("article_body_markdown")).Clear();
            driver.FindElement(By.Id("article_body_markdown")).SendKeys(post.Content);
            driver.FindElement(By.XPath("//form[@id='article-form']/div[4]/button")).Click();
            Thread.Sleep(5000);
        }

        public void OpenDashboard()
        {
            driver.FindElement(By.Id("nav-profile-image")).Click();
            driver.FindElement(By.LinkText("Dashboard")).Click();
            Thread.Sleep(5000);
        }

        public void Login(AccountData user)
        {   
            driver.FindElement(By.LinkText("Log in")).Click();
            driver.FindElement(By.XPath("//div[@id='page-content-inner']/section/div/div[2]/div/form[2]/button")).Click();
            driver.FindElement(By.Id("login_field")).Clear();
            driver.FindElement(By.Id("login_field")).SendKeys(user.Email);
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys(user.Password);
            driver.FindElement(By.Name("commit")).Click();
            Thread.Sleep(5000);
        }

        

        public void OpenPageHome()
        {
            driver.Navigate().GoToUrl(baseURL);
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                var alert = driver.SwitchTo().Alert();
                var alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}