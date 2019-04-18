using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Attributes;
using JDI.Light.Core.Elements.Common;
using JDI.Light.Core.Interfaces.Common;

namespace JDI.Light.Core.Tests.UIObjects.Pages
{
    public class HomePage : BasePage
    {
        [FindBy(Css = ".epam-logo img")]
        public IImage LogoImage;

        [FindBy(Css = "[class=icon-search]")]
        public IButton OpenSearchButton;

        [FindBy(Css = ".main-txt")]
        public TextElement Text;

        public IImage UserIcon { get; set; }

        public Label MainTitle { get; set; }
    }
}
