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
        /// Словарь со списком заменяемых имен из таблицы
        /// </summary>
        /// <remarks>
        /// Ключ - номер столбца в таблице, значение - заменяемое имя
        /// </remarks>
        Dictionary<string, int> KeyInTable { get; }
        /// <summary>
        /// Список всех указанных шаблонов
        /// </summary>
        List<String> PatternName { get; }
    }
}