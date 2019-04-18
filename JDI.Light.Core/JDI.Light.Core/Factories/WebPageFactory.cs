using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using JDI.Light.Core.Attributes;
using JDI.Light.Core.Elements.Composite;
using JDI.Light.Core.Extensions;
using JDI.Light.Core.Interfaces.Base;
using JDI.Light.Core.Interfaces.Composite;

namespace JDI.Light.Core.Factories
{
    public static class WebPageFactory
    {
        public static WebPage CreateInstance(this Type t, IWebSite parent)
        {
            var instance = (WebPage)Activator.CreateInstance(t);
            instance.DriverName = parent.DriverName;
            instance.Parent = parent;
            return instance;
        }

        public static IPage GetInstancePage(this IBaseElement parent, MemberInfo memberInfo)
        {
            var pageAttribute = memberInfo.GetCustomAttribute<PageAttribute>(false);
            var instance = (IPage)(memberInfo.GetMemberValue(parent)
                                   ?? memberInfo.GetMemberType().CreateInstance((IWebSite)parent));
            if (pageAttribute == null) return instance;
            instance.Url = pageAttribute.Url;
            instance.Title = pageAttribute.Title;
            instance.UrlTemplate = pageAttribute.UrlTemplate;
            instance.CheckUrlType = pageAttribute.UrlCheckType;
            instance.CheckTitleType = pageAttribute.TitleCheckType;
            return instance;
        }
    }
}
