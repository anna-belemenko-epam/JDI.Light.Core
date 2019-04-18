﻿using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Elements.Base;
using JDI.Light.Core.Extensions;
using JDI.Light.Core.Interfaces.Common;
using OpenQA.Selenium;

namespace JDI.Light.Core.Elements.Common
{
    public class Link : TextElement, ILink
    {
        public Link() : this(null)
        {
        }

        public Link(By byLocator = null)
            : base(byLocator)
        {
        }

        public string GetReference()
        {
            return Invoker.DoActionWithResult(
                "Get link reference",
                () => FindImmediately(() => WebElement.GetAttribute("href"), ""),
                href => $"Get href of link '{href}'");
        }

        public string WaitReferenceContains(string text)
        {
            Func<string> TextFunc(UIElement el) => GetReference;
            return Invoker.DoActionWithResult(
                $"Wait link contains '{text}'",
                () => Invoker.GetResultByCondition(TextFunc(this), t => t.Contains(text))
            );
        }

        public string WaitReferenceMatches(string regEx)
        {
            Func<string> TextFunc(UIElement el) => GetReference;
            return Invoker.DoActionWithResult(
                $"Wait link match regex '{regEx}'",
                () => Invoker.GetResultByCondition(TextFunc(this), t => t.Matches(regEx))
            );
        }

        public string GetTooltip()
        {
            return Invoker.DoActionWithResult("Get link tooltip",
                () => FindImmediately(() => WebElement.GetAttribute("title"), ""), href => $"Get link tooltip '{href}'");
        }
    }
}
