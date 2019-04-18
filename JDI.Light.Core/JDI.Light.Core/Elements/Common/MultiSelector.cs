﻿using System;
using System.Collections.Generic;
using System.Linq;
using JDI.Light.Core.Extensions;
using OpenQA.Selenium;

namespace JDI.Light.Core.Elements.Common
{
    public class MultiSelector : Selector
    {
        public By MultiItemLocator { get; set; }

        private readonly Action<MultiSelector, string> _unselectAll = (multiSelector, item) =>
        {
            var els = multiSelector.WebElement.FindElements(multiSelector.MultiItemLocator);
            var itemsList = els.FirstOrDefault(e => e.Text.Equals(item));
            if (itemsList?.GetAttribute("selected") != null)
            {
                itemsList.Click();
            }
        };

        public MultiSelector(By byLocator) : base(byLocator)
        {
        }

        public void Select(string[] values)
        {
            ItemLocator = MultiItemLocator;
            Select(values, this);
        }

        public void Select(int[] indexes)
        {
            ItemLocator = MultiItemLocator;
            Select(indexes, this);
        }

        public string[] GetSelected(Array values)
        {
            var selectedItems = new List<string>();
            foreach (var value in values.ToStringArray())
            {
                var els = WebElement.FindElements(MultiItemLocator);
                var itemsList = els.FirstOrDefault(e => e.Text.Equals(value));
                if (itemsList?.GetAttribute("selected") != null)
                {
                    selectedItems.Add(value);
                }
            }

            selectedItems.Reverse();
            return selectedItems.ToArray();
        }

        public void UnselectAll(Array allValues)
        {
            foreach (var value in allValues.ToStringArray())
            {
                Invoker.DoAction($"Unselect item '{string.Join(" -> ", value)}'",
                    () => _unselectAll.Invoke(this, value));
            }
        }
    }
}
