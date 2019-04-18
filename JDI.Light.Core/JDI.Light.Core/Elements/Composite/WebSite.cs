﻿using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Elements.WebActions;
using JDI.Light.Core.Factories;
using JDI.Light.Core.Interfaces.Composite;
using OpenQA.Selenium;

namespace JDI.Light.Core.Elements.Composite
{
    public class WebSite : IWebSite
    {
        public ActionInvoker Invoker { get; set; }
        public ILogger Logger { get; set; }
        public string DriverName { set; get; } = Jdi.DriverFactory.CurrentDriverName;
        public string Name { get; set; }
        public string Domain { get; set; }
        public bool HasDomain => Domain != null && Domain.Contains("://");
        public IWebDriver WebDriver => Jdi.DriverFactory.GetDriver(DriverName);
        public string Url => WebDriver.Url;
        public string BaseUrl => new Uri(WebDriver.Url).GetLeftPart(UriPartial.Authority);
        public string Title => WebDriver.Title;

        protected WebSite()
        {
        }

        public void Open()
        {
            WebDriver.Navigate().GoToUrl(Domain);
        }

        public T Get<T>(string relativeUrl, string title = "") where T : WebPage
        {
            var page = typeof(T).CreateInstance(this);
            page.Url = relativeUrl;
            page.Title = title;
            page.InitMembers();
            return (T)page;
        }

        public void OpenUrl(string url)
        {
            WebDriver.Navigate().GoToUrl(url);
        }

        public void OpenBaseUrl()
        {
            WebDriver.Navigate().GoToUrl(BaseUrl);
        }

        public void Refresh()
        {
            WebDriver.Navigate().Refresh();
        }

        public void Forward()
        {
            WebDriver.Navigate().Forward();
        }

        public void Back()
        {
            WebDriver.Navigate().Back();
        }
    }
}
