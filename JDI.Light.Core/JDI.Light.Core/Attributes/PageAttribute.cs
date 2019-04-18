using System;
using JDI.Light.Core.Enums;

namespace JDI.Light.Core.Attributes
{
    [AttributeUsage(AttributeTargets.All, Inherited = false)]
    public class PageAttribute : Attribute
    {
        public string Title = "";
        public CheckPageType TitleCheckType = CheckPageType.None;
        public string Url = "";
        public CheckPageType UrlCheckType = CheckPageType.None;
        public string UrlTemplate = "";
    }
}
