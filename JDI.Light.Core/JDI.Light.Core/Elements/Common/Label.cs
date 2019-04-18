using JDI.Light.Core.Interfaces.Common;
using OpenQA.Selenium;

namespace JDI.Light.Core.Elements.Common
{
    public class Label : TextElement, ILabel
    {
        public Label() : this(null)
        {
        }

        public Label(By byLocator = null)
            : base(byLocator)
        {
        }
    }
}
