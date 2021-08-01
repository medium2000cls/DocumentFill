using System.Collections.Generic;
using System.Data;
using DocumentFill.Model;
using DocumentFill.Model.Control;
using NUnit.Framework;
using Moq;

namespace DocumentFillTests
{
    public class SourceDataTests
    {
        string              _fileTablePath;
        IDataTableContainer _tableContainer;
        string              _patternsFolderPath;
        IPatternsContainer  _patterns;

        [SetUp]
        public void Setup()
        {
            //Создаю таблицу
            _fileTablePath = "C://test.xlsx";
            _tableContainer = new DataTableContainer(new DataTable(), new Dictionary<int, string>(), new List<string>()); 
            _patternsFolderPath = "C://";
            _patterns = new PatternsContainer(new Dictionary<string, IPattern>());
        }

        [Test]
        public void GetSourceDataTable()
            //          название метода      _действие     _ожидаемый результат
        {
            //Arrange      Установки
            ISourceData sourceData = Mock.Of<SourceData>(sd => sd.GetDataTable(_fileTablePath) == GetStubDt()); 
                //new SourceData(_fileTablePath, _tableContainer, _patternsFolderPath, _patterns);
            sourceData.GetSourceDataTable();
            //Act          Действие
            //Assert       Результат

            Assert.That(sourceData.TableContainer.Table.Rows[3][3], Is.Not.Empty);
        }

        private DataTable GetStubDt()
        {
            DataTable stubDt = new DataTable();
            //создаю строки и столбцы
            DataColumn column;
            DataRow row;
            for (int i = 0; i < 20; i++)
            {
                column = new DataColumn();
                column.ColumnName = "Column " + i;
                stubDt.Columns.Add(column);
            }
            for (int i = 0; i < 2; i++)
            {
                row = stubDt.NewRow();
                for (int j = 0; j < 20; j++)
                {
                    row["Column " + j] = i * j + i;
                }
                stubDt.Rows.Add(row);
            }
            return stubDt;
        }
    }
}