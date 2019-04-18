using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Interfaces.Common;

namespace JDI.Light.Core.Interfaces.Composite
{
    public interface ISearch : ITextField
    {
        void Find(string text);
    }
}
