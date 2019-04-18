using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Attributes;
using JDI.Light.Core.Elements.Common;
using JDI.Light.Core.Elements.Composite;

namespace JDI.Light.Core.Tests.UIObjects.Sections
{
    public class Footer : Section
    {
        [FindBy(PartialLinkText = "About")]
        public Link AboutLink;
    }
}
