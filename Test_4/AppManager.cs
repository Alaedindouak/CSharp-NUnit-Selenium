using System;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Test_4
{
    public class AppManager
    {
        protected IWebDriver driver;
        protected StringBuilder verificationErrors;
        protected string baseURL;
        protected bool acceptNextAlert = true;
        
        private NavigationHelper navigation;
        private LoginHelper auth;
        private PostHelper post;

        private static ThreadLocal<AppManager> app = new ThreadLocal<AppManager>();
        private AppManager()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            baseURL = "https://dev.to";
            verificationErrors = new StringBuilder();
            post = new PostHelper(this);
            auth = new LoginHelper(this);
            navigation = new NavigationHelper(this, baseURL);
        }

        ~AppManager()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // ignore
            }
        }

        public static AppManager GetInstance()
        {
            if (!app.IsValueCreated)
            {
                AppManager newInstance = new AppManager();
                newInstance.Navigation.OpenPageHome();
                app.Value = newInstance;
            }

            return app.Value;
        }
        
        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }
        
        public NavigationHelper Navigation
        {
            get
            {
                return navigation;
            }
        }

        public LoginHelper Login
        {
            get
            {
                return auth;
            }
        }

        public PostHelper Post
        {
            get
            {
                return post;
            }
        }
        
    }
}