using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]   
        public void ContactModificationTest()
        {
            app.ContactHelper.ModifyContact();
        }

        [Test]
        public void CheckAndModifyTest()
        {
            if (!app.ContactHelper.FoundGroup())
            {
                app.ContactHelper.CreateContact();
            }
            app.ContactHelper.ModifyContact();
        }
    }
}
