using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tricentis.Pages
{
    public class Camper_Enter_Product_Data
    {
        private IWebDriver dr;

        public Camper_Enter_Product_Data(IWebDriver dr)
        {
            this.dr = dr;
        }

        //WebElements
        By openStartDateIcon = By.Id("openstartdatecalender");
        By enterStartDate_Month = By.XPath("//div[@class='ui-datepicker-title']/span[@class='ui-datepicker-month']");
        By enterStartDate_Year = By.XPath("//div[@class='ui-datepicker-title']/span[@class='ui-datepicker-year']");
        By nextBtn = By.XPath("//a[@title='Next']");
        //By date = By.XPath("//a[@class='ui-state-default']");

        By Isum = By.Id("insurancesum");
        By DInsurance = By.Id("damageinsurance");
        By optionalp = By.XPath("((//span[@class='ideal-check'])[6])");
        By button = By.Id("nextselectpriceoption");

        //Actions
        public void StartDateIcon()
        {
            dr.FindElement(openStartDateIcon).Click();
        }
        public void EnterStartDate(int day, string month , int year)
        {
            StartDateIcon();

            //Year
            string actYear =dr.FindElement(enterStartDate_Year).Text;
            while (!actYear.Equals(year.ToString()))
            {
                dr.FindElement(nextBtn).Click();
                actYear = dr.FindElement(enterStartDate_Year).Text;
            }

            //Month
            string actMonth = dr.FindElement(enterStartDate_Month).Text;
            while (!actMonth.Equals(month.ToString()))
            {
                dr.FindElement(nextBtn).Click();
                actMonth = dr.FindElement(enterStartDate_Month).Text;
            }

            //Date
            dr.FindElement(By.XPath("//a[text()=" + day + "]")).Click();
        }
    
        public void InsuranceSum(string name)
        {
            IWebElement ele = dr.FindElement(Isum);
            SelectElement sel = new SelectElement(ele);
            sel.SelectByValue(name);
        }
        public void DamageInsurance(string name)
        {
            IWebElement ele = dr.FindElement(DInsurance);
            SelectElement sel = new SelectElement(ele);
            sel.SelectByValue(name);
        }
        public void OptionalProducts()
        {
            dr.FindElement(optionalp).Click();
        }
        public void Button()
        {
            dr.FindElement(button).Click();
        }
    }
}
