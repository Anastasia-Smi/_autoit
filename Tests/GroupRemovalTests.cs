using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AddressbookTestsAutoit
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]

        public void _TestGroupRemoval()
        {
      
         List<GroupData> oldGroups = app.Groups.GetGroupList();
         
         app.Groups.Remove();

         List<GroupData> newGroups = app.Groups.GetGroupList();
         

         oldGroups.Sort();
         newGroups.Sort();

         NUnit.Framework.Assert.AreEqual(oldGroups, newGroups);

         }
     }
}