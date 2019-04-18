using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Attributes;
using JDI.Light.Core.Elements.Composite;
using JDI.Light.Core.Interfaces.Common;
using JDI.Light.Core.Tests.Entities;

namespace JDI.Light.Core.Tests.UIObjects.Forms
{
    public class LoginForm : Form<User>
    {
        [FindBy(Css = "button.btn-login")]
        [Name("Login")]
        public IButton LoginButton;

        [FindBy(Css = "#name")]
        [Name("Login")]
        public ITextField LoginField;

        [FindBy(Css = "#password")]
        [Name("Password")]
        public ITextField PasswordField;
    }
}
