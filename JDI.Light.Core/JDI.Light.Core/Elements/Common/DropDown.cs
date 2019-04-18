using JDI.Light.Core.Interfaces.Common;
using OpenQA.Selenium;

namespace JDI.Light.Core.Elements.Common
{
    public class DropDown : Selector, IDropDown
    {
        public DropDown(By byLocator) : base(byLocator)
        {
        }

        public void Select(string value)
        {
            Click();
            Select(value, this);
        }

        public void Select(int index)
        {
            Click();
            Select(index, this);
        }

        public string GetSelected()
        {
            return GetSelected(this);
        }
    }
}
