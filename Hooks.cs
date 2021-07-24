using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using System;


namespace SeleniumParallelTest2
{

    [TestFixture]
    // initialising the driver object
    public class Hooks : Base
    {
        public Hooks()
        {
            Driver = new FirefoxDriver();


        }

    }
}
