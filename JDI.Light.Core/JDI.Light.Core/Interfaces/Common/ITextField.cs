using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Interfaces.Base;

namespace JDI.Light.Core.Interfaces.Common
{
    public interface ITextField : ISetValue<string>, ITextElement
    {
        void Input(string text);
        new void SendKeys(string text);
        void NewInput(string text);
        new void Clear();
    }
}
