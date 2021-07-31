namespace DocumentFill.Model.Control
{
    /// <summary>
    /// Исходные данные
    /// </summary>
    public interface ISourceData
    {
        IDataTableContainer TableContainer { get; set; }
        // IPatternsContainer  Patterns       { get; set; }
        /// <summary>
        /// Получить исходные данные из XLSX
        /// </summary>
        /// <param name="fileTablePath">Путь к файлу XLSX</param>
        void GetSourceDataTable(string fileTablePath);
        /// <summary>
        /// Получить исходные данные о файлах шаблонах в папке
        /// </summary>
        /// <param name="patternsFolderPath">Путь к папке с шаблонами</param>
        void GetSourceDataPatterns(string patternsFolderPath);
        
    }
}