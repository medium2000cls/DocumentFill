namespace DocumentFill.Model.Control
{
    /// <summary>
    /// Исходные данные
    /// </summary>
    public interface ISourceData
    {
        string              FileTablePath      { get; set; }
        IDataTableContainer TableContainer     { get; set; }
        string              PatternsFolderPath { get; set; }
        IPatternsContainer  Patterns           { get; set; }

        /// <summary>
        /// Получить исходные данные из XLSX
        /// </summary>
        /// <param name="fileTablePath">Путь к файлу XLSX</param>
        void GetSourceDataTable();
        
        /// <summary>
        /// Получить исходные данные о файлах шаблонах в папке
        /// </summary>
        /// <param name="patternsFolderPath">Путь к папке с шаблонами</param>
        void GetSourceDataPatterns();
        
    }
}