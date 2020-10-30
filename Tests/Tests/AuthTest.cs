using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ImrielTest.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace ImrielTest.Tests
{
    [TestFixture]
    public class AuthTest: BaseClass
    {
        [SetUp]
        public void setup()
        {
            driver.Url = "http://the-internet.herokuapp.com/digest_auth";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
        }
        [TearDown]
        public void teardown()
        {  
        }

        [Test]
        public void AuthenticationTest()
        {
            string user = "admin";
            string pwd = "admin";

            string successmsg = "Congratulations! You must have the proper credentials.";
            Authentication.Login(user, pwd);
            Assert.IsTrue(driver.PageSource.Contains(successmsg));
        }
    }
}
