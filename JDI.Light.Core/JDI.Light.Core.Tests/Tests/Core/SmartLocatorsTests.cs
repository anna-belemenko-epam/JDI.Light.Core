using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace JDI.Light.Core.Tests.Tests.Core
{
    [TestFixture]
    public class SmartLocatorsTests : TestBase
    {
        [SetUp]
        public void SetUp()
        {
            TestSite.HomePage.Open();
            TestSite.HomePage.CheckOpened();
        }

        [Test]
        public void SmartLocatorsByIdTest()
        {
            Assert.IsTrue(TestSite.HomePage.UserIcon.Displayed);
        }

        [Test]
        public void SmartLocatorsByCssTest()
        {
            Assert.IsTrue(TestSite.HomePage.MainTitle.Displayed);
        }
    }
}
