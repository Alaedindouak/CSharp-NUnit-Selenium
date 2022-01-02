using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Test_3
{
    public class AppManager
    {
        protected IWebDriver driver;
        protected StringBuilder verificationErrors;
        protected string baseURL;
        protected bool acceptNextAlert = true;
        
        private NavigationHelper navigation;
        private LoginHelper auth;
        private AccountHelper account;

        public AppManager()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            baseURL = "https://dev.to";
            verificationErrors = new StringBuilder();
            account = new AccountHelper(this);
            auth = new LoginHelper(this);
            navigation = new NavigationHelper(this, baseURL);
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

        public LoginHelper Auth
        {
            get
            {
                return auth;
            }
        }

        public AccountHelper AccountHelper
        {
            get
            {
                return account;
            }
        }

        public void stop()
        {
            driver.Quit();
        }

    }
}