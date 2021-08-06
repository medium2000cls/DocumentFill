using System.Collections.Generic;
using System.Data;

namespace DocumentFill.Model.Control
{
    /// <summary>
    /// Исходные данные
    /// </summary>
    public interface ISourceData
    {
        DataTable     SourceDataTable    { get; }
        List<string>  SourceDataPatterns { get; }
        string FileTablePath      { get; set; }
        string PatternsFolderPath { get; set; }

        /// <summary>
        /// Получить исходные данные из XLSX
        /// </summary>
        /// <param name="fileTablePath">Путь к файлу XLSX</param>
        void GetSourceDataTable();

        /// <summary>
        /// Получить исходные данные о файлах шаблонах в папке
        /// </summary>
        /// <param name="PatternsFolderPath"></param>
        /// <param name="patternsFolderPath">Путь к папке с шаблонами</param>
        void GetSourceDataPatterns();
    }
}