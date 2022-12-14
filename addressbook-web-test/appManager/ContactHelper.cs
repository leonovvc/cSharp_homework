using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {

        public ContactHelper(ApplicationManager manager)
            : base(manager)
        {
        }

        public ContactHelper FillAddNewForm(AddNewContactData main)
        {
                Type(By.Name("firstname"), main.FirstName);
                Type(By.Name("lastname"), main.LastName);
            return this;
        }

        public ContactHelper GoToAddNewPage()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }


        public ContactHelper SubmitCreationContact()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public ContactHelper ReturnToMainPage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
            return this;
        }

        public ContactHelper SelectContact(int index)
            {   
            driver.FindElement(By.Name("selected[]")).Click();
            return this;
            }

        public ContactHelper UpdateContact()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public ContactHelper InitModify(int contactInQueue)
        {
            driver.FindElement(By.XPath($"//table[@id='maintable']/tbody/tr[{1 + contactInQueue}]/td[8]/a/img")).Click();
            return this;
        }
        public ContactHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }
        public ContactHelper DeleteContact(int v)
        {
            SelectContact(v);
            RemoveContact();
            driver.SwitchTo().Alert().Accept();
            return this;
        }

        public ContactHelper CreateContact()
        { 
            GoToAddNewPage();
            AddNewContactData main = new AddNewContactData("Tester", "Testovich");
            FillAddNewForm(main);
            SubmitCreationContact();
            ReturnToMainPage();
            return this;
        }
        
        public ContactHelper ModifyContact()
        {
            InitModify(1);
            AddNewContactData main = new AddNewContactData("NewTest", "NewTestov");
            FillAddNewForm(main);
            UpdateContact();
            return this;
        }

        public ContactHelper EditContact(int v)
        {
            InitModify(v);
            return this;
        }

        public ContactHelper FillAddNewFormData(AddNewContactData main)
        {
            return this;
        }

        public bool FoundGroup()
        {
            manager.NavigationHelper.GoToHomePage();
            return IsElementPresent(By.Name("selected[]"));
        }
    }
}
