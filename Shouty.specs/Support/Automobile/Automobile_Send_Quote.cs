﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tricentis.Pages
{
    public class Automobile_Send_Quote
    {
        private IWebDriver dr;

        public Automobile_Send_Quote(IWebDriver dr)
        {
            this.dr = dr;
        }

        //WebElements
        By email = By.Id("email");
        By phone = By.Id("phone");
        By username = By.Id("username");
        By password = By.Id("password");
        By confpass = By.Id("confirmpassword");
        By comments = By.Id("Comments");
        By send = By.Id("sendemail");

        public void Email(string a)
        {
            dr.FindElement(email).SendKeys(a);
        }
        public void Phone(string a)
        {
            dr.FindElement(phone).SendKeys(a);
        }
        public void Username(string a)
        {
            dr.FindElement(username).SendKeys(a);
        }
        public void Password(string a)
        {
            dr.FindElement(password).SendKeys(a);
        }
        public void ConfPass(string a)
        {
            dr.FindElement(confpass).SendKeys(a);
        }
        public void Comments(string a)
        {
            dr.FindElement(comments).SendKeys(a);
        }
        public void Send()
        {
            dr.FindElement(send).Click();
        }
    }
}
