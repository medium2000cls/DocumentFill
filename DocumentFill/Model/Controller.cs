using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using DocumentFill.Model.External;
using DocumentFill.Model.Wrapper;
using DocumentFill.View;
using Xceed.Words.NET;
using Formatting = Xceed.Document.NET.Formatting;

namespace DocumentFill.Model
{
    public class Controller
    {
        public Controller(MainForm mainForm)
        {
            _mainForm = mainForm;
            _startStop = false;
            Initialise();
            _mainForm.StartEventHandler += MainFormOnStartEventHandler;
            _mainForm.StopEventHandler += MainFormOnStopEventHandler;
            _mainForm.ReloadEventHandler += MainFormOnReloadEventHandler;
        }

        private void MainFormOnStartEventHandler(object sender, EventArgs e)
        {
            _startStop = true;
            _lineStartText = int.Parse(_mainForm.LineStartText);
            _lineEndText = int.Parse(_mainForm.LineEndText);
            for (int i = _lineStartText; i <= _lineEndText && _startStop; i++)
            {
                _documentFactory.FillDocument(i);
            }
        }

        private void MainFormOnStopEventHandler(object sender, EventArgs e)
        {
            _startStop = false;
        }

        private void MainFormOnReloadEventHandler(object sender, EventArgs e)
        {
            Initialise();
        }

        #region Компоненты

        private          string              _fileTablePath;
        private          string              _patternsFolderPath;
        private          DataTable           _dataTable;
        private          List<string>        _dataPatterns;
        private          List<IPattern>      _patterns;
        private          ISourceData         _sourceData;
        private          IDataTableContainer _dataTableContainer;
        private          IDocumentFactory    _documentFactory;
        private readonly MainForm            _mainForm;

        #endregion

        #region Приватные поля

        private bool _startStop;
        private int  _lineStartText;
        private int  _lineEndText;

        #endregion

        /// <summary>
        /// Связывание компонентов
        /// </summary>
        public void Initialise()
        {
            _fileTablePath = null;
            _patternsFolderPath = null;
            _dataTable = null;
            _dataPatterns = null;
            _sourceData = null;
            _dataTableContainer = null;
            _patterns = null;
            _documentFactory = null;


            _sourceData = new SourceData(_dataTable, _dataPatterns, _fileTablePath, _patternsFolderPath);
            _dataTableContainer = new DataTableContainer(_dataTable);
            _patterns = GetWorkPattern(_dataTableContainer.PatternName, _sourceData.SourceDataPatterns);
            _documentFactory = new DocumentFactory(_dataTableContainer, _patterns, _mainForm.FinalFolderText);
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
                    var pattern = new Pattern(new FileInfoWrapper(t));
                    patterns.Add(pattern);
                }
            }
            return patterns;
        }
    }
}