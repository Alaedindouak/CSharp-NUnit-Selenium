using OpenQA.Selenium;

namespace Test_4
{
    public class BaseHelper
    {
        private AppManager manager;
        protected readonly IWebDriver driver;
        
        protected BaseHelper(AppManager manager)
        {
            this.manager = manager;
            driver = manager.Driver;
        }
    }
}