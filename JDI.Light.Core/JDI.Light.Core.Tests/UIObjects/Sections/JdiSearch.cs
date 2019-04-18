using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Attributes;
using JDI.Light.Core.Elements.Composite;
using JDI.Light.Core.Interfaces.Common;

namespace JDI.Light.Core.Tests.UIObjects.Sections
{
    public class JdiSearch : Search
    {
        [FindBy(Css = ".search>.icon-search")]
        public new IButton SearchButton;

        [FindBy(Css = ".icon-search.active")]
        public IButton SearchButtonActive;

        [FindBy(Css = ".search-field input")]
        public ITextField SearchInput;
    }
}
