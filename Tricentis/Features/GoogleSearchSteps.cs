using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Tricentis_SpecFlow.Steps
{
    [Binding]
    public class GoogleSearchSteps
    {
        private IWebDriver dr;
        private String searchKeyword;     

        [Given(@"I have navigated to Google website")]
        public void GivenIHaveNavigatedToGoogleWebsite()
        {
            this.dr = new ChromeDriver();
            dr.Navigate().GoToUrl("https://www.google.co.in/");
        }


        [Given(@"I have entered (.*) as search keyword")]
        public void GivenIHaveEnteredTricentisAsSearchKeyword(String searchString)
        {
            this.searchKeyword = searchString.ToLower();
            var searchInputBox = dr.FindElement(By.Name("q"));         
            searchInputBox.SendKeys(searchKeyword);
            Thread.Sleep(2000);
        }


        [When(@"I press the search button")]
        public void WhenIPressTheSearchButton()
        {
            dr.FindElement(By.XPath("//input[@class='gNO89b']")).Click();
           
        }


        [Then(@"I should be navigate to search results page")]
        public void ThenIShouldBeNavigateToSearchResultsPage()
        {
            Console.WriteLine("Tricentis hompage opened");
        }        
    }
}
