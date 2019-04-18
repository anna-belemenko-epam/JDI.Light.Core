using JDI.Light.Core.Attributes;
using JDI.Light.Core.Elements.Common;
using JDI.Light.Core.Elements.Composite;
using JDI.Light.Core.Tests.UIObjects.Forms;

namespace JDI.Light.Core.Tests.UIObjects.Pages
{
    public class DatesPage : WebPage
    {
        [FindBy(Css = "main form")]
        public ContactForm ContactForm;

        [FindBy(Css = "#datepicker input")]
        public DatePicker Datepicker;
    }
}
