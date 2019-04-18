using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Attributes;
using JDI.Light.Core.Elements.Composite;
using JDI.Light.Core.Interfaces.Common;

namespace JDI.Light.Core.Tests.UIObjects.Sections
{
    public class Header : Section
    {
        [FindBy(XPath = "//img[@src=\"label/Logo_Epam_Color.svg\"]")]
        public IImage Image;

        [FindBy(Css = "ul.uui-navigation.nav")]
        public Menu Menu;

        public JdiSearch Search;
    }
}
