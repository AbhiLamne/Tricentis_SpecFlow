using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Tricentis.Pages
{
    public class Select_Price_Option
    {
        private IWebDriver dr;

        public Select_Price_Option(IWebDriver dr)
        {
            this.dr = dr;
        }

        //WebElements
        By option = By.XPath("((//span[@class='ideal-radio'])[6])");
        //By download = By.Id("downloadquote");
        By button = By.Name("Next (Send Quote)");

        //Actions
        public void Priceoption()
        {
            dr.FindElement(option).Click();
            Thread.Sleep(2000);
        }


        //public void Download()
        //{
        //    dr.FindElement(download).Click();
        //    Thread.Sleep(2000);
        //}


        public void Button()
        {
            dr.FindElement(button).Click();
        }
        
    }
}
