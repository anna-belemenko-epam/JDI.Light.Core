using System;
using System.Collections.Generic;
using System.Text;

namespace JDI.Light.Core.Interfaces.Base
{
    public interface IGetValue<T>
    {
        T Value { get; }
    }
}
