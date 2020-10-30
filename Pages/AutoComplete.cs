using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImrielTest.Pages
{
    public class AutoComplete: BaseClass
    {
        public static IWebElement CountryTextBoxAuto= driver.FindElement(By.Id("autocomplete"));


    }
}
