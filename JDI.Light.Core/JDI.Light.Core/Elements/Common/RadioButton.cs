﻿using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Interfaces.Common;
using OpenQA.Selenium;

namespace JDI.Light.Core.Elements.Common
{
    public class RadioButton : Selector, IRadioButton
    {
        public By RadioLocator { get; set; }

        protected RadioButton(By byLocator) : base(byLocator)
        {
        }

        public void Select(string value)
        {
            ItemLocator = RadioLocator;
            Select(value, this);
        }

        public void Select(int index)
        {
            ItemLocator = RadioLocator;
            Select(index, this);
        }

        public string GetSelected()
        {
            var els = WebElement.FindElements(RadioLocator);
            foreach (var element in els)
            {
                if (element?.GetAttribute("checked") != null)
                {
                    return element.GetAttribute("id");
                }
            }
            return null;
        }
    }
}
