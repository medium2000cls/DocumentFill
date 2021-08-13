using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using DocumentFill.Model.Wrapper;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace DocumentFill.Model
{
    /// <inheritdoc />
    public class DocumentFactory : IDocumentFactory
    {
        public DocumentFactory(IDataTableContainer dataTableContainer, List<IPattern> patterns,
                               string              targetDirectoryPath)
        {
            DataTableContainer = dataTableContainer;
            Patterns = patterns;
            TargetDirectoryPath = targetDirectoryPath;
        }

        public  IDataTableContainer DataTableContainer  { get; }
        public  List<IPattern>      Patterns            { get; }
        public  string              TargetDirectoryPath { get; }
        public  IFileInfo           NewDocument         { get; private set; }

        #region Приватные переменные

        private IPattern  _pattern;

        #endregion

        public bool FillDocument(int line)
        {
            _pattern = null;
            NewDocument = null;

            //Узнаю шаблон
            var patternFromTable = DataTableContainer.Table.Rows[line][0].ToString();
            _pattern = Patterns.Find(s => s.Name == patternFromTable);
            if (_pattern != null)
            {
                NewDocument = NewFile(_pattern);
                ReplaceAllKeys(line);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Создать новый документ
        /// </summary>
        /// <param name="pattern">Шаблон документа</param>
        /// <returns>Новый документ</returns>
        public virtual IFileInfo NewFile(IPattern pattern)
        {
            //Копирую шаблон
            var newFileFullName = TargetDirectoryPath + pattern.Name;
            File.Copy(pattern.PatternFileInfo.FullName, newFileFullName);

            //Получаю информацию о новом файле
            IFileInfo newFile = new FileInfoWrapper(new FileInfo(newFileFullName));

            //Достаю из таблицы название файла и подписываю файл
            int columnIndex;
            string newName = newFile.Name;
            if (DataTableContainer.KeyInTable.ContainsKey("Название файла"))
            {
                columnIndex = DataTableContainer.KeyInTable["Название файла"];
                newName = newFile.DirectoryName + @"/" + DataTableContainer.Table.Rows[4][columnIndex] +
                          ".docx";
            }
            File.Replace(newFile.FullName, newName, newFile.FullName + "backup");
            return newFile;
        }

        /// <summary>
        /// Заменить все ключевые слова
        /// </summary>
        /// <param name="line">Номер строки, из которой будут браться данные</param>
        public virtual void ReplaceAllKeys(int line)
        {
            //Выполняю замену всего текста
            using (var document = DocX.Load(NewDocument.FullName))
            {
                foreach (var key in _pattern.KeyInPattern)
                {
                    var keyWithoutCurlyBrackets = Regex.Match(key, @"(\w+\s*){1,6}").Value;
                    string columnValue = keyWithoutCurlyBrackets;

                    if (DataTableContainer.KeyInTable.ContainsKey(keyWithoutCurlyBrackets))
                    {
                        int numberColumn = DataTableContainer.KeyInTable[keyWithoutCurlyBrackets];
                        columnValue = DataTableContainer.Table.Rows[line][numberColumn].ToString();
                    }
                    //todo не забыть удалить форматирование текста при замене
                    document.ReplaceText(key, columnValue, false, RegexOptions.IgnoreCase,
                        new Formatting() {Bold = true, FontColor = System.Drawing.Color.Green});
                }

                //Сохраняю документ
                document.Save();
            }
        }
    }
}