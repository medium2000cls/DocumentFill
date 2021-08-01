using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using ExcelDataReader;

namespace DocumentFill.Model.Control
{
    public class SourceData : ISourceData
    {
        public SourceData(string fileTablePath, IDataTableContainer tableContainer, string patternsFolderPath, IPatternsContainer patterns)
        {
            this.FileTablePath = fileTablePath;
            TableContainer = tableContainer;
            this.PatternsFolderPath = patternsFolderPath;
            Patterns = patterns;
        }

        public string              FileTablePath      { get; set; }
        public IDataTableContainer TableContainer     { get; set; }
        public string              PatternsFolderPath { get; set; }
        public IPatternsContainer  Patterns           { get; set; }

        public void GetSourceDataTable()
        {
            TableContainer.Table = GetDataTable(FileTablePath);
            TableContainer.PatternName = FillingInListPatternNames(TableContainer.Table);
            TableContainer.KeyInTable = AddDataInKeyInTable(TableContainer.Table);
        }

        public void GetSourceDataPatterns()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Заполнение из таблицы Excel, экземпляра DataTable типа данных. 
        /// </summary>
        /// <param name="filePath">Путь к файлу Excel</param>
        public DataTable GetDataTable(string filePath)
        {
            DataSet repData;
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    do
                    {
                        while (reader.Read())
                        {
                        }
                    } while (reader.NextResult());
                    repData = reader.AsDataSet();
                }
            }
            return repData.Tables[0];
        }

        /// <summary>
        /// Заполнение списка имен шаблонов
        /// </summary>
        public List<String> FillingInListPatternNames(DataTable table)
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

        /// <summary>
        /// Загрузить данные в список заменяемых имен
        /// </summary>
        public Dictionary <int, String> AddDataInKeyInTable(DataTable table)
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
    }
}