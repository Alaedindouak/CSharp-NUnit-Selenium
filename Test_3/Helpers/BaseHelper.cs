using OpenQA.Selenium;

namespace Test_3
{
    public class BaseHelper
    {
        protected AppManager manager;
        protected IWebDriver driver;
        
        public BaseHelper(AppManager manager)
        {
            this.manager = manager;
            this.driver = manager.Driver;
        }
    }
}