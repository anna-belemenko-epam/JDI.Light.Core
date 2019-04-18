using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using JDI.Light.Core.Elements.Base;
using JDI.Light.Core.Elements.Composite;
using JDI.Light.Core.Extensions;
using JDI.Light.Core.Factories;
using JDI.Light.Core.Interfaces.Base;
using JDI.Light.Core.Interfaces.Composite;
using JDI.Light.Core.Utils;
using OpenQA.Selenium;

namespace JDI.Light.Core.Elements
{
    public static class WebCascadeInit
    {
        private static readonly Type[] Decorators = { typeof(IBaseElement), typeof(IWebElement), typeof(IList<IBaseElement>) };
        private static readonly Type[] StopTypes = { typeof(object), typeof(WebPage), typeof(BitVector32.Section), typeof(UIElement) };

        public static IBaseElement InitMembers(this IBaseElement targetElement)
        {
            var elementMembers = targetElement.GetMembers(Decorators, StopTypes);
            var members = elementMembers.Where(m => Decorators.Any(type => type.IsAssignableFrom(m.GetMemberType())));
            foreach (var member in members)
            {
                var type = member.GetMemberType();
                var instance = typeof(IPage).IsAssignableFrom(type)
                    ? targetElement.GetInstancePage(member)
                    : targetElement.GetInstanceElement(member);
                instance.Name = member.GetElementName();
                member.SetMemberValue(targetElement, instance);
                InitMembers(instance);
            }

            return targetElement;
        }
    }
}
