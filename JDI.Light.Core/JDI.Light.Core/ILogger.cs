using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Enums;

namespace JDI.Light.Core
{
    public interface ILogger
    {
        LogLevel LogLevel { get; set; }

        void Log(string message, LogLevel level);
        void Exception(Exception ex);
        void Trace(string message);
        void Debug(string message);
        void Info(string message);
        void Error(string message);
        void Step(string message);
        void TestDescription(string message);
        void TestSuit(string message);
    }
}
