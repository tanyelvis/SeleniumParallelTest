

using OpenQA.Selenium;

namespace SeleniumParallelTest2


// so as to use only one object in the webdriverin the whole code
{
   public class Base
    {
        public IWebDriver Driver { get; set; }
    }
}
