using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Tricentis.Library;
using Tricentis.Pages;

namespace Tricentis.Test
{
    [TestFixture]
    class TestClass1
    {
        IWebDriver dr;

        [SetUp]
        public void Initialize()
        {
            ApplicationLibrary lib = new ApplicationLibrary();
            dr = lib.LaunchBrowser("Chrome");

        }
     

        [Test]
        public void Test1()
        {
            BaseClass Base = new BaseClass(dr);
            Base.EnterVehicleData();
            Base.EnterInsuranceData();
            Base.EnterProductData();
            Base.SelectPriceOption();
            Base.SendQuote();

        }


        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Closing the session");
        }
    }
}
