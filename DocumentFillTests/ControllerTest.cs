using System.Collections.Generic;
using System.Data;
using DocumentFill.Model;
using Moq;
using NUnit.Framework;

namespace DocumentFillTests
{
    public class ControllerTest
    {
        [SetUp]
        public void Setup()
        {
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

            Mock<Controller> controlerMock = new Mock<Controller>((string) null, (string) null, (DataTable) null,
                (List<string>) null, (List<IPattern>) null) {CallBase = true};
            //Act          Действие
            var result = controlerMock.Object.GetWorkPattern(patternsNameFromTable, patternsNameFromDirectory);
            //Assert       Результат
            Assert.That(result, !Is.Null.Or.Empty, "Значение не должно быть Null или пустым");
            Assert.That(result.Count, Is.EqualTo(2), "Колличество должно быть равно 2");
        }
    }
}