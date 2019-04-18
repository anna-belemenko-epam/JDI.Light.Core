using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Attributes;
using JDI.Light.Core.Elements.Complex.Table;
using JDI.Light.Core.Elements.Composite;

namespace JDI.Light.Core.Tests.UIObjects.Pages
{
    public class SimpleTablePage : WebPage
    {
        [FindBy(Id = "simple-table")]
        public Table Table;
    }
}
