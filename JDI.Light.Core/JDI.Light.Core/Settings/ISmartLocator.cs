using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using OpenQA.Selenium;

namespace JDI.Light.Core.Settings
{
    public interface ISmartLocator
    {
        string SmartSearchLocator { get; set; }
        string SmartSearchName(string name);
        By SmartSearch(MemberInfo member);
    }
}
