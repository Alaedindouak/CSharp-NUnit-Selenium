using System.Threading;
using OpenQA.Selenium;
using Test_3.Models;

namespace Test_3
{
    public class NavigationHelper : BaseHelper
    {
        private string BaseURL;
        
        public NavigationHelper(AppManager manager, string baseUrl) : base(manager)
        {
            BaseURL = baseUrl;
        }
        
        public void OpenPageHome()
        {
            driver.Navigate().GoToUrl(BaseURL);
        }
        
        public void OpenDashboard()
        {
            driver.FindElement(By.Id("nav-profile-image")).Click();
            driver.FindElement(By.LinkText("Dashboard")).Click();
            Thread.Sleep(5000);
        }
    }
}