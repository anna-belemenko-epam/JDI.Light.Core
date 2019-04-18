using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Elements.Base;
using OpenQA.Selenium;

namespace JDI.Light.Core.Elements.Composite
{
    public class Section : UIElement
    {
        public Section() : base(null)
        {
        }

        public Section(By locator) : base(locator)
        {
        }
    }
}
