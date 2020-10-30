using ImrielTest;
using ImrielTest.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests
{
    [TestFixture]
    public class RegistrationTest: BaseClass
    {

        [SetUp]
        public void setup()
        {
            driver.Url = "https://www.seleniumeasy.com/test/input-form-demo.html";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
        }

        [Test]
        public void RegTest()
        {
            string path = "D://Info.xlsx";
            RegistrationForm.FillData(path);
        }
    }
}
