using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Enums;
using JDI.Light.Core.Interfaces.Base;
using OpenQA.Selenium;

namespace JDI.Light.Core.Interfaces.Composite
{
    public interface IPage : IBaseElement
    {
        CheckPageType CheckTitleType { get; set; }
        CheckPageType CheckUrlType { get; set; }

        IWebSite Parent { get; set; }
        string Url { get; set; }
        string Title { get; set; }
        string UrlTemplate { get; set; }

        IWebDriver WebDriver { get; }

        void CheckOpened();
        void Open();
    }
}
