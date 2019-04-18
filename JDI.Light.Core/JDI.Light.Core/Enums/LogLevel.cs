using System;
using System.Collections.Generic;
using System.Text;

namespace JDI.Light.Core.Enums
{
    public enum LogLevel
    {
        Off = -1,
        Fatal = 0,
        Error = 3,
        Warning = 4,
        Info = 6,
        Debug = 7,
        Trace = 8,
        All = 100
    }
}
