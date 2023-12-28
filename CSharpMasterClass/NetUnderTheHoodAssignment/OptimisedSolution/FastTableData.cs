using NetUnderTheHoodAssignment.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetUnderTheHoodAssignment.OptimisedSolution
{
    internal class FastTableData : ITableData
    {
        private readonly List<FastRow> _rows;
        public int RowCount => _rows.Count;
        public IEnumerable<string> Columns { get; }

        public FastTableData(IEnumerable<string> columns, List<FastRow> rows)
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
