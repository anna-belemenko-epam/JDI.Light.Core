using System;
using System.Collections.Generic;
using System.Text;

namespace JDI.Light.Core.Interfaces.Common
{
    public interface ILink : ITextElement
    {
        string GetReference();
        string WaitReferenceContains(string text);
        string WaitReferenceMatches(string regEx);
        string GetTooltip();
    }
}
