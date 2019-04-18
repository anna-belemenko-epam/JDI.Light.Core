using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using JDI.Light.Core.Elements.Base;
using JDI.Light.Core.Interfaces.Common;
using OpenQA.Selenium;

namespace JDI.Light.Core.Elements.Common
{
    public class Range : UIElement, IRange
    {
        protected Range(By byLocator) : base(byLocator)
        {
        }

        public void SetRange(string value)
        {
            SetAttribute("value", value);
        }

        public void SetRange(double value)
        {
            SetAttribute("value", value.ToString(CultureInfo.InvariantCulture));
        }

        public string GetValue()
        {
            return GetAttribute("value");
        }

        public double GetRange()
        {
            return Convert.ToDouble(GetAttribute("value"));
        }
        public double Min()
        {
            return Convert.ToDouble(GetAttribute("min"));
        }

        public double Max()
        {
            return Convert.ToDouble(GetAttribute("max"));
        }
    }
}
