using ImrielTest;
using ImrielTest.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests
{
    [TestFixture]
    public class AutocompleteTest: BaseClass
    {
        [SetUp]
        public void setup()
        {
            driver.Url = "https://www.rahulshettyacademy.com/AutomationPractice/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
        }

        [Test]
        public void AuthenticationTest()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("autocomplete")));
            AutoComplete.CountryTextBoxAuto.SendKeys("Ind");

            //List<IWebElement> countrylist = (driver.FindElements(By.ClassName("inputs ui-autocomplete-input"));
            var countrylist = (driver.FindElements(By.ClassName("inputs ui-autocomplete-input")));
            

            




        }
    }
}
