﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace ConsoleApp1
{
    class SeleniumSetMethods
    {
        //Enter Text
        public static void EnterText(string element, string value, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //Click into a button, checkbox, option btn
        public static void Click(string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            if (elementtype == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
        }


        //Selecting a drop down contorl
        public static void SelectDropDown(string element,string value, PropertyType elementtype)
        { 
            if (elementtype == PropertyType.Id)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == PropertyType.Name)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
        }




    }
}
