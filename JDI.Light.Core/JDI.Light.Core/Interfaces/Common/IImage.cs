﻿using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Interfaces.Base;

namespace JDI.Light.Core.Interfaces.Common
{
    public interface IImage : IBaseUIElement
    {
        string GetSource();
        string GetAlt();
    }
}
