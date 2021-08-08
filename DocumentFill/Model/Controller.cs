using System.Collections.Generic;
using System.Data;
using DocumentFill.Model.Control;

namespace DocumentFill.Model
{
    public class Controller
    {
        public Controller(string fileTablePath, string patternsFolderPath, DataTable dataTable, List<string> sourceDataPatterns, Dictionary<string, IPattern> patterns)
        {
            _fileTablePath = fileTablePath;
            _patternsFolderPath = patternsFolderPath;
            _dataTable = dataTable;
            _sourceDataPatterns = sourceDataPatterns;
            _patterns = patterns;
        }

        private string                       _fileTablePath;
        private string                       _patternsFolderPath;
        private DataTable                    _dataTable;
        private List<string>                 _sourceDataPatterns;
        private Dictionary<string, IPattern> _patterns;
        
        private ISourceData         _sourceData;
        private IDataTableContainer _dataTableContainer;
        private IPatternsContainer  _patternsContainer;

        public void Initialise()
        {
            _fileTablePath = null;
            _patternsFolderPath = null;
            _dataTable = null;
            _sourceDataPatterns = null;
            _patterns = null;

            _sourceData = new SourceData(_dataTable, _sourceDataPatterns, _fileTablePath, _patternsFolderPath);
            _dataTableContainer = new DataTableContainer(_dataTable);
            _patternsContainer = new PatternsContainer(_patterns);
        }

        private void GetSourceDataTableContainer()
        {
            _sourceData.GetSourceDataTable();
        }

        private void GetSourceDataPatternsContainer()
        {
            _sourceData.GetSourceDataPatterns();
        }
        
        public void AddWorkPatternInPatternsContainer(List<string> patternsNameFromTable, List<string> patternsNameFromDirectory)
        {
            
        }

        
    }
}