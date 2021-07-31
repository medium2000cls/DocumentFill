using System.Data;
using System.IO;






namespace DocumentFill.Model.Control
{
    public class SourceData : ISourceData
    {
        public IDataTableContainer TableContainer { get; set; }
        //public IPatternsContainer  Patterns       { get; set; }

        public void GetSourceDataTable(string fileTablePath)
        {
            throw new System.NotImplementedException();
        }

        public void GetSourceDataPatterns(string patternsFolderPath)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Заполнение из таблицы Excel, экземпляра DataTable типа данных. 
        /// </summary>
        /// <param name="filePath">Путь к файлу Excel</param>
        private void AddDataInRepData(string filePath)
        {
            DataSet RepData;
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
                    RepData = reader.AsDataSet();
                }
            }
        }
    }
}