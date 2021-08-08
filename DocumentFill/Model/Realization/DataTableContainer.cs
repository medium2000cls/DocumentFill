using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using ExcelDataReader;

namespace DocumentFill.Model
{
    /// <inheritdoc />
    public class DataTableContainer : IDataTableContainer
    {
        public DataTableContainer(DataTable table)
        {
            Table = table;
        }

        private Dictionary<int, string> _keyInTable;
        private List<string>            _patternName;
        
        public  DataTable               Table { get; set; }
        
        public Dictionary<int, string>  KeyInTable
        {
            get
            {
                if (_keyInTable == null)
                {
                    _keyInTable = AddDataInKeyInTable(Table);
                    return _keyInTable;
                }
                else
                {
                    return _keyInTable;
                }
            }
            private set => _keyInTable = value;
        }
        public List<string>             PatternName
        {
            get
            {
                if (_patternName == null)
                {
                    _patternName = FillingInListPatternNames(Table);
                    return _patternName;
                }
                else
                {
                    return _patternName;
                }
            }
            private set => _patternName = value;
        }

        private Dictionary<int, String> AddDataInKeyInTable(DataTable table)
        {
            Dictionary<int, String> keyInTable = new Dictionary<int, string>();
            for (int i = 0; i < table.Rows[3].ItemArray.Length; i++)
            {
                if (!String.IsNullOrEmpty(table.Rows[3][i].ToString()))
                {
                    keyInTable.Add(i, table.Rows[3][i].ToString());
                }
            }
            return keyInTable;
        }

        private List<String> FillingInListPatternNames(DataTable table)
        {
            List<String> patternName = new List<string>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                var s = table.Rows[i][0].ToString();
                if (!string.IsNullOrEmpty(s))
                {
                    patternName.Add(s);
                }
            }
            patternName = patternName.GroupBy(x => x)
                                     .Select(y => y.Key)
                                     .ToList();
            return patternName;
        }
    }
}