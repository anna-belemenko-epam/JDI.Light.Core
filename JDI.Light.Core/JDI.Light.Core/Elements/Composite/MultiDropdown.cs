﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JDI.Light.Core.Elements.Base;
using JDI.Light.Core.Exceptions;
using JDI.Light.Core.Interfaces.Composite;
using OpenQA.Selenium;

namespace JDI.Light.Core.Elements.Composite
{
    public class MultiDropdown : UIElement
    {
        public By ElementsLocator { get; set; } = By.XPath(".//li");
        public By LabelsLocator { get; set; } = By.XPath(".//label");
        public By CheckboxesLocator { get; set; } = By.XPath(".//input");
        public bool IsExpanded => GetAttribute("class").Contains("open");

        public List<IMultiDropdownElement> Options
        {
            get
            {
                var elems = FindElements(ElementsLocator).ToList();
                var elementList = new List<IMultiDropdownElement>();
                foreach (var t in elems)
                {
                    elementList.Add(new MultiDropdownElement(ElementsLocator)
                    {
                        WebElement = t,
                        CheckboxLocator = CheckboxesLocator,
                        LabelLocator = LabelsLocator,
                        Parent = this
                    });
                }
                return elementList;
            }
        }

        public bool OptionIsEnabled(string name)
        {
            return Options.Any(x => x.OptionIsEnabled && x.Text == name);
        }

        public IMultiDropdownElement GetFirstByText(string text)
        {
            var v = Options.FirstOrDefault(x => x.Text == text);
            if (v == null)
            {
                throw new ElementNotFoundException($"Unable to locate element with text '{text}'");
            }

            return v;
        }

        public void SelectOption(string text)
        {
            Expand();
            GetFirstByText(text).Select();
            Close();
        }

        public List<string> GetSelectedOptions()
        {
            return Options.Where(x => x.IsSelected).Select(x => x.Text).ToList();
        }

        public bool OptionsAreSelected(List<string> options)
        {
            return Options.Where(x => x.IsSelected).All(x => options.Contains(x.Text))
                   && options.All(text => GetFirstByText(text).IsSelected);
        }

        public bool OptionIsSelected(string option)
        {
            return Options.Where(x => x.IsSelected).Any(x => option.Equals(x.Text));
        }

        public void SelectOptions(List<string> options)
        {
            Expand();
            foreach (var option in options)
            {
                GetFirstByText(option).Select();
            }
            JsExecutor.ExecuteScript("arguments[0].scrollIntoView();", WebElement);
            Close();
        }

        public bool OptionExists(string option)
        {
            return Options.Any(x => x.Text == option);
        }

        public MultiDropdown(By locator) : base(locator)
        {
        }

        public void Expand()
        {
            if (!IsExpanded)
            {
                Click();
            }
        }

        public void Close()
        {
            Expand();
        }
    }
}
