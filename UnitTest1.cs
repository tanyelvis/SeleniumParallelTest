using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumParallelTest2 
{
    [TestFixture]
    public class FirefoxTesting  : Hooks
    {
       

        [Test]
        public void FirefoxGoogleTest()
        {
            Driver.Navigate().GoToUrl("https://www.google.com/");
            Driver.FindElement(By.Id("L2AGLb")).Click();
            Driver.FindElement(By.Name("q")).SendKeys("Selenium");
            Driver.FindElement(By.Name("btnG")).Click();
            //Thread.Sleep(50);
           

            Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true), 
                                        "The text Selenium does not exist");


        }
        
        
    }


    [TestFixture]
    public class ChromeTesting : Hooks
    {
        [Test]
        public void ChromeGoogleTest()
        {
            Driver.Navigate().GoToUrl("https://www.google.com/");
            Driver.FindElement(By.Id("L2AGLb")).Click();
            Driver.FindElement(By.Name("q")).SendKeys("ExecuteAutomation");
            Driver.FindElement(By.Name("btnG")).Click();
            Assert.That(Driver.PageSource.Contains("ExecuteAutomation"), Is.EqualTo(true),
                                        "The text ExecuteAutomation does not exist");


        }

        
    }

}
