using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ImrielTest
{
    [TestFixture]
    public class BaseClass
    {
        public static IWebDriver driver;
        [OneTimeSetUp]
        public void init()
        {
           driver = new ChromeDriver();
           driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        [OneTimeTearDown]
        public void vanish()
        {
            driver.Close();
        }
        

    }
}
