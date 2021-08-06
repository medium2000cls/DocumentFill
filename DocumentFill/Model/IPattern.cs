using System;
using System.Collections.Generic;

namespace DocumentFill.Model
{
    /// <summary>
    /// Шаблон
    /// </summary>
    public interface IPattern
    {
        /// <summary>
        /// Имя шаблона
        /// </summary>
        String Name { get; }
        /// <summary>
        /// Список фраз из шаблона которые должны быть заменены
        /// </summary>
        List<String> KeyInPattern { get; }
    }
}