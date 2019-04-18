using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Interfaces.Base;

namespace JDI.Light.Core.Interfaces.Common
{
    public interface IRange : IBaseUIElement
    {
        void SetRange(string value);
        void SetRange(double value);
        string GetValue();
        double GetRange();
        double Min();
        double Max();
    }
}
