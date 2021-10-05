using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tricentis.Library
{
    public class ApplicationLibrary
    {

        public IWebDriver LaunchBrowser(string BrowserName)
        {
            IWebDriver dr = new ChromeDriver();

            dr.Navigate().GoToUrl("http://sampleapp.tricentis.com/101/#");

            dr.Manage().Window.Maximize();

            return dr;
        }
    }
}
