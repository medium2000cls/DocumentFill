using System.Collections.Generic;
using System.Data;
using DocumentFill.Model;
using Moq;
using NUnit.Framework;

namespace DocumentFillTests
{
    public class ControllerTest
    {
        private Mock<Controller> controlerMock;
        
        [SetUp]
        public void Setup()
        {
            controlerMock = new Mock<Controller>() {CallBase = true};
        }

        [Test]
        public void GetWorkPattern_CompareTwoList_ReturnsListCount2()
        {
            //Arrange      Установки
            var patternsNameFromTable = new List<string>()
            {
                @"q.docx", @"q w.docx", @"qwer.docx"
            };
            var patternsNameFromDirectory = new List<string>()
            {
               @"D:\\Temp\q w.docx", @"D:\\Temp\qwer.docx", @"D:\\Temp\qw er.docx"
            };

            //Act          Действие
            var result = controlerMock.Object.GetWorkPattern(patternsNameFromTable, patternsNameFromDirectory);
            //Assert       Результат
            Assert.That(result, !Is.Null.Or.Empty, "Значение не должно быть Null или пустым");
            Assert.That(result.Count, Is.EqualTo(2), "Колличество должно быть равно 2");
        }

        [Test]
        public void FillDocument_DataProcessing_PdfFileComplite()
        {
            controlerMock.Object.FillDocument((string) null, 5);
        }
        
    }
}