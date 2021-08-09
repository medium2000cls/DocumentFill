using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using DocumentFill.Model.Wrapper;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace DocumentFill.Model
{
    /// <inheritdoc />
    public class Pattern : IPattern
    {
        public Pattern(IFileInfo patternFileInfo)
        {
            PatternFileInfo = patternFileInfo;
        }

        private List<string> _keyInPattern;
        public  string       Name            => PatternFileInfo.Name;
        public  IFileInfo    PatternFileInfo { get; }
        public List<string> KeyInPattern
        {
            get { return _keyInPattern ??= FillingKeyInPattern(PatternFileInfo); }
            private set => _keyInPattern = value;
        }

        /// <summary>
        /// Заполнить список заменяемых ключей.
        /// </summary>
        /// <returns>Список ключей</returns>
        public List<string> FillingKeyInPattern(IFileInfo patternFileInfo)
        {
            var keyInPattern = ReadRegExFromDocXFile(patternFileInfo);
            keyInPattern = keyInPattern.GroupBy(x => x)
                                       .Select(y => y.Key)
                                       .ToList();
            return keyInPattern;
        }

        /// <summary>
        /// Переопределяемый метод чтения ключей из файла Docx
        /// </summary>
        /// <param name="patternFileInfo">IFileInfo</param>
        /// <returns>List+string+ список ключей</returns>
        public virtual List<string> ReadRegExFromDocXFile(IFileInfo patternFileInfo)
        {
            List<string> keyInPattern;
            using (var document = DocX.Load(patternFileInfo.FullName))
            {
                keyInPattern = document.FindUniqueByPattern(@"\{.+?\}", RegexOptions.IgnoreCase);
            }
            return keyInPattern;
        }
    }
}