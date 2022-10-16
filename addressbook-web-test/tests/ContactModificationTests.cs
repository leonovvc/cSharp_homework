using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : TestBase
    {
        [Test]   

        public void ContactModificationTest()
        {
            app.ContactHelper.InitModify(1);
            AddNewContactData main = new AddNewContactData("NewTest", "NewTestov");
            app.ContactHelper.FillAddNewForm(main);
            app.ContactHelper.UpdateContact();
        }

    }
}
