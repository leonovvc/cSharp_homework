using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]

    public class ContactDeleteTests : AuthTestBase
    {
        [Test]
        public void ContactDeleteTest()
        {
            app.ContactHelper.DeleteContact(1);
        }

        [Test]
        public void CheckAndDeleteTest()
        {
            if (!app.ContactHelper.FoundGroup())
            {
                app.ContactHelper.CreateContact();
            }
            app.ContactHelper.DeleteContact(1);
        }
    }
}
