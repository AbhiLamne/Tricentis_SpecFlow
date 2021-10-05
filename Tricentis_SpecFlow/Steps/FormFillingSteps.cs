using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Tricentis.Library;
using Tricentis.Pages;

namespace Tricentis_SpecFlow.Steps
{
    [Binding]
    public class FormFillingSteps
    {
        private IWebDriver dr;

        [Given(@"I have navigated to Tricentis website")]
        public void GivenIHaveNavigatedToTricentisWebsite()
        {
            ApplicationLibrary lib = new ApplicationLibrary();
            dr = lib.LaunchBrowser("Chrome");
        }

        [When(@"I fill all the details in form")]
        public void WhenIFillAllTheDetailsInForm()
        {

            Camper_Enter_Vehicle_Data EVD = new Camper_Enter_Vehicle_Data(dr);
            EVD.camper();
            EVD.make("Mercedes Benz");
            EVD.EnginePerformance("500");
            EVD.EnterDateOfManufacture(1, "August", 2020);
            EVD.NumberofSeats("2");
            EVD.RHDrive();
            EVD.FuelType("Electric Power");
            EVD.Payload("700");
            EVD.Totalweight("1000");
            EVD.ListPrice("100000");
            EVD.LPNumber("MH12");
            EVD.Milage("4000");
            EVD.Button();



            Camper_Enter_Insurance_Data EID = new Camper_Enter_Insurance_Data(dr);
            EID.FirstName("Abhishek");
            EID.LastName("Lamne");
            EID.EnterBirthdate(16, "January", 1994);
            EID.Gender();
            EID.StreetAddress("FC road");
            EID.Country("India");
            EID.Zipcode("445001");
            EID.City("Pune");
            EID.Occupation("Employee");
            EID.Hobbies();
            EID.Website("www.amazon.in");
            //EID.Picture();
            EID.Button();


            Camper_Enter_Product_Data EPD = new Camper_Enter_Product_Data(dr);
            EPD.EnterStartDate(16, "January", 2022);
            EPD.InsuranceSum("30000000");
            EPD.DamageInsurance("Full Coverage");
            EPD.OptionalProducts();
            EPD.Button();


            Camper_Select_Price_Option SPO = new Camper_Select_Price_Option(dr);
            SPO.Priceoption();
            //SPO.Download();
            SPO.Button();


            Camper_Send_Quote SQ = new Camper_Send_Quote(dr);
            SQ.Email("abhishek.lamne@Dataction.in");
            SQ.Phone("9988776655");
            SQ.Username("abhi123");
            SQ.Password("Abhi@123");
            SQ.ConfPass("Abhi@123");
            SQ.Comments("Hello! Thank You!");
            SQ.Send();

        }

        [Then(@"I should get the successful result")]
        public void ThenIShouldGetTheSuccessfulResult()
        {
            Console.WriteLine("Form filling for Camper is successfull");
        }

    }
}
