using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Interfaces.Base;

namespace JDI.Light.Core.Interfaces.Common
{
    public interface ITextElement : IGetValue<string>, IBaseUIElement
    {
        string GetText();
        string WaitText(string text);
        string WaitMatchText(string regEx);
    }
}
