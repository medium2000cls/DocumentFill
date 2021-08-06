using System;
using System.Collections.Generic;
using System.Data;

namespace DocumentFill.Model
{
    /// <summary>
    /// Контейнер с таблицей
    /// </summary>
    public interface IDataTableContainer
    {
        /// <summary>
        /// Таблица
        /// </summary>
        DataTable Table { get; set; }
        /// <summary>
        /// Словарь
        /// </summary>
        /// <remarks>
        /// Ключ - номер столбца в таблице, значение - заменяемое имя
        /// </remarks>
        Dictionary<int, String> KeyInTable { get; }
        /// <summary>
        /// Список всех указанных шаблонов
        /// </summary>
        List<String> PatternName { get; }
    }
}