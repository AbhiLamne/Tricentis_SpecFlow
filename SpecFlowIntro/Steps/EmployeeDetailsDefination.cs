using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SpecFlow.Assist.Dynamic;

namespace SpecFlowIntro.Steps
{
    [Binding]
    public class EmployeeDetailsDefination
    {
        public readonly EmployeeDetails employee;

        public EmployeeDetailsDefination(EmployeeDetails emp)
        {
            this.employee = emp;
        }


        [Given(@"I have opened the application")]
        public void GivenIHaveOpenedTheApplication()
        {
            Console.WriteLine("Opened the Application.");
        }

        [Then(@"I should see employee details page")]
        public void ThenIShouldSeeEmployeeDetailsPage()
        {
            Console.WriteLine("I can see Employee Details Page.");
        }

        [When(@"I fill all the mandatory details in form")]
        public void WhenIFillAllTheMandatoryDetailsInForm(Table table)
        {
            var data = table.CreateSet<EmployeeDetails>();

            foreach(var item in data)
            {
                employee.Name = (string)item.Name;
                employee.Age =(int) item.Age;
                employee.Phone = (long)item.Phone;
                employee.Email = (string)item.Email;
            }


            //var details = table.CreateSet<EmployeeDetails>();

            //foreach (EmployeeDetails emp in details)
            //{
            //    Console.WriteLine("The details of Employee " + emp.Name);
            //    Console.WriteLine(emp.Name);
            //    Console.WriteLine(emp.Age);
            //    Console.WriteLine(emp.Phone);
            //    Console.WriteLine(emp.Email);
            //    Console.WriteLine("***********************************");
            //}

            ////Work with Dynamic Assist
            //var details = table.CreateDynamicSet();

            ////Iterate
            //foreach(var emp in details)
            //{
            //    Console.WriteLine("The details of Employee " + emp.Name);
            //    Console.WriteLine(emp.Name);
            //    Console.WriteLine(emp.Age);
            //    Console.WriteLine(emp.Phone);
            //    Console.WriteLine(emp.Email);
            //    Console.WriteLine("***********************************");
            //}
        
        }

        //[When(@"I fill all the mandatory details in form (.*), (.*), (.*) and (.*)")]
        //public void WhenIFillAllTheMandatoryDetailsInFormAbhishekAndAbhilamne(string Name, int Age, Int64 Phone, string Email)
        //{
        //    Console.WriteLine("Name : " + Name);
        //    Console.WriteLine("Age : " + Age);
        //    Console.WriteLine("Phone Number : " + Phone);
        //    Console.WriteLine("Email : " + Email);

        //    //-------------//
        //    ScenarioContext.Current["InfoForNextStep"] = "Step1 Passed";
        //    Console.WriteLine(ScenarioContext.Current["InfoForNextStep"].ToString());

        //    List<EmployeeDetails> empDetails = new List<EmployeeDetails>()
        //    {
        //        new EmployeeDetails()
        //        {
        //            Name = "john",
        //            Age = 25,
        //            Phone = 8747983,
        //            Email= "dhaaksljn@7468732"
        //        },

        //        new EmployeeDetails()
        //        {
        //            Name = "Mike",
        //            Age = 23,
        //            Phone = 48732,
        //            Email= "dhaaksljn@8742433"
        //        },

        //        new EmployeeDetails()
        //        {
        //            Name = "Ron",
        //            Age = 22,
        //            Phone = 343566534,
        //            Email= "dhaaksljn@343254364"
        //        },

        //        new EmployeeDetails()
        //        {
        //            Name = "Harry",
        //            Age = 26,
        //            Phone = 75543242,
        //            Email= "dhaaksljn@54364"
        //        }
        //    };
        //    //Save the value in ScenarioContext
        //    ScenarioContext.Current.Add("EmpDetails", empDetails);

        //    //Get the value out from ScenarioContext
        //    var empList =  ScenarioContext.Current.Get<IEnumerable<EmployeeDetails>>("EmpDetails");

        //    foreach(EmployeeDetails emp in empList)
        //    {
        //        Console.WriteLine("Employee Name is: " + emp.Name);
        //        Console.WriteLine("Employee Age is: " + emp.Age);
        //        Console.WriteLine("Employee Phone is: " + emp.Phone);
        //        Console.WriteLine("Employee Email is: " + emp.Email);
        //        Console.WriteLine("\n");
        //    }

            //Console.WriteLine(ScenarioContext.Current.ScenarioInfo.Title);
            //Console.WriteLine(ScenarioContext.Current.CurrentScenarioBlock);
        //}

        [When(@"I click the save button")]
        public void WhenIClickYheSaveButton()
        {
            Console.WriteLine("Clicked the save button.");
        }

        [Then(@"I should see all the details saved in my application and DB")]
        public void ThenIShouldSeeAllTheDetailsSavedInMyApplicationAndDB()
        {
            Console.WriteLine("I can see all the details saved in my application and DB.");
        }
       
    }
}
