using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using ExcelDataReader;

namespace DocumentFill.Model.External
{
    /// <inheritdoc />
    public class SourceData : ISourceData
    {
        #region Приватные поля

        private List<string> _sourceDataPatterns;
        private DataTable    _sourceDataTable;

        #endregion

        public DataTable SourceDataTable
        {
            get { return _sourceDataTable ??= GetSourceDataTable(); }
            private set => _sourceDataTable = value;
        }
        public List<string> SourceDataPatterns
        {
            get { return _sourceDataPatterns ??= GetSourceDataPatterns(); }
            private set => _sourceDataPatterns = value;
        }
        public  string       FileTablePath      { get; set; }
        public  string       PatternsFolderPath { get; set; }

        public SourceData(DataTable sourceDataTable, List<string> sourceDataPatterns, string fileTablePath, string patternsFolderPath)
        {
            SourceDataTable = sourceDataTable;
            SourceDataPatterns = sourceDataPatterns;
            FileTablePath = fileTablePath;
            PatternsFolderPath = patternsFolderPath;
        }

        public DataTable GetSourceDataTable()
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
            return repData.Tables[0];
        }

        public List<string> GetSourceDataPatterns()
        {
            List<string> d = Directory.GetFiles(PatternsFolderPath, "*.doc*", SearchOption.TopDirectoryOnly).ToList();
            return d;
        }
        

    }
}