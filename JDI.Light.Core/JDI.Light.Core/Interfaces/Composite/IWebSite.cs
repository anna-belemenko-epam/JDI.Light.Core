using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Interfaces.Base;

namespace JDI.Light.Core.Interfaces.Composite
{
    public interface IWebSite : IBaseElement
    {
        string Domain { get; set; }
        bool HasDomain { get; }
    }
}
