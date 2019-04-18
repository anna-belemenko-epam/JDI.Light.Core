using System;
using OpenQA.Selenium;

namespace JDI.Light.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class CssAttribute : Attribute
    {
        public CssAttribute(string locator)
        {
            Value = By.CssSelector(locator);
        }
        public By Value { get; }
    }
}
