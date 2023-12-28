using NetUnderTheHoodAssignment.CsvReading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetUnderTheHoodAssignment.Interface
{
    public interface ITableDataBuilder
    {
        public ITableData Build(CsvData csvData);
    }
}
