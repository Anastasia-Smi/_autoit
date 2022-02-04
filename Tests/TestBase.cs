using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AddressbookTestsAutoit
{

    [TestFixture]
    public class TestBase
    {
        public static ApplicationManager app;


        [OneTimeSetUp]
        public void initAppliction()

        {
            app = new ApplicationManager();
        }


        [OneTimeTearDown]

        public void stopAppliction()

        {
            app.Stop();
        }

    } 
}
