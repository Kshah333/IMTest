using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace ImrielTest.Pages
{
    public class RegistrationForm: BaseClass
    {
        public RegistrationForm()
        {
            string name = "Basic Registration form";
        }

        //controls
        public static IWebElement FirstNameTextBox = driver.FindElement(By.Name("first_name"));
        public static IWebElement LastNameTextBox = driver.FindElement(By.Name("last_name"));
        public static IWebElement EmailTextBox = driver.FindElement(By.Name("email"));
        public static IWebElement PhoneNumTextBox = driver.FindElement(By.Name("phone"));
        public static IWebElement AddressTextBox = driver.FindElement(By.Name("address"));
        public static IWebElement CityTextBox = driver.FindElement(By.Name("city"));
        public static IWebElement State = driver.FindElement(By.Name("state"));
        public static IWebElement ZipTextBox = driver.FindElement(By.Name("zip"));
        public static IWebElement WebsiteTextBox = driver.FindElement(By.Name("website"));
        public static IWebElement HostingYes = driver.FindElement(By.XPath("//label/input[@value='yes']"));
        public static IWebElement HostingNo = driver.FindElement(By.XPath("//label/input[@value='no']"));
        public static IWebElement Submit = driver.FindElement(By.XPath("//button[@type='submit']"));
        public static IWebElement ProjectDesc = driver.FindElement(By.Name("comment"));
         

        //methods
        public static void FillData(string path)
        {  
            Excel.Application App;
            Excel.Workbook WorkBook;
            Excel.Worksheet WorkSheet;
            Excel.Range range;
            
            App = new Excel.Application();
            WorkBook = App.Workbooks.Open(@path);
            WorkSheet = (Excel.Worksheet)WorkBook.Sheets[1];
            range = WorkSheet.UsedRange;
            int rowCnt = range.Rows.Count;
            string[] data = { };
            for (int i=0; i< rowCnt; i++)
            {
                data[i] = WorkSheet.Cells[i,1].ToString();
            }

            FirstNameTextBox.SendKeys(data[0]);
            LastNameTextBox.SendKeys(data[1]);
            EmailTextBox.SendKeys(data[2]);
            PhoneNumTextBox.SendKeys(data[3]);
            AddressTextBox.SendKeys(data[4]);
            CityTextBox.SendKeys(data[5]);

            SelectElement sel = new SelectElement(State);
            sel.SelectByText(data[6]);

            ZipTextBox.SendKeys(data[7]);
            WebsiteTextBox.SendKeys(data[8]);
            if(data[9].ToLower().ToString()=="yes")
            {
                HostingYes.Click();
            }
            else
            {
                HostingNo.Click();
            }
            ProjectDesc.SendKeys(data[10]);
            Submit.Click();
            App.Quit();

            Marshal.ReleaseComObject(WorkSheet);
            Marshal.ReleaseComObject(WorkBook);
            Marshal.ReleaseComObject(App);
        }
    }
}
