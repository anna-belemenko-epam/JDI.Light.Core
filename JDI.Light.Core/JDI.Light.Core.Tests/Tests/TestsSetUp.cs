using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Enums;
using JDI.Light.Core.Tests.Asserts;
using NUnit.Framework;

namespace JDI.Light.Core.Tests.Tests
{
    [SetUpFixture]
    public class TestsSetUp
    {
        [OneTimeSetUp]
        protected void OneTimeSetUp()
        {
            Jdi.Init(new NUnitAsserter());
            Jdi.Logger.LogLevel = LogLevel.Debug;
            Jdi.DriverFactory.GetLatestDriver = false;
            Jdi.DriverFactory.DriverVersion = "2.41";
            Jdi.Logger.Info("Init test run...");
            Jdi.KillDriver.ProcessToKill = new[] { "chromedriver" };
            Jdi.KillAllDrivers();
        }

        [OneTimeTearDown]
        protected void OneTimeTearDown()
        {
            Jdi.KillAllDrivers();
        }
    }
}
