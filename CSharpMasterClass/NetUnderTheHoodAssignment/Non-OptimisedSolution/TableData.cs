using NetUnderTheHoodAssignment.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetUnderTheHoodAssignment.Non_OptimisedSolution
{
    public class TableData : ITableData
    {
        private readonly List<Row> _rows;
        public int RowCount => _rows.Count;
        public IEnumerable<string> Columns { get; }

        public TableData(IEnumerable<string> columns, List<Row> rows)
        {
            _rows = rows;
            Columns = columns;
        }

        public object GetValue(string columnName, int rowIndex)
        {
            return _rows[rowIndex].GetAtColumn(columnName);
        }
    }
}
