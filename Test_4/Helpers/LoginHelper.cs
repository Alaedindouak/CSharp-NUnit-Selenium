using System.Threading;
using OpenQA.Selenium;
using Test_4.Models;

namespace Test_4
{
    public class LoginHelper : BaseHelper
    {
        public LoginHelper(AppManager manager) : base(manager) { }

        public void Login(AccountData user)
        {   
            driver.FindElement(By.LinkText("Log in")).Click();
            driver.FindElement(By.XPath("/html/body/div[8]/div/section/div/div[2]/div[1]/form[3]/button")).Click();
            SetElementById("login_field", user.Email);
            SetElementById("password", user.Password);
            
            driver.FindElement(By.Name("commit")).Click();
            Thread.Sleep(5000);
        }

        private void SetElementById(string element, string elementData)
        {
            driver.FindElement(By.Id(element)).Clear();
            driver.FindElement(By.Id(element)).SendKeys(elementData);
        }
    }
}