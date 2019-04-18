using System;
using System.Collections.Generic;
using System.Text;

namespace JDI.Light.Core.Interfaces.Common
{
    public interface ITextArea : ITextField
    {
        void InputLines(params string[] textLines);
        void AddNewLine(string textLine);
        string[] GetLines();
    }
}
