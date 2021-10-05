using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tricentis.Pages
{
    public class Camper_Enter_Insurance_Data
    {
        private IWebDriver dr;

        public Camper_Enter_Insurance_Data(IWebDriver dr)
        {
            this.dr = dr;
        }

        //WebElements
        By FName = By.Id("firstname");
        By LName = By.Id("lastname");

        By openBirhDateCalendar = By.Id("opendateofbirthcalender");
        By Birth_Month = By.XPath("//div[@class='ui-datepicker-title']/span[@class='ui-datepicker-month']");
        By Birth_Year = By.XPath("//div[@class='ui-datepicker-title']/span[@class='ui-datepicker-year']");
        By previousBtn = By.XPath("//a[@title='Prev']");
        By Birth_Date = By.XPath("//a[@class='ui-state-default']");

        By gender = By.XPath("((//span[@class='ideal-radio'])[2])");
        By saddress = By.Id("streetaddress");
        By country = By.Id("country");
        By zipcode = By.Id("zipcode");
        By city = By.Id("city");
        By occupation = By.Id("occupation");
        By hobbies = By.XPath("((//span[@class='ideal-check'])[2])");
        By website = By.Id("website");
        //By picture = By.Id("open");
        By button = By.Name("Next (Enter Product Data)");


        //Actions
        public void FirstName(string a)
        {
            dr.FindElement(FName).SendKeys(a);
        }
        public void LastName(string a)
        {
            dr.FindElement(LName).SendKeys(a);
        }
        public void BirthdateCalendar()
        {
            dr.FindElement(openBirhDateCalendar).Click();
        }
        public void EnterBirthdate(int day, string month, int year)
        {
            BirthdateCalendar();

            string actYear=dr.FindElement(Birth_Year).Text;
            while (!actYear.Equals(year.ToString()))
            {
                dr.FindElement(previousBtn).Click();
                actYear = dr.FindElement(Birth_Year).Text;
            }

            string actMonth = dr.FindElement(Birth_Month).Text;
            while (!actYear.Equals(year.ToString()))
            {
                dr.FindElement(previousBtn).Click();
                actMonth = dr.FindElement(Birth_Month).Text;
            }

            dr.FindElement(Birth_Date).Click();
        }

        public void Gender()
        {
            dr.FindElement(gender).Click();
        }
        public void StreetAddress(string a)
        {
            dr.FindElement(saddress).SendKeys(a);
        }
        public void Country(string name)
        {
            IWebElement ele = dr.FindElement(country);
            SelectElement sel = new SelectElement(ele);
            sel.SelectByValue(name);
        }
        public void Zipcode(string a)
        {
            dr.FindElement(zipcode).SendKeys(a);
        }
        public void City(string a)
        {
            dr.FindElement(city).SendKeys(a);
        }
        public void Occupation(string name)
        {
            IWebElement ele = dr.FindElement(occupation);
            SelectElement sel = new SelectElement(ele);
            sel.SelectByValue(name);
        }
        public void Hobbies()
        {
            dr.FindElement(hobbies).Click();
        }
        public void Website(string a)
        {
            dr.FindElement(website).SendKeys(a);
        }
        //public void Picture()
        //{
        //    dr.FindElement(picture).Click();
        //}
        public void Button()
        {
            dr.FindElement(button).Click();
        }
    }

    
}
