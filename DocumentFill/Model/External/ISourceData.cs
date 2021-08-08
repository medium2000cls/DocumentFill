using System.Collections.Generic;
using System.Data;

namespace DocumentFill.Model.External
{
    /// <summary>
    /// Исходные данные
    /// </summary>
    public interface ISourceData
    {
        /// <summary>
        /// Исходная таблица из внешнего источника
        /// </summary>
        DataTable     SourceDataTable    { get; }
        /// <summary>
        /// Список поных имен шаблонов
        /// </summary>
        List<string>  SourceDataPatterns { get; }
        string FileTablePath      { get; set; }
        string PatternsFolderPath { get; set; }
    }
}