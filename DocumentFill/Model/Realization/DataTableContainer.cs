using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DocumentFill.Model
{
    /// <inheritdoc />
    public class DataTableContainer : IDataTableContainer
    {
        public DataTableContainer(DataTable table, Dictionary<int, string> keyInTable, List<string> patternName)
        {
            Table = table;
            KeyInTable = keyInTable;
            PatternName = patternName;
        }

        public DataTable               Table       { get; }
        public Dictionary<int, string> KeyInTable  { get; }
        public List<string>            PatternName { get; private set; }

    }
}