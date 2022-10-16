using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class AddNewContactTests : TestBase
    {
        [Test]
        public void AddNewContactTest()
        {
            app.ContactHelper.GoToAddNewPage();
            AddNewContactData main = new AddNewContactData("Tester","Testovich");
            app.ContactHelper.FillAddNewForm(main)
                             .SubmitCreationContact()
                             .ReturnToMainPage();
            app.GroupHelper.Logout();
        }
    }
}