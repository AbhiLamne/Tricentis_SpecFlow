using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;

namespace Tricentis_SpecFlow.Drivers
{
    public class ParallelConfig
    {

        private IWebDriver dr;

        public MediaEntityModelProvider CaptureScreenshot(string Name)
        {
            var screenshot = ((ITakesScreenshot)dr).GetScreenshot().AsBase64EncodedString;

            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, Name).Build();

        }

        //public static string Capture(IWebDriver dr)
        //{
        //    ITakesScreenshot ts = (ITakesScreenshot)dr;
        //    Screenshot screenshot = ts.GetScreenshot();
        //    string assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        //    string finalpth = assemblyFolder + "\\Tricentis_SpecFlow\\Extent_Report\\";
        //    string screenshotDir = finalpth + screenshot + ".png";
        //    string localpath = new Uri(screenshotDir).LocalPath;
        //    screenshot.SaveAsFile(localpath);
        //    return localpath;
        //}
    }
    
}
