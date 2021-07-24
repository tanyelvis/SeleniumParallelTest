using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;


namespace SeleniumParallelTest2
{
    public enum BrowerType
    {
        Chrome,
        Firefox,
        IE
    }

    [TestFixture]
    // initialising the driver object
    public class Hooks : Base
    {
        private BrowerType _browserType;

        public Hooks(BrowerType browser)
        {
            //Driver = new FirefoxDriver();
            _browserType = browser;
        }


        [SetUp]
        public void InitializeTest()
        {
            ChooseDriverInstance(_browserType);
        }
        public void ChooseDriverInstance(BrowerType browerType)
        {
            if (browerType == BrowerType.Chrome)
                Driver = new ChromeDriver();
            else if (browerType == BrowerType.Firefox)
                Driver = new FirefoxDriver();
           // else if (browerType == BrowerType.IE)
             //   Driver = new IEDriver();
        }
    }
}
