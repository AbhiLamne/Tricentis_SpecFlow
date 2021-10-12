using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tricentis.Pages
{
    public class Camper_Enter_Vehicle_Data
    {
        private IWebDriver dr;

        public Camper_Enter_Vehicle_Data(IWebDriver dr)
        {
            this.dr = dr;
        }

        //WebElements
        By page = By.Name("Navigation Camper");
        By Make = By.Name("Make");
        By EngineP = By.Id("engineperformance");

        By opencalendarIcon = By.Id("opendateofmanufacturecalender");
        By dateOfManufacture_Month = By.XPath("//div[@class='ui-datepicker-title']/span[@class='ui-datepicker-month']");
        By dateOfManufacture_Year = By.XPath("//div[@class='ui-datepicker-title']/span[@class='ui-datepicker-year']");
        By previousBtn = By.XPath("//a[@title='Prev']");
        
        By Seats = By.Name("Number of Seats");
        By RHD = By.CssSelector("span[class='ideal-radio']");
        By Fuel = By.Name("Fuel Type");
        By payload = By.Name("Payload");
        By totalweight = By.Id("totalweight");
        By listprice = By.Id("listprice");
        By LPN = By.Id("licenseplatenumber");
        By milage = By.Id("annualmileage");
        By button = By.Id("nextenterinsurantdata");

        //Actions
        public void camper()
        {
            dr.FindElement(page).Click();
        }

        public void make(string comapny)
        {
            IWebElement ele=dr.FindElement(Make);
            SelectElement sel = new SelectElement(ele);
            sel.SelectByValue(comapny);
        }
        public void EnginePerformance(string a)
        {
            dr.FindElement(EngineP).SendKeys(a);
        }



        public void opencalendar()
        {
            dr.FindElement(opencalendarIcon).Click();
        }
        public void EnterDateOfManufacture(int day, string month, int year)
        {
            opencalendar();

            //Year
            string actYear=dr.FindElement(dateOfManufacture_Year).Text;

            while (!actYear.Equals(year.ToString()))
            {
                dr.FindElement(previousBtn).Click();
                actYear = dr.FindElement(dateOfManufacture_Year).Text;
            }

            //Month
            string actmonth = dr.FindElement(dateOfManufacture_Month).Text;

            while (!actmonth.Equals(month.ToString()))
            {
                dr.FindElement(previousBtn).Click();
                actmonth = dr.FindElement(dateOfManufacture_Month).Text;
            }

            //Date
            dr.FindElement(By.XPath("//a[text()=" + day + "]")).Click();
        }




        public void NumberofSeats(string number)
        {
            IWebElement ele = dr.FindElement(Seats);
            SelectElement sel = new SelectElement(ele);
            sel.SelectByValue(number);
        }
        public void RHDrive()
        {
            dr.FindElement(RHD).Click();
        }
        public void FuelType(string a)
        {
            IWebElement ele = dr.FindElement(Fuel);
            SelectElement sel = new SelectElement(ele);
            sel.SelectByValue(a);
        }
        public void Payload(string a)
        {
            dr.FindElement(payload).SendKeys(a);
        }
        public void Totalweight(string a)
        {
            dr.FindElement(totalweight).SendKeys(a);
        }
        public void ListPrice(string a)
        {
            dr.FindElement(listprice).SendKeys(a);
        }
        public void LPNumber(string a)
        {
            dr.FindElement(LPN).SendKeys(a);
        }
        public void Milage(string a)
        {
            dr.FindElement(milage).SendKeys(a);
        }
        public void Button()
        {
            dr.FindElement(button).Click();
        }
    }
}
