using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Interfaces.Base;
using OpenQA.Selenium;

namespace JDI.Light.Core.Interfaces.Common
{
    public interface IDataList : IBaseUIElement
    {
        By CaretLocator { get; set; }
        By ItemLocator { get; set; }
        void Expand();
        void Select(string value);
        void Select(int index);
        string GetSelected();
        void Input(string text);
    }
}
