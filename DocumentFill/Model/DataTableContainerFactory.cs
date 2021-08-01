using System.Collections.Generic;
using System.Data;

namespace DocumentFill.Model
{
    public class DataTableContainerFactory
    {
        public IDataTableContainer Create(DataTable table, Dictionary<int, string> keyInTable, List<string> patternName)
        {
            return new DataTableContainer(table, keyInTable, patternName);
        }
    }
}