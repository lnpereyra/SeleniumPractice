using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName

    }

    class PropertiesCollection
    {


        //Autoimplemented Property
        public static IWebDriver driver { get; set; }


    }
}
