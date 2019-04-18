using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Text;
using JDI.Light.Core.Elements.Base;
using JDI.Light.Core.Elements.Common;
using JDI.Light.Core.Interfaces.Base;
using JDI.Light.Core.Interfaces.Common;
using OpenQA.Selenium;

namespace JDI.Light.Core.Settings
{
    public static class MapInterfaceToElement
    {
        public static readonly Dictionary<Type, Type> DefaultInterfacesMap = new Dictionary<Type, Type>
        {
            {typeof(IWebElement), typeof(UIElement)},
            {typeof(IBaseElement), typeof(UIElement)},
            {typeof(IBaseUIElement), typeof(UIElement)},
            {typeof(IButton), typeof(Button)},
            {typeof(ITextElement), typeof(TextElement)},
            {typeof(IImage), typeof(MediaTypeNames.Image)},
            {typeof(ITextArea), typeof(TextArea)},
            {typeof(ITextField), typeof(TextField)},
            {typeof(ILabel), typeof(Label)},
            {typeof(ICheckBox), typeof(CheckBox)},
            {typeof(IDatePicker), typeof(DatePicker)},
            {typeof(ILink), typeof(Link)},
            {typeof(ICheckList), typeof(CheckList) },
            {typeof(IRadioButton), typeof(RadioButton) },
            {typeof(IDropDown), typeof(DropDown) },
            {typeof(IDataList), typeof(DataList) },
            {typeof(IDateTimeSelector), typeof(DateTimeSelector) },
            {typeof(IRange), typeof(Range) }
        };

        public static Type ClassFromInterface(Type clazz)
        {
            return DefaultInterfacesMap[clazz];
        }
    }
}
