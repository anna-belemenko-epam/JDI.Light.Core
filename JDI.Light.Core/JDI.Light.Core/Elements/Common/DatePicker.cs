using JDI.Light.Core.Interfaces.Common;
using OpenQA.Selenium;

namespace JDI.Light.Core.Elements.Common
{
    public class DatePicker : TextField, IDatePicker
    {
        public DatePicker() : this(null)
        {
        }

        public DatePicker(By byLocator = null)
            : base(byLocator)
        {
        }
    }
}
