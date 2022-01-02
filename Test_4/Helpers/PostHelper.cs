using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using Test_4.Models;

namespace Test_4
{
    public class PostHelper : BaseHelper
    {
        public PostHelper(AppManager manager) : base(manager){ }

        public PostData GetPostData()
        {
            string title = driver.FindElement(By.ClassName("fs-3xl")).Text;
            Thread.Sleep(3000);
            string tag = driver.FindElement(By.ClassName("crayons-tag")).Text;
            Thread.Sleep(3000);
            string content = driver.FindElement(By.Id("article-body")).Text;
            Thread.Sleep(3000);
            
            string nTag = tag.Remove(0, 2);
            return new PostData(title, nTag, content);
        }
        
        public void CreatePost(PostData post)
        {
            driver.FindElement(By.LinkText("Create Post")).Click();
            Thread.Sleep(3000);
            
            SetElementById("article-form-title", post.Title);
            SetElementById("tag-input", post.Tag);
            SetElementById("article_body_markdown", post.Content);
            
            driver.FindElement(By.XPath("//form[@id='article-form']/div[4]/button")).Click();            
            Thread.Sleep(3000);
        }
        
        public void EditPost(PostData post)
        {
            driver.FindElement(By.LinkText("Edit")).Click();
            Thread.Sleep(3000);
            
            EditElementById("article-form-title", post.Title);
            EditElementById("tag-input", post.Tag);
            EditElementById("article_body_markdown", post.Content);
            
            driver.FindElement(By.XPath("//form[@id='article-form']/div[4]/button")).Click();
            Thread.Sleep(3000);
        }

        // public void DeletePost()
        // {
        //     driver.FindElement(By.LinkText("Manage")).Click();
        //     Thread.Sleep(2000);
        //     driver.FindElement(By.LinkText("Delete")).Click();
        //     Thread.Sleep(2000);
        //     driver.FindElement(By.XPath("//main[@id='main-content']/div[2]/form/button")).Click();
        // }
        
        private void SetElementById(string element, string elementData)
        {
            driver.FindElement(By.Id(element)).Clear();
            driver.FindElement(By.Id(element)).SendKeys(elementData);
            Thread.Sleep(1000);
        }
        
        private void EditElementById(string element, string elementData)
        {
            driver.FindElement(By.Id(element))
                  .SendKeys($"{Keys.Control}, {Keys.Shift}, {Keys.Home}, {Keys.Backspace}");
            driver.FindElement(By.Id(element)).SendKeys(elementData);
            Thread.Sleep(1000);
        }

        
    }
}