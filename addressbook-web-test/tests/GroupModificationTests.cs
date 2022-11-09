using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("someTest");
            newData.Header = ("newHeader");
            newData.Footer = ("newFooteryes");

            app.GroupHelper.Modify(1, newData);
        }

        [Test]
        public void CheckAndModifyTest()
        {
            GroupData newData = new GroupData("someTest");
            newData.Header = ("UpdatedHeader");
            newData.Footer = ("newFooteryes");

            if (!app.GroupHelper.FoundGroup())
                {
                    app.GroupHelper.CreateGroup(newData);
                }
            app.GroupHelper.Modify(1, newData);
        }
    }
}
