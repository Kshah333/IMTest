using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Microsoft.Office.Interop.Excel;


namespace ImrielTest.Pages
{
    public class Authentication: BaseClass
    {
        //Authentication test Controls

        public static IWebElement ele = driver.FindElement(By.Id(""));
        //No-param constructor
        public Authentication()
        {
            string testname = "Authentication";
        }

        //Methods
        public static void Login(string user, string pwd)
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.SetAuthenticationCredentials(user, pwd);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            alert.Accept();
        }


    }
}
