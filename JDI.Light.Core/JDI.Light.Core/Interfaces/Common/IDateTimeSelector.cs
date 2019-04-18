using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Interfaces.Base;

namespace JDI.Light.Core.Interfaces.Common
{
    public interface IDateTimeSelector : IBaseUIElement
    {
        string Format { get; set; }
        void SetDateTime(string value);
        void SetDateTime(DateTime dateTime);
        string GetValue();
        DateTime GetDateTime();
    }
}
