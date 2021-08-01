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
        public SourceData(string fileTablePath, string patternsFolderPath)
        {
            FileTablePath = fileTablePath;
            PatternsFolderPath = patternsFolderPath;
        }

        public string FileTablePath      { get; set; }
        public string PatternsFolderPath { get; set; }

        public DataTable GetSourceDataTable(string fileTablePath)
        {
            DataSet repData;
            using (var stream = File.Open(fileTablePath, FileMode.Open, FileAccess.Read))
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

        public void GetSourceDataPatterns(string patternsFolderPath)
        {
            throw new NotImplementedException();
        }
    }
}