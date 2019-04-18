using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using JDI.Light.Core.Extensions;
using OpenQA.Selenium;

namespace JDI.Light.Core.Settings
{
    public class SmartLocatorById : ISmartLocator
    {
        public string SmartSearchLocator { get; set; }

        public string SmartSearchName(string name) => StringExtensions.SplitHyphen(name);

        public By SmartSearch(MemberInfo member)
        {
            var smartSearchName = SmartSearchName(member.Name);
            return By.Id(smartSearchName);
        }
    }
}
