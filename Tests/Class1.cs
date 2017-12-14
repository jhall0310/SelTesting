using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    class Class1
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            //Redirecting to SEIS.org
            driver.Url = "http://beta.seis.org/";
        }
        }
}
