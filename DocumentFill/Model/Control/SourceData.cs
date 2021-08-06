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
        public DataTable    SourceDataTable    { get; set; }
        public List<string> SourceDataPatterns { get; set; }
        public string       FileTablePath      { get; set; }
        public string       PatternsFolderPath { get; set; }

        public SourceData(DataTable sourceDataTable, List<string> sourceDataPatterns, string fileTablePath, string patternsFolderPath)
        {
            SourceDataTable = sourceDataTable;
            SourceDataPatterns = sourceDataPatterns;
            FileTablePath = fileTablePath;
            PatternsFolderPath = patternsFolderPath;
        }

        public void GetSourceDataTable()
        {
            DataSet repData;
            using (var stream = File.Open(FileTablePath, FileMode.Open, FileAccess.Read))
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
            SourceDataTable = repData.Tables[0];
        }

        public void GetSourceDataPatterns()
        {
            var d = Directory.GetFiles(PatternsFolderPath, "*.doc", SearchOption.TopDirectoryOnly).ToList();
            SourceDataPatterns = d;
        }
    }
}