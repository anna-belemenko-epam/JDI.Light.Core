using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Attributes;
using JDI.Light.Core.Elements.Complex.Table;
using JDI.Light.Core.Elements.Composite;

namespace JDI.Light.Core.Tests.UIObjects.Pages
{
    public class ComplexTablePage : WebPage
    {
        [FindBy(XPath = "//table[@id='complex-table']/tbody/tr/td/div/table")]
        public Table Table;
    }
}
