using System;
using System.Collections.Generic;

namespace DocumentFill.Model
{
    /// <summary>
    /// Документ
    /// </summary>
    public interface IDocument
    {
        /// <summary>
        /// Имя
        /// </summary>
        String                     Name            { get; }
        /// <summary>
        /// Полное имя
        /// </summary>
        String                     FullName        { get; }
        /// <summary>
        /// Используемый щаблон
        /// </summary>
        IPattern                   WorkPattern     { get; }
        /// <summary>
        /// Словарь
        /// </summary>
        /// <remarks>
        /// Ключ - Фраза которая будет заменена, значение - фраза на которую будет произведена замена 
        /// </remarks>
        Dictionary<String, String> KeyValueFromDoc { get; }
        /// <summary>
        /// Заполнить документ
        /// </summary>
        void                       FillDoc();
        /// <summary>
        /// Сохранить документ
        /// </summary>
        void                       SaveDoc();
    }
}