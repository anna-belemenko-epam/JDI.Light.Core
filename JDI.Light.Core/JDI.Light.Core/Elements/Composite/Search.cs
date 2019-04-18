using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JDI.Light.Core.Elements.Base;
using JDI.Light.Core.Elements.Common;
using JDI.Light.Core.Extensions;
using JDI.Light.Core.Interfaces.Common;
using JDI.Light.Core.Interfaces.Composite;
using JDI.Light.Core.Utils;
using OpenQA.Selenium;

namespace JDI.Light.Core.Elements.Composite
{
    public class Search : TextField, ISearch
    {
        protected Action<Search, string> FindAction = (s, text) =>
        {
            s.SearchField.NewInput(text);
            s.SearchButton.Click();
        };

        public Search() : this(null)
        {
        }

        public Search(By byLocator) : base(byLocator)
        {
        }

        private ITextField SearchField
        {
            get
            {
                var textFields = this.GetMembers(typeof(ITextField))
                    .Select(fi => (ITextField)fi.GetMemberValue(this)).Where(b => ((UIElement)b).Displayed).ToList();
                switch (textFields.Count)
                {
                    case 0:
                        throw Jdi.Assert.Exception($"Can't find any buttons on form '{ToString()}'.");
                    case 1:
                        return textFields[0];
                    default:
                        throw Jdi.Assert.Exception(
                            $"Form '{ToString()}' have more than 1 button. Use submit(entity, buttonName) for this case instead");
                }
            }
        }

        protected IButton SearchButton
        {
            get
            {
                var buttons = this.GetMembers(typeof(IButton))
                    .Select(fi => (IButton)fi.GetMemberValue(this)).Where(b => ((UIElement)b).Displayed).ToList();
                switch (buttons.Count)
                {
                    case 0:
                        throw Jdi.Assert.Exception($"Can't find any buttons on form '{ToString()}'.");
                    case 1:
                        return buttons[0];
                    default:
                        throw Jdi.Assert.Exception(
                            $"Form '{ToString()}' have more than 1 button. Use submit(entity, buttonName) for this case instead");
                }
            }
        }

        public void Find(string text)
        {
            Invoker.DoActionWithWait($"Search text '{text}'", () => FindAction(this, text));
        }
    }
}
