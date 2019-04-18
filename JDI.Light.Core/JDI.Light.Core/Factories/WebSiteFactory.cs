using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using JDI.Light.Core.Attributes;
using JDI.Light.Core.Elements;
using JDI.Light.Core.Interfaces.Composite;

namespace JDI.Light.Core.Factories
{
    public static class WebSiteFactory
    {
        public static T GetInstanceSite<T>(string driverName) where T : IWebSite, new()
        {
            var siteType = typeof(T);
            var site = new T { DriverName = driverName };
            var siteAttribute = siteType.GetCustomAttribute<SiteAttribute>(false);
            if (siteAttribute?.Domain != null)
            {
                site.Domain = siteAttribute.Domain;
            }
            else if (siteAttribute?.DomainProviderMethodName != null && siteAttribute.DomainProviderType != null)
            {
                site.Domain = siteAttribute.GetDomainFunc.Invoke();
            }

            site.InitMembers();
            return site;
        }
    }
}
