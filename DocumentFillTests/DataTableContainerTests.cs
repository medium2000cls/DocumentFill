using System.Collections.Generic;
using System.Data;
using DocumentFill.Model;
using DocumentFill.Model.Control;
using NUnit.Framework;
using Moq;

namespace DocumentFillTests
{
    public class DataTableContainerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddDataInKeyInTable_LoadData_KeyInTableIsNotNull()
            //          название метода      _действие     _ожидаемый результат
        {
            //Arrange      Установки
            DataTable stubDt = GetStubDt();
            IDataTableContainer dataTableContainer = new DataTableContainer(stubDt);
            //Act          Действие
            var dicKiT = dataTableContainer.KeyInTable;
            //Assert       Результат
            Assert.That(dicKiT, !Is.Null.Or.Empty);
        }
        [Test]
        public void FillingInListPatternNames_LoadData_ListPatternNameIsNotNull()
            //          название метода      _действие     _ожидаемый результат
        {
            //Arrange      Установки
            DataTable stubDt = GetStubDt();
            IDataTableContainer dataTableContainer = new DataTableContainer(stubDt);
            //Act          Действие
            var dicPatternNames = dataTableContainer.PatternName;
            //Assert       Результат
            Assert.That(dicPatternNames, !Is.Null.Or.Empty);
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
            for (int i = 0; i < 5; i++)
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