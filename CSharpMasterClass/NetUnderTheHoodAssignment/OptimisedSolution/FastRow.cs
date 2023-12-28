using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetUnderTheHoodAssignment.OptimisedSolution
{
    internal class FastRow
    {
        private Dictionary<string, int> _intsData = new();
        private Dictionary<string, bool> _boolData = new();
        private Dictionary<string, decimal> _decimalData = new();
        private Dictionary<string, string> _stringData = new();

        public void AssignCell(string columnName, bool value)
        {
            _boolData[columnName] = value;
        }
        public void AssignCell(string columnName, int value)
        {
            _intsData[columnName] = value;
        }
        public void AssignCell(string columnName, decimal value)
        {
            _decimalData[columnName] = value;
        }
        public void AssignCell(string columnName, string value)
        {
            _stringData[columnName] = value;
        }

        public object GetAtColumn(string columnName)
        {
            if (_stringData.ContainsKey(columnName))
            {
                return _stringData[columnName];
            }
            if (_decimalData.ContainsKey(columnName))
            {
                return _decimalData[columnName];
            }
            if (_intsData.ContainsKey(columnName))
            {
                return _intsData[columnName];
            }
            if (_boolData.ContainsKey(columnName))
            {
                return _boolData[columnName];
            }
            return null;
        }
    }
}
