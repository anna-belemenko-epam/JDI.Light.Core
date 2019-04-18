using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Elements.WebActions;
namespace JDI.Light.Core.Interfaces.Base
{
    public interface IBaseElement
    {
        ActionInvoker Invoker { get; set; }
        ILogger Logger { get; set; }
        string DriverName { get; set; }
        string Name { get; set; }
    }
}
