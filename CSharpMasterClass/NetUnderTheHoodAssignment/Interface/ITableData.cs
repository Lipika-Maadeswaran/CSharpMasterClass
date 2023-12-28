using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetUnderTheHoodAssignment.Interface
{
    public interface ITableData
    {
        IEnumerable<string> Columns { get; }
        int RowCount { get; }
        object GetValue(string columnName, int rowIndex);
    }
}
