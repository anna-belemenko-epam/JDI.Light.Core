using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Attributes;
using JDI.Light.Core.Elements.Common;
using JDI.Light.Core.Elements.Composite;

namespace JDI.Light.Core.Tests.UIObjects.Forms
{
    public class LoginFormClient : WebPage
    {
        [FindBy(Css = "#name")] TextField Login;
        [FindBy(Css = "#password")] TextField Password;
        [FindBy(Css = "button.btn-login")] public Button LoginButton;
    }
}
