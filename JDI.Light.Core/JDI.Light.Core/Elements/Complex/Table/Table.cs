using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JDI.Light.Core.Asserts;
using JDI.Light.Core.Elements.Base;
using JDI.Light.Core.Factories;
using JDI.Light.Core.Tools.Switcher;
using OpenQA.Selenium;

namespace JDI.Light.Core.Elements.Complex.Table
{
    public class Table : UIElement
    {
        private CacheValue<Line> _row;
        public Table(By locator) : base(locator)
        {
            TableHeadersLocator = By.XPath(".//tr/th");
            TableBodyLocator = By.XPath(".//tbody");
            TableFooterLocator = By.XPath(".//tfoot");
            TableRowsLocator = By.XPath(".//tr");
            TableCellsLocator = By.XPath(".//td");
            _row = new CacheValue<Line>(() => Row(1));
        }

        public By TableHeadersLocator { get; set; }
        public By TableBodyLocator { get; set; }
        public By TableFooterLocator { get; set; }
        public By TableRowsLocator { get; set; }
        public By TableCellsLocator { get; set; }

        public List<UIElement> Headers => Body.FindElements(TableHeadersLocator)
            .Select(e => UIElementFactory.CreateInstance<UIElement>(TableHeadersLocator, Body, e)).ToList();
        public UIElement Body => UIElementFactory.CreateInstance<UIElement>(TableBodyLocator, this);
        public UIElement Footer => UIElementFactory.CreateInstance<UIElement>(TableFooterLocator, this);
        public List<UIElement> Rows => Body.FindElements(TableRowsLocator)
            .Select(e => UIElementFactory.CreateInstance<UIElement>(TableRowsLocator, Body, e)).ToList();

        public List<List<UIElement>> Cells => Rows.Select(r => r.FindElements(TableCellsLocator)
            .Select(e => UIElementFactory.CreateInstance<UIElement>(TableCellsLocator, r, e)).ToList()).ToList();

        public Line Row(params TableMatcher[] matchers)
        {
            var lines = TableMatcher.Table_Matcher.Invoke(this, matchers);
            if (lines == null || lines.Count.Equals(0))
            {
                return null;
            }
            var result = new List<string>();
            for (var i = 0; i < Headers.Count; i++)
            {
                result.Add(lines.ElementAt(i).Text);
            }
            return Line.InitLine(result, Headers.Select(h => h.Text).ToList());
        }

        public Line Row()
        {
            return _row.Get();
        }

        public Line Row(int rowNum)
        {
            return new Line(WebRow(rowNum), Headers.Select(h => h.Text).ToList());
        }

        public List<UIElement> WebRow(int rowNum)
        {
            if (rowNum < 1)
            {
                throw new ArgumentException($"Rows numeration starts from 1, but requested index is {rowNum}");
            }
            if (rowNum > Rows.Count)
            {
                throw new ArgumentException($"Table has {Rows.Count} rows, but requested index is {rowNum}");
            }
            return Cells.ElementAt(rowNum);
        }

        public static readonly Func<string, string> TrimPreview = p => p.Trim().Replace(" +", " ").Replace("\n", "");

        public TableAssert Is()
        {
            return new TableAssert(this);
        }

        public TableAssert AssertThat()
        {
            return Is();
        }

        public TableAssert Has()
        {
            return Is();
        }
    }
}
