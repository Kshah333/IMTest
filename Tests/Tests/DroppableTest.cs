using ImrielTest;
using ImrielTest.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;



namespace Tests.Tests
{
    [TestFixture]
    public class DroppableTest: BaseClass
    {
            [SetUp]
            public void setup()
            {
                driver.Url = "https://demoqa.com/droppable/";
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            }

            [Test]
            public void DropTest()
            {
                var source = driver.FindElement(By.Id("draggable"));
                var dest = driver.FindElement(By.Id("droppable"));
                Actions act = new Actions(driver);
                act.DragAndDrop(source,dest).Build().Perform();
                Assert.IsTrue(dest.Text.Contains("Dropped!"));
            }
    }
}
