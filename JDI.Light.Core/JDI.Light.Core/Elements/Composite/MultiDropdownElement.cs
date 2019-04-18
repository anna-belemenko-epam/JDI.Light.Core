using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Elements.Base;
using JDI.Light.Core.Elements.Common;
using JDI.Light.Core.Interfaces.Composite;
using OpenQA.Selenium;

namespace JDI.Light.Core.Elements.Composite
{
    public class MultiDropdownElement : UIElement, IMultiDropdownElement
    {
        public By LabelLocator { get; set; }
        public By CheckboxLocator { get; set; }

        public Label Label => Get<Label>(LabelLocator);
        public CheckBox CheckBox => Get<CheckBox>(CheckboxLocator);
        public bool IsSelected => GetAttribute("class") == "active";
        public bool OptionIsEnabled => GetAttribute("class") != "disabled";

        public new string Text => Label.Text;

        public void Select()
        {
            if (!IsSelected)
            {
                JsExecutor.ExecuteScript("arguments[0].scrollIntoView();", Label.WebElement);
                Label.Click();
            }
        }

        public MultiDropdownElement(By locator) : base(locator)
        {
        }
    }
}
