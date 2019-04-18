using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Attributes;
using JDI.Light.Core.Elements.Composite;
using JDI.Light.Core.Interfaces.Common;

namespace JDI.Light.Core.Tests.UIObjects.Sections
{
    public class Summary : Section
    {
        [FindBy(Id = "calculate-button")] public IButton Calculate;
    }
}
