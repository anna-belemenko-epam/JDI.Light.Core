using System;
using System.Collections.Generic;
using System.Text;

namespace JDI.Light.Core.Interfaces.Base
{
    public interface IVisible
    {
        bool Displayed { get; }
        bool Hidden { get; }
        void WaitDisplayed();
        void WaitVanished();
    }
}
