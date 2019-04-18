using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Attributes;
using JDI.Light.Core.Elements.Common;
using JDI.Light.Core.Elements.Composite;
using JDI.Light.Core.Interfaces.Common;
using JDI.Light.Core.Tests.Entities;

namespace JDI.Light.Core.Tests.UIObjects.Forms
{
    public class ContactFormTwoButtons : Form<Contact>
    {
        [FindBy(Id = "description")]
        public TextArea Description;

        [FindBy(XPath = ".//a[@class='ui-slider-handle ui-state-default ui-corner-all' and position()=1]")]
        public Link FirstRoller;

        [FindBy(Id = "last-name")]
        public TextField LastName;

        [FindBy(Id = "name")]
        public new TextField Name;

        [FindBy(XPath = ".//a[@class='ui-slider-handle ui-state-default ui-corner-all' and position()=2]")]
        public Link SecondRoller;

        [FindBy(XPath = "//*[text()='Submit']")]
        public new IButton Submit;
    }
}
