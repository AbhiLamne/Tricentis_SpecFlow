using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tricentis.Pages
{
    public class BaseClass 
    {
        private IWebDriver dr;

        public BaseClass(IWebDriver dr)
        {
            this.dr = dr;
        }

        public void EnterVehicleData()
        {
            Enter_Vehicle_Data camp = new Enter_Vehicle_Data(dr);
            camp.camper();
            camp.make("Mercedes Benz");
            camp.EnginePerformance("500");         
            camp.EnterDateOfManufacture(1, "August", 2020);
            camp.NumberofSeats("2");
            camp.RHDrive();
            camp.FuelType("Electric Power");
            camp.Payload("700");
            camp.Totalweight("1000");
            camp.ListPrice("100000");
            camp.LPNumber("MH12");
            camp.Milage("4000");
            camp.Button();
        }

        public void EnterInsuranceData()
        {
            Enter_Insurance_Data ID = new Enter_Insurance_Data(dr);
            ID.FirstName("Abhishek");
            ID.LastName("Lamne");
            ID.EnterBirthdate(16, "January", 1994);
            ID.Gender();
            ID.StreetAddress("FC road");
            ID.Country("India");
            ID.Zipcode("445001");
            ID.City("Pune");
            ID.Occupation("Employee");
            ID.Hobbies();
            ID.Website("www.amazon.in");
            //ID.Picture();
            ID.Button();
        }

        public void EnterProductData()
        {
            Enter_Product_Data PD = new Enter_Product_Data(dr);
            PD.EnterStartDate(16, "January", 2022);
            PD.InsuranceSum("30000000");
            PD.DamageInsurance("Full Coverage");
            PD.OptionalProducts();
            PD.Button();

        }

        public void SelectPriceOption()
        {
            Select_Price_Option PO = new Select_Price_Option(dr);
            PO.Priceoption();
            //PO.Download();
            PO.Button();
        }

        public void SendQuote()
        {
            Send_Quote SQ = new Send_Quote(dr);
            SQ.Email("abhishek.lamne@Dataction.in");
            SQ.Phone("9988776655");
            SQ.Username("abhi123");
            SQ.Password("Abhi@123");
            SQ.ConfPass("Abhi@123");
            SQ.Comments("Hello! Thank You!");
            SQ.Send();
        }


    }
}
