using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class ContactHelper
    {
        private IWebDriver driver;

        public ContactHelper(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void FillAddNewForm(AddNewContact main)
        {
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(main.FirstName);
            driver.FindElement(By.Name("lastname")).Click();
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(main.LastName);
        }

        public void GoToAddNewPage()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            driver.Navigate().GoToUrl("http://localhost:8080/addressbook/edit.php");
        }

        public void SubmitCreationContact()
        {
            driver.FindElement(By.Name("submit")).Click();
        }

        public void ReturnToMainPage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
            driver.Navigate().GoToUrl("http://localhost:8080/addressbook/");
        }
    }
}
