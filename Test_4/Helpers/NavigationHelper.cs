using System.Threading;
using OpenQA.Selenium;
using Test_4.Models;

namespace Test_4
{
    public class NavigationHelper : BaseHelper
    {
        private readonly string BaseURL;
        
        public NavigationHelper(AppManager manager, string baseUrl) : base(manager)
        {
            BaseURL = baseUrl;
        }
        
        public void OpenPageHome()
        {
            driver.Navigate().GoToUrl(BaseURL);
        }
    }
}