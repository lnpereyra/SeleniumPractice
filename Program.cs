using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {



        }


        [SetUp]
        public void Initialize()
        {

            PropertiesCollection.driver = new ChromeDriver();
            //Navigate to Google
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Opened URL");
        }

        
        [Test]
        public void ExecuteTest()
        {
            //Title
            SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            //Initial
            SeleniumSetMethods.EnterText("Initial", "Executeautomation", PropertyType.Name);

            Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetTextFromDDL("TitleId",PropertyType.Id));
            
            Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            //Click
            SeleniumSetMethods.Click("Save", PropertyType.Name);

        }


        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();

            Console.WriteLine("Browser closed");
        }


    }
}
