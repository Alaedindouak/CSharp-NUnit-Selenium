using System.Threading;
using OpenQA.Selenium;
using Test_3.Models;

namespace Test_3
{
    public class AccountHelper : BaseHelper
    {
        public AccountHelper(AppManager manager) : base(manager)
        {
            
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
    }
}