using System;
using System.Collections.Generic;
using System.IO;
using DocumentFill.Model.Wrapper;

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
        /// Информация о файле шаблона из файловой системы
        /// </summary>
        IFileInfo PatternFileInfo { get; }
        
        /// <summary>
        /// Список фраз из шаблона которые должны быть заменены
        /// </summary>
        List<String> KeyInPattern { get; }
    }
}