using System;
using System.Collections.Generic;
using System.Text;

namespace JDI.Light.Core.Exceptions
{
    public class ElementNotFoundException : Exception
    {
        public ElementNotFoundException(string message) : base(message)
        {
        }
    }
}
