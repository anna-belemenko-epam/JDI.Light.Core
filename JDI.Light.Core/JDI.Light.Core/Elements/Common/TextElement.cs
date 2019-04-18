using OpenQA.Selenium;
using System;
using JDI.Light.Core.Elements.Base;
using JDI.Light.Core.Extensions;
using JDI.Light.Core.Interfaces.Common;

namespace JDI.Light.Core.Elements.Common
{
    public class TextElement : UIElement, ITextElement
    {
        public TextElement() : this(null)
        {
        }

        public TextElement(By byLocator = null)
            : base(byLocator)
        {
        }

        protected virtual string GetTextAction()
        {
            var e = WebElement;
            var getText = e.Text ?? "";
            if (!getText.Equals(""))
                return getText;
            var getValue = e.GetAttribute("value");
            return getValue ?? getText;
        }

        private Func<string> TextAction() => GetTextAction;

        public string Value => Invoker.DoActionWithResult("Get value", GetTextAction);

        public string GetValue()
        {
            return Value;
        }

        public new string Text => GetText();

        public string GetText()
        {
            return Value;
        }

        public string WaitText(string text)
        {
            return Invoker.DoActionWithResult($"Wait text contains '{text}'", TextAction(), checkResultFunc: t => t.Contains(text));
        }

        public string WaitMatchText(string regEx)
        {
            return Invoker.DoActionWithResult($"Wait text match regex '{regEx}'", TextAction(), checkResultFunc: t => t.Matches(regEx));
        }
    }
}
