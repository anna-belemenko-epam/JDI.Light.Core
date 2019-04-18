using System;
using JDI.Light.Core.Elements.Base;
using JDI.Light.Core.Interfaces.Common;
using OpenQA.Selenium;

namespace JDI.Light.Core.Elements.Common
{
    public class DateTimeSelector : UIElement, IDateTimeSelector
    {
        public string Format { get; set; }

        protected DateTimeSelector(By byLocator) : base(byLocator)
        {
        }

        public void SetDateTime(string value)
        {
            SetAttribute("value", value);
        }

        public void SetDateTime(DateTime dateTime)
        {
            var value = dateTime.ToString(Format);
            SetAttribute("value", value);
        }

        public string GetValue()
        {
            return GetAttribute("value");
        }

        public DateTime GetDateTime()
        {
            return DateTime.ParseExact(GetAttribute("value"), Format,
                System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
