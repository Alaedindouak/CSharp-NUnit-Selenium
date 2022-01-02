using System.Threading;
using OpenQA.Selenium;
using Test_3.Models;

namespace Test_3
{
    public class LoginHelper : BaseHelper
    {
        public LoginHelper(AppManager manager) : base(manager)
        {
            
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
    }
}