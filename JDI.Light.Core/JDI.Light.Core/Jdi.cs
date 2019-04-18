using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Factories;
using JDI.Light.Core.Interfaces.Composite;
using JDI.Light.Core.Interfaces.Utils;
using JDI.Light.Core.Logging;
using JDI.Light.Core.Settings;
using JDI.Light.Core.Utils;
using OpenQA.Selenium;

namespace JDI.Light.Core
{
    public static class Jdi
    {
        public static IDriverFactory<IWebDriver> DriverFactory;
        public static IWebDriver WebDriver => DriverFactory.GetDriver();
        public static Timeouts Timeouts;
        public static IAssert Assert;
        public static ILogger Logger;
        public static IKillDriver KillDriver;
        public static List<ISmartLocator> SmartLocators { get; set; }

        static Jdi()
        {
            Timeouts = new Timeouts();
            KillDriver = new WinProcUtils();
        }

        public static void Init(IAssert assert = null, ILogger logger = null,
            Timeouts timeouts = null, IDriverFactory<IWebDriver> driverFactory = null, List<ISmartLocator> smartLocators = null)
        {
            Assert = assert ?? new BaseAsserter();
            Logger = logger ?? new ConsoleLogger();
            Assert.Logger = Logger;
            DriverFactory = driverFactory ?? new WebDriverFactory();
            Timeouts = timeouts ?? new Timeouts();
            SmartLocators = smartLocators ?? new List<ISmartLocator> { new SmartLocatorById(), new SmartLocatorByCss() };
        }

        public static T InitSite<T>() where T : IWebSite, new()
        {
            return WebSiteFactory.GetInstanceSite<T>(DriverFactory.CurrentDriverName);
        }

        public static object ExecuteScript(string script, params object[] args)
        {
            return ((IJavaScriptExecutor)WebDriver).ExecuteScript(script, args);
        }

        public static void CloseDriver()
        {
            DriverFactory.Close();
        }

        public static void KillAllDrivers()
        {
            KillDriver.KillAllRunningDrivers();
        }
    }
}
