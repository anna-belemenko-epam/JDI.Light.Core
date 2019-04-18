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
    public class ContactForm : Form<Contact>
    {
        [FindBy(Css = "textarea#description")]
        [Name("Description")]
        public ITextArea DescriptionField;

        [FindBy(XPath = ".//a[@class='ui-slider-handle ui-state-default ui-corner-all' and position()=1]")]
        public Link FirstRoller;

        [FindBy(Css = "input#last-name")]
        [Name("LastName")]
        public ITextField LastNameField;

        [FindBy(Css = "input#name")]
        [Name("FirstName")]
        public ITextField NameField;

        [FindBy(XPath = ".//a[@class='ui-slider-handle ui-state-default ui-corner-all' and position()=2]")]
        public Link SecondRoller;

        [FindBy(XPath = "//button[@type='submit' and contains(., 'Submit')]")]
        public IButton SubmitButton;

        public List<string> GetFormValue()
        {
            var fields = new List<string> { NameField.Value, LastNameField.Value, DescriptionField.Value };
            return fields;
        }

        public void FillForm(Contact contact)
        {
            NameField.NewInput(contact.FirstName);
            LastNameField.NewInput(contact.LastName);
            DescriptionField.NewInput(contact.Description);
        }
    }
}
