using JDI.Light.Core.Elements.Complex.Table;

namespace JDI.Light.Core.Asserts
{
    public class TableAssert
    {
        protected Table table;

        public TableAssert(Table table)
        {
            this.table = table;
        }

        public TableAssert HasRowWithValues(params TableMatcher[] matchers)
        {
            Jdi.Assert.IsFalse(TableMatcher.Table_Matcher.Invoke(table, matchers).Count.Equals(0),
                "The row does not contain the following values in these columns.");
            return this;
        }
    }
}
