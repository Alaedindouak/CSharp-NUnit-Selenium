using NUnit.Framework;

namespace Test_4
{
    public class TestBase
    {
        protected AppManager app;

        [SetUp]
        public void SetupTest()
        {
            app = AppManager.GetInstance();
        }

    }
}