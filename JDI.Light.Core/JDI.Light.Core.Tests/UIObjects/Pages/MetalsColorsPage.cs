using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Attributes;
using JDI.Light.Core.Elements.Base;
using JDI.Light.Core.Elements.Common;
using JDI.Light.Core.Elements.Composite;
using JDI.Light.Core.Interfaces.Common;
using JDI.Light.Core.Tests.UIObjects.Sections;
using OpenQA.Selenium;

namespace JDI.Light.Core.Tests.UIObjects.Pages
{
    public class MetalsColorsPage : WebPage
    {
        public class CustomCheck
        {
            public static bool CheckFunc(UIElement e)
            {
                var a = e.Get<UIElement>(By.XPath("//*[@id='elements-checklist']//*[*[text()='Water']]/input"));
                return a.FindImmediately(() => a.GetAttribute("checked") != null, false);
            }
        }

        [FindBy(Id = "calculate-button")]
        public Label Calculate;

        [Css("#calculate-button")]
        public IWebElement CalculateButton;

        [FindBy(Id = "calculate-button")]
        public ILabel CalculateLabel;

        [FindBy(Css = ".summ-res")]
        public ITextElement CalculateText;

        [FindBy(XPath = "//*[@id='elements-checklist']//*[text()='Water']")]
        [IsChecked(typeof(CustomCheck), nameof(CustomCheck.CheckFunc))]
        public CheckBox CbWater;

        [FindBy(Id = "summary-block")]
        public Summary SummaryBlock;

        [FindBy(Css = "#colors")]
        public IDropDown Colors { get; set; }

        [FindBy(Css = "#colors .filter-option")]
        public IDropDown ColorsDropDownText { get; set; }

        [FindBy(Css = "#metals")]
        public IDataList MetalsDataList { get; set; }

        [FindBy(Css = "#metals input")]
        public IDataList MetalsInput { get; set; }

        [FindBy(Css = "#submit-button")]
        public Button SubmitButton { get; set; }

        [FindBy(Css = "#metals")]
        public ComboBox MetalsComboBox { get; set; }

        [FindBy(Css = "#metals input")]
        public ComboBox MetalsInputComboBox { get; set; }
    }
}
