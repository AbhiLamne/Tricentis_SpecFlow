using AventStack.ExtentReports.Gherkin.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Tricentis_SpecFlow.Steps
{
    [Binding]
    
    public class FormFillingSteps 
    {

        private IWebDriver dr;

        public FormFillingSteps(IWebDriver dr)
        {
            this.dr = dr;
        }


        [Given(@"I have navigated to the Tricentis website")]
        public void GivenIHaveNavigatedToTheTricentisWebsite()
        {
            dr.Navigate().GoToUrl("http://sampleapp.tricentis.com/101/#");
            dr.Manage().Window.Maximize();                  
        }


        [When(@"I clicked on Camper")]
        public void WhenIClickedOnCamper()
        {
            dr.FindElement(By.Name("Navigation Camper")).Click();       
        }


        [Then(@"I see Enter Vehicle Data page is opened")]
        public void ThenISeeEnterVehicleDataPageIsOpened()
        {
            Console.WriteLine("Enter Vehicle Data page is opened");
        }

        [When(@"I select a data from dropdown for Make field as (.*)")]
        public void WhenISelectADataFromDropdownForMakeFieldAsMercedesBenz(string p0)
        {
            IWebElement ele = dr.FindElement(By.Name("Make"));
            SelectElement sel = new SelectElement(ele);
            sel.SelectByText(p0);
        }

        [When(@"I select a data from dropdown for Engine Performance field as (.*)")]
        public void WhenISelectADataFromDropdownForEnginePerformanceFieldAs(string p0)
        {
            By EngineP = By.Id("engineperformance");
            dr.FindElement(EngineP).SendKeys(p0);
        }


        [When(@"I select a date for Date Of Manufacture field as (.*) (.*) (.*)")]
        public void WhenISelectADateForDateOfManufactureFieldAs(int day, string month, int year)
        {
            By opencalendarIcon = By.Id("opendateofmanufacturecalender");
            By dateOfManufacture_Month = By.XPath("//div[@class='ui-datepicker-title']/span[@class='ui-datepicker-month']");
            By dateOfManufacture_Year = By.XPath("//div[@class='ui-datepicker-title']/span[@class='ui-datepicker-year']");
            By previousBtn = By.XPath("//a[@title='Prev']");


            dr.FindElement(opencalendarIcon).Click();

            //Year
            string actYear = dr.FindElement(dateOfManufacture_Year).Text;

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

        [When(@"I select a data from dropdown for Number of Seats field as (.*)")]
        public void WhenISelectADataFromDropdownForNumberOfSeatsFieldAs(string number)
        {
            By Seats = By.Name("Number of Seats");
            IWebElement ele = dr.FindElement(Seats);
            SelectElement sel = new SelectElement(ele);
            sel.SelectByValue(number);
        }

        [When(@"I click on Radio Button for Right Hand Drive field as (.*)")]
        public void WhenIClickOnRadioButtonForRightHandDriveFieldAs(string a)
        {
            By RHD = By.XPath("//input[@value=" + a + "]/following-sibling::span[@class='ideal-radio']");
            dr.FindElement(RHD).Click();
        }


        [When(@"I select a data from dropdown for Fuel Type field as (.*)")]
        public void WhenISelectADataFromDropdownForFuelTypeFieldAs(string a)
        {
            By Fuel = By.Name("Fuel Type");
            IWebElement ele = dr.FindElement(Fuel);
            SelectElement sel = new SelectElement(ele);
            sel.SelectByValue(a);
        }


        [When(@"I enter a data for Payload field as (.*)")]
        public void WhenIEnterADataForPayloadFieldAs(string p0)
        {
            By payload = By.Name("Payload");
            dr.FindElement(payload).SendKeys(p0);
        }


        [When(@"I enter a data for Total Weight field as (.*)")]
        public void WhenIEnterADataForTotalWeightFieldAs(string p0)
        {
            By totalweight = By.Id("totalweight");
            dr.FindElement(totalweight).SendKeys(p0);
        }


        [When(@"I enter a data for List Price field as (.*)")]
        public void WhenIEnterADataForListPriceFieldAs(string p0)
        {
            By listprice = By.Id("listprice");
            dr.FindElement(listprice).SendKeys(p0);
        }


        [When(@"I enter a data for License Plate Number field as (.*)")]
        public void WhenIEnterADataForLicensePlateNumberFieldAs(string p0)
        {
            By LPN = By.Id("licenseplatenumber");
            dr.FindElement(LPN).SendKeys(p0);
        }


        [When(@"I enter a data for Annual Mileage field as (.*)")]
        public void WhenIEnterADataForAnnualMileageFieldAs(string p0)
        {
            By milage = By.Id("annualmileage");
            dr.FindElement(milage).SendKeys(p0);
        }


        [When(@"I click on Next Button1")]
        public void WhenIClickOnNextButton1()
        {
            By button = By.Id("nextenterinsurantdata");
            dr.FindElement(button).Click();
        }

        [Then(@"I see the Enter Insurance Data page is opened")]
        public void ThenISeeTheEnterInsuranceDataPageIsOpened()
        {
            Console.WriteLine("Enter Insurance Data page is opened");
        }


        [Given(@"I opened the Tricentis website and navigated to Enter Insurance Data page")]
        public void GivenIOpenedTheTricentisWebsiteAndNavigatedToEnterInsuranceDataPage()
        {
            dr.Navigate().GoToUrl("http://sampleapp.tricentis.com/101/#");
            dr.Manage().Window.Maximize();
            dr.FindElement(By.Name("Navigation Camper")).Click();
            By button = By.Id("nextenterinsurantdata");
            dr.FindElement(button).Click();
        }


        [When(@"I enter a data for First Name field as (.*)")]
        public void WhenIEnterADataForFirstNameFieldAsJohn(string a)
        {
            By FName = By.Id("firstname");
            dr.FindElement(FName).SendKeys(a);
        }

        [When(@"I enter a data for Last Name field as (.*)")]
        public void WhenIEnterADataForLastNameFieldAsSmith(string a)
        {
            By LName = By.Id("lastname");
            dr.FindElement(LName).SendKeys(a);
        }


        [When(@"I select a date for Date of Birth field as (.*) (.*) (.*)")]
        public void WhenISelectADateForDateOfBirthFieldAsFebruary(int day, string month, int year)
        {
            By openBirhDateCalendar = By.Id("opendateofbirthcalender");
            By Birth_Month = By.XPath("//div[@class='ui-datepicker-title']/span[@class='ui-datepicker-month']");
            By Birth_Year = By.XPath("//div[@class='ui-datepicker-title']/span[@class='ui-datepicker-year']");
            By previousBtn = By.XPath("//a[@title='Prev']");

            dr.FindElement(openBirhDateCalendar).Click();

            string actYear = dr.FindElement(Birth_Year).Text;
            while (!actYear.Equals(year.ToString()))
            {
                dr.FindElement(previousBtn).Click();
                actYear = dr.FindElement(Birth_Year).Text;
            }

            string actMonth = dr.FindElement(Birth_Month).Text;
            while (!actMonth.Equals(month.ToString()))
            {
                dr.FindElement(previousBtn).Click();
                actMonth = dr.FindElement(Birth_Month).Text;
            }

            dr.FindElement(By.XPath("//a[text()=" + day + "]")).Click();
        }


        [When(@"I click on Radio Button for Gender as (.*)")]
        public void WhenIClickOnRadioButtonForGenderAs(string a)
        {
            By gender = By.XPath("//input[@value=" + a + "]/following-sibling::span[@class='ideal-radio']");
            dr.FindElement(gender).Click();
        }


        [When(@"I enter a data for Street Address field as (.*)")]
        public void WhenIEnterADataForStreetAddressFieldAs(string a)
        {
            By saddress = By.Id("streetaddress");
            dr.FindElement(saddress).SendKeys(a);
        }


        [When(@"I select a data from dropdown for Country field as (.*)")]
        public void WhenISelectADataFromDropdownForCountryFieldAs(string name)
        {
            By country = By.Id("country");
            IWebElement ele = dr.FindElement(country);
            SelectElement sel = new SelectElement(ele);
            sel.SelectByValue(name);
        }


        [When(@"I enter a data for Zip code field as (.*)")]
        public void WhenIEnterADataForZipCodeFieldAs(string a)
        {
            By zipcode = By.Id("zipcode");
            dr.FindElement(zipcode).SendKeys(a);
        }


        [When(@"I enter a data for City field as (.*)")]
        public void WhenIEnterADataForCityFieldAs(string a)
        {
            By city = By.Id("city");
            dr.FindElement(city).SendKeys(a);
        }


        [When(@"I select a data from dropdown for Occupation field as (.*)")]
        public void WhenISelectADataFromDropdownForOccupationFieldAs(string name)
        {
            By occupation = By.Id("occupation");
            IWebElement ele = dr.FindElement(occupation);
            SelectElement sel = new SelectElement(ele);
            sel.SelectByValue(name);
        }


        [When(@"I click on checkbox for Hobbies field as (.*)")]
        public void WhenIClickOnCheckboxForHobbiesFieldAs(string a)
        {
            By hobbies = By.XPath("//input[@value=" + a + "]/following-sibling::span[@class='ideal-check']");
            dr.FindElement(hobbies).Click();
        }
        

        [When(@"I enter a data for Website field as (.*)")]
        public void WhenIEnterADataForWebsiteFieldAs(string a)
        {
            By website = By.Id("website");
            dr.FindElement(website).SendKeys(a);
        }


        //[When(@"I select a file for Picture field as (.*)")]
        //public void WhenISelectAFileForPictureFieldAs(string a)
        //{
        //    By picture = By.Name("Open");
        //    dr.FindElement(picture).SendKeys(a);
        //    Thread.Sleep(3000);
        //}


        [When(@"I click on Next Button2")]
        public void WhenIClickOnNextButton2()
        {
            By button = By.Name("Next (Enter Product Data)");
            dr.FindElement(button).Click();
        }

        [Then(@"I see the Enter Product Data page is opened")]
        public void ThenISeeTheEnterProductDataPageIsOpened()
        {
            Console.WriteLine("Enter Product Data page is opened");
        }


        [Given(@"I opened the Tricentis website and navigated to Enter Product Data page")]
        public void GivenIOpenedTheTricentisWebsiteAndNavigatedToEnterProductDataPage()
        {
            dr.Navigate().GoToUrl("http://sampleapp.tricentis.com/101/#");
            dr.Manage().Window.Maximize();
            dr.FindElement(By.Name("Navigation Camper")).Click();
            By button = By.Name("Enter Product Data");
            dr.FindElement(button).Click();

        }


        [When(@"I select a date for Start Date field as (.*) (.*) (.*)")]
        public void WhenISelectADateForStartDateFieldAsMarch(int day, string month, int year)
        {
            By openStartDateIcon = By.Id("openstartdatecalender");
            By enterStartDate_Month = By.XPath("//div[@class='ui-datepicker-title']/span[@class='ui-datepicker-month']");
            By enterStartDate_Year = By.XPath("//div[@class='ui-datepicker-title']/span[@class='ui-datepicker-year']");
            By nextBtn = By.XPath("//a[@title='Next']");

            dr.FindElement(openStartDateIcon).Click();

            string actYear = dr.FindElement(enterStartDate_Year).Text;
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


        [When(@"I select a data for Insurance Sum as (.*)")]
        public void WhenISelectADataForInsuranceSumAs(string name)
        {
            By Isum = By.Id("insurancesum");
            IWebElement ele = dr.FindElement(Isum);
            SelectElement sel = new SelectElement(ele);
            sel.SelectByValue(name);
        }


        [When(@"I select a data for Damage Insurance as (.*)")]
        public void WhenISelectADataForDamageInsuranceAs(string name)
        {
            By DInsurance = By.Id("damageinsurance");
            IWebElement ele = dr.FindElement(DInsurance);
            SelectElement sel = new SelectElement(ele);
            sel.SelectByValue(name);
        }


        [When(@"I click on checkbox for Optional Products field as (.*)")]
        public void WhenIClickOnCheckboxForOptionalProductsFieldAs(string a)
        {
            By optionalp = By.XPath("//input[@id=" + a + "]/following-sibling::span[@class='ideal-check']");
            dr.FindElement(optionalp).Click();
        }


        [When(@"I click on Next Button3")]
        public void WhenIClickOnNextButton3()
        {
            By button = By.Id("nextselectpriceoption");
            dr.FindElement(button).Click();
        }

        [Then(@"I see the Select Price Option page is opened")]
        public void ThenISeeTheSelectPriceOptionPageIsOpened()
        {
            Console.WriteLine("Select Price Option page is opened");
        }


        [When(@"I click on Radio Button for Select Option field as (.*)")]
        public void WhenIClickOnRadioButtonForSelectOptionFieldAs(string a)
        {
            By option = By.XPath("//input[@value=" + a + "]/following-sibling::span[@class='ideal-radio']");
            dr.FindElement(option).Click();
            Thread.Sleep(2000);
        }


        [When(@"I click on Next Button4")]
        public void WhenIClickOnNextButton4()
        {
            By button = By.Name("Next (Send Quote)");
            dr.FindElement(button).Click();
        }

        [Then(@"I see the Send Quote page is opened")]
        public void ThenISeeTheSendQuotePageIsOpened()
        {
            Console.WriteLine("Send Quote page is opened");
        }


        [When(@"I enter a data for E-Mail field as (.*)")]
        public void WhenIEnterADataForE_MailFieldAs(string a)
        {
            By email = By.Id("email");
            dr.FindElement(email).SendKeys(a);
        }

        [When(@"I enter a data for Phone field as (.*)")]
        public void WhenIEnterADataForPhoneFieldAs(string a)
        {
            By phone = By.Id("phone");
            dr.FindElement(phone).SendKeys(a);
        }

        [When(@"I enter a data for Username field as (.*)")]
        public void WhenIEnterADataForUsernameFieldAs(string a)
        {
            By username = By.Id("username");
            dr.FindElement(username).SendKeys(a);
        }

        [When(@"I enter a data for Password field as (.*)")]
        public void WhenIEnterADataForPasswordFieldAs(string a)
        {
            By password = By.Id("password");
            dr.FindElement(password).SendKeys(a);
        }

        [When(@"I enter a data for Confirm Password field as (.*)")]
        public void WhenIEnterADataForConfirmPasswordFieldAs(string a)
        {
            By confpass = By.Id("confirmpassword");
            dr.FindElement(confpass).SendKeys(a);
        }

        [When(@"I enter a data for Comments field as (.*)")]
        public void WhenIEnterADataForCommentsFieldAs(string a)
        {
            By comments = By.Id("Comments");
            dr.FindElement(comments).SendKeys(a);
        }

        [When(@"I click on Next Button5")]
        public void WhenIClickOnNextButton5()
        {
            By send = By.Id("sendemail");
            dr.FindElement(send).Click();
            Thread.Sleep(3000);
        }

        [Then(@"I see Sending e-mail success")]
        public void ThenISeeSendingE_MailSuccess()
        {
            Console.WriteLine("Sending e-mail successful");
        }




        //[When(@"I enter data for user details from table")]
        //public void WhenIEnterDataForUserDetailsFromTable(Table table)
        //{
        //    var data = table.CreateDynamicSet();
        //    foreach (var details in data)
        //    {
        //        dr.FindElement(By.Id("email")).SendKeys(details.Email);
        //        dr.FindElement(By.Id("phone")).SendKeys(""+details.Phone);
        //        dr.FindElement(By.Id("username")).SendKeys(details.Username);
        //        dr.FindElement(By.Id("password")).SendKeys(details.Password);
        //        dr.FindElement(By.Id("confirmpassword")).SendKeys(details.ConfirmPassword);
        //        dr.FindElement(By.Id("Comments")).SendKeys(details.Comments);
        //    }
        //}
    }
}
