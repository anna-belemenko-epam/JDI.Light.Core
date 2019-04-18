using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Elements.Base;
using OpenQA.Selenium;

namespace JDI.Light.Core.Elements.Composite
{
    public class Alert : UIElement
    {
        public Alert() : base(null)
        {
        }

        private IAlert _alert;
        private IAlert GetAlert()
        {
            return _alert ?? (_alert = WebDriver.SwitchTo().Alert());
        }

        public void Ok()
        {
            GetAlert().Accept();
        }

        public void Cancel()
        {
            GetAlert().Dismiss();
        }

        public new void SendKeys(string keysToSend)
        {
            GetAlert().SendKeys(keysToSend);
        }

        public string GetText()
        {
            return GetAlert().Text;
        }
    }
}
