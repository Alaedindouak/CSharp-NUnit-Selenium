using System;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Test_3;


namespace Test_1
{
    public class TestBase
    {
        protected AppManager app;
        
        [OneTimeSetUp]
        public void SetupTest()
        {
            app = new AppManager();
        }
        
        [OneTimeTearDown]
        public void TeardownTest()
        {
            app.stop();
        }

        // protected bool IsElementPresent(By by)
        // {
        //     try
        //     {
        //         driver.FindElement(by);
        //         return true;
        //     }
        //     catch (NoSuchElementException)
        //     {
        //         return false;
        //     }
        // }
        //
        // protected bool IsAlertPresent()
        // {
        //     try
        //     {
        //         driver.SwitchTo().Alert();
        //         return true;
        //     }
        //     catch (NoAlertPresentException)
        //     {
        //         return false;
        //     }
        // }
        //
        // protected string CloseAlertAndGetItsText() {
        //     try {
        //         var alert = driver.SwitchTo().Alert();
        //         var alertText = alert.Text;
        //         if (acceptNextAlert) {
        //             alert.Accept();
        //         } else {
        //             alert.Dismiss();
        //         }
        //         return alertText;
        //     } finally {
        //         acceptNextAlert = true;
        //     }
        // }
    }
}