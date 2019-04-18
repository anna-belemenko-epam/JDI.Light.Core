using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace JDI.Light.Core
{
    public interface IDriverFactory<out T>
    {
        Func<IWebElement, bool> ElementSearchCriteria { get; set; }
        string CurrentDriverName { get; set; }
        string DriverPath { get; set; }
        string DriverVersion { get; set; }
        bool GetLatestDriver { get; set; }

        string RegisterDriver(string driverName);
        void SetRunType(string runType);
        T GetDriver();
        bool HasDrivers();
        bool HasRunDrivers();
        T GetDriver(string name);
        void Close();
    }
}
