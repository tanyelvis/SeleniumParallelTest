using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumParallelTest2 
{
    [TestFixture]
    [Parallelizable]
    public class FirefoxTesting  : Hooks
    {

        public FirefoxTesting() : base(BrowerType.Firefox)
        {

        }
       

        [Test]
        public void FirefoxGoogleTest()
        {
            Driver.Navigate().GoToUrl("https://www.google.com/");
            Driver.FindElement(By.Id("L2AGLb")).Click();
            Driver.FindElement(By.Name("q")).SendKeys("Selenium");
            Driver.FindElement(By.Name("btnG")).Click();
            //Thread.Sleep(50);

            System.Threading.Thread.Sleep(20000);
            Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true), 
                                        "The text Selenium does not exist");


        }
        
        
    }


    [TestFixture]
    [Parallelizable]
    public class ChromeTesting : Hooks
    {
        public ChromeTesting() : base(BrowerType.Chrome)
        {
        }

        [Test]
        public void ChromeGoogleTest()
        {
            Driver.Navigate().GoToUrl("https://www.google.com/");
            Driver.FindElement(By.Id("L2AGLb")).Click();
            Driver.FindElement(By.Name("q")).SendKeys("ExecuteAutomation");
            Driver.FindElement(By.Name("btnG")).Click();
            System.Threading.Thread.Sleep(20000);

            Assert.That(Driver.PageSource.Contains("ExecuteAutomation"), Is.EqualTo(true),
                                        "The text ExecuteAutomation does not exist");


        }

        
    }


   // [TestFixture]
    //[Parallelizable]
    //public class IETesting : Hooks
   // {
     //   public IETesting(BrowerType browser) : base(browser)
       // {
        //}

        //[Test]
        //public void IEGoogleTest()
       // {
         //   Driver.Navigate().GoToUrl("https://www.google.com/");
           // Driver.FindElement(By.Id("L2AGLb")).Click();
            //Driver.FindElement(By.Name("q")).SendKeys("ExecuteAutomation");
            //Driver.FindElement(By.Name("btnG")).Click();
            //System.Threading.Thread.Sleep(20000);

            //Assert.That(Driver.PageSource.Contains("ExecuteAutomation"), Is.EqualTo(true),
               //                         "The text ExecuteAutomation does not exist");
    //

      //  }


    //}

}
