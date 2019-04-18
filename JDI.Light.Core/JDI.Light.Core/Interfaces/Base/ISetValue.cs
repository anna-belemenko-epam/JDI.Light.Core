using System;
using System.Collections.Generic;
using System.Text;

namespace JDI.Light.Core.Interfaces.Base
{
    public interface ISetValue<T> : IGetValue<T>
    {
        new T Value { get; set; }
    }
}
