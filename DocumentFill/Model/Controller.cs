using System.Collections.Generic;
using System.Data;
using System.IO;
using DocumentFill.Model.External;
using DocumentFill.Model.Wrapper;

namespace DocumentFill.Model
{
    public class Controller
    {
        public Controller(string fileTablePath, string patternsFolderPath, DataTable dataTable, List<string> dataPatterns, List<IPattern> patterns)
        {
            _fileTablePath = fileTablePath;
            _patternsFolderPath = patternsFolderPath;
            _dataTable = dataTable;
            _dataPatterns = dataPatterns;
            _patterns = patterns;
        }

        private string       _fileTablePath;
        private string       _patternsFolderPath;
        private DataTable    _dataTable;
        private List<string> _dataPatterns;
        private List<IPattern>       _patterns;
        
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

       
        public List<IPattern> GetWorkPattern(List<string> patternsNameFromTable, List<string> patternsNameFromDirectory)
        {
            //todo Возможны ошибки, связанные с полным и неполным имененем шаблона
            List<IPattern> patterns = new List<IPattern>();
            foreach (var el in patternsNameFromTable)
            {
                var t = patternsNameFromDirectory.Find(s => s == el);
                if (!string.IsNullOrEmpty(t))
                {
                    var pattern = new Pattern(new FileInfoWrapper(new FileInfo(t)));
                    patterns.Add(pattern);
                }
            }
            return patterns;
        }

        
    }
}