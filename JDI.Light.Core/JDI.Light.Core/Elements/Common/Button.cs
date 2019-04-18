using JDI.Light.Core.Interfaces.Common;
using OpenQA.Selenium;

namespace JDI.Light.Core.Elements.Common
{
    public class Button : TextElement, IButton
    {
        public Button()
        {
        }

        public Button(By byLocator) : base(byLocator)
        {
        }
    }
}
