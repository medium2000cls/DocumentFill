using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using DocumentFill.Model.External;
using DocumentFill.Model.Wrapper;

namespace DocumentFill.Model
{
    public class Controller
    {
        private string              _fileTablePath;
        private string              _patternsFolderPath;
        private DataTable           _dataTable;
        private List<string>        _dataPatterns;
        private List<IPattern>      _patterns;
        private ISourceData         _sourceData;
        private IDataTableContainer _dataTableContainer;

        /// <summary>
        /// Связывание компонентов
        /// </summary>
        public void Initialise()
        {
            _fileTablePath = null;
            _patternsFolderPath = null;
            _dataTable = null;
            _dataPatterns = null;
            _patterns = null;

            _sourceData = new SourceData(_dataTable, _dataPatterns, _fileTablePath, _patternsFolderPath);
            _dataTableContainer = new DataTableContainer(_dataTable);
        }

        /// <summary>
        /// Метод который ищет из имен шаблонов в каталоге, имена шаблонов из таблицы
        /// </summary>
        /// <param name="patternsNameFromTable">Лист имен шаблонов из таблицы</param>
        /// <param name="patternsNameFromDirectory">Лист имен шаблонов из каталога</param>
        /// <returns>Список созданных шаблонов</returns>
        public List<IPattern> GetWorkPattern(List<string> patternsNameFromTable, List<string> patternsNameFromDirectory)
        {
            List<IPattern> patterns = new List<IPattern>();
            Regex regex = new Regex(@"(\w+\s*){1,6}\.docx$");
            foreach (var el in patternsNameFromTable)
            {
                var t = patternsNameFromDirectory.Find(s => regex.Match(s).Value == el);
                if (!string.IsNullOrEmpty(t))
                {
                    var pattern = new Pattern(new FileInfoWrapper(new FileInfo(t)));
                    patterns.Add(pattern);
                }
            }
            return patterns;
        }
        
        public void FillDocument(string targetDirectoryPath, int line)
        {
            //Узнаю шаблон
            var patternFromTable = _dataTableContainer.Table.Rows[line][0].ToString();
            var pattern = _patterns.Find(s => s.Name == patternFromTable);
            //Копирую шаблон
            var newFileFullName = targetDirectoryPath + pattern.Name;
            File.Copy(pattern.PatternFileInfo.FullName, newFileFullName);
            //Получаю информацию о новом файле
            IFileInfo newFile = new FileInfoWrapper(new FileInfo(newFileFullName));
            //Достаю из таблицы название файла и подписываю файл
            int columnIndex;
            string newName = newFile.Name;
            if (_dataTableContainer.KeyInTable.ContainsKey("Название файла"))
            {
                columnIndex = _dataTableContainer.KeyInTable["Название файла"];
                newName = newFile.DirectoryName + @"/" + _dataTableContainer.Table.Rows[4][columnIndex].ToString() + ".docx";
            }
            File.Replace(newFile.FullName, newName, newFile.FullName + "backup");
            
        }
    }
}