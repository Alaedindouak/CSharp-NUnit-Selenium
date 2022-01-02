using System;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Test_2_HW
{
    public class TestBase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        
        [OneTimeSetUp]
        public void Setup()
        {
            driver = new FirefoxDriver();
        }
        
        // [OneTimeTearDown]
        // public void TeardownTest()
        // {
        //     try
        //     {
        //         driver.Quit();
        //     }
        //     catch (Exception)
        //     {
        //         // Ignore errors if unable to close the browser
        //     }
        //     Assert.AreEqual("", verificationErrors.ToString());
        // }

        public void OpenHomepage()
        {
            driver.Navigate().GoToUrl("https://dev.to/");
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
        }

        public void CreatePost()
        {
            driver.FindElement(By.LinkText("Create Post")).Click();
            driver.FindElement(By.Id("article-form-title")).Click();
            driver.FindElement(By.Id("article-form-title")).Clear();
            driver.FindElement(By.Id("article-form-title")).SendKeys("Testing");
            driver.FindElement(By.Id("tag-input")).Click();
            driver.FindElement(By.Id("tag-input")).Clear();
            driver.FindElement(By.Id("tag-input")).SendKeys("automationtesting, csharp, selenium");
            driver.FindElement(By.Id("article_body_markdown")).Click();
            driver.FindElement(By.Id("article_body_markdown")).Clear();
            driver.FindElement(By.Id("article_body_markdown")).SendKeys("test");
            driver.FindElement(By.XPath("//form[@id='article-form']/div[4]/button")).Click();
        }
    }
}