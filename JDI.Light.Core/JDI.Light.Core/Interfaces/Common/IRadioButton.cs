using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Interfaces.Base;
using OpenQA.Selenium;

namespace JDI.Light.Core.Interfaces.Common
{
    public interface IRadioButton : IBaseUIElement
    {
        By RadioLocator { get; set; }
        void Select(string value);
        void Select(int index);
        string GetSelected();
    }
}
