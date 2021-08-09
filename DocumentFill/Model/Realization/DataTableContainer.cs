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

        private Dictionary<string, int> _keyInTable;
        private List<string>            _patternName;
        public  DataTable               Table { get; set; }
        public Dictionary<string, int> KeyInTable
        {
            get { return _keyInTable ??= AddDataInKeyInTable(Table); }
            private set => _keyInTable = value;
        }
        public List<string> PatternName
        {
            get { return _patternName ??= FillingInListPatternNames(Table); }
            private set => _patternName = value;
        }

        private Dictionary<string, int> AddDataInKeyInTable(DataTable table)
        {
            Dictionary<string, int> keyInTable = new Dictionary<string, int>();
            for (int i = 0; i < table.Rows[3].ItemArray.Length; i++)
            {
                if (!String.IsNullOrEmpty(table.Rows[3][i].ToString()))
                {
                    keyInTable.Add(table.Rows[3][i].ToString(), i);
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