using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Tests
{
    public static class Browser
    {
        static IWebDriver webDriver = new ChromeDriver();
        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static void Goto(string url)
        {
            webDriver.Url = url;
        }
    }
}