﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]

    public class ContactDeleteTests : TestBase
    {
        [Test]

        public void ContactDeleteTest()
        {
            app.ContactHelper.DeleteContact(1);
        }
    }
}
