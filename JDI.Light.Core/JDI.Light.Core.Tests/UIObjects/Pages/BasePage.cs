using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Attributes;
using JDI.Light.Core.Elements.Composite;
using JDI.Light.Core.Interfaces.Common;
using JDI.Light.Core.Tests.UIObjects.Forms;
using JDI.Light.Core.Tests.UIObjects.Sections;

namespace JDI.Light.Core.Tests.UIObjects.Pages
{
    public class BasePage : WebPage
    {
        [FindBy(Css = ".uui-header")]
        public static Header Header;

        [FindBy(Css = ".footer-content")]
        public static Footer Footer;

        [FindBy(Id = "login-form")]
        public LoginForm LoginForm;

        [FindBy(XPath = ".//div[@class='logout']/button")]
        public IButton LogoutButton;

        [FindBy(Css = "a>div.profile-photo")]
        public IButton Profile { get; set; }
    }
}
