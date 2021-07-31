using System;
using System.Collections.Generic;

namespace DocumentFill.Model
{
    /// <summary>
    /// Контейнер шаблонов
    /// </summary>
    public interface IPatternsContainer : IEnumerable<IPattern>
    {
        /// <summary>
        /// Словарь
        /// </summary>
        /// <remarks>
        ///Ключ - имя шаблона, заначение - шаблон
        /// </remarks>
        Dictionary <String, IPattern> Patterns { get; }
    }
}