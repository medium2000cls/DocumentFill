using System.Collections.Generic;
using DocumentFill.Model;
using DocumentFill.Model.Wrapper;
using Moq;
using NUnit.Framework;

namespace DocumentFillTests
{
    public class PatternTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FillingKeyInPattern_LoadData_ReturnListIsNotNull()
        //          название метода     _действие     _ожидаемый результат
        {
            //Arrange      Установки
            IFileInfo patternFileInfoStub = Mock.Of<IFileInfo>(st => st.FullName == @"D:\\Temp");
            List<string> listStub = new List<string>() {"One", "Two", "Th ree", "Fore", "One", "Two", "Th ree"};
            
            Mock<Pattern> patternMock = new Moq.Mock<Pattern>(patternFileInfoStub);
            patternMock.Setup(m => m.ReadRegExFromDocXFile(patternFileInfoStub)).Returns(listStub);
            patternMock.CallBase = true;
            
            //Act          Действие
            var keyInPattern = patternMock.Object.KeyInPattern;
            //Assert       Результат
            Assert.That(keyInPattern, !Is.Null.Or.Empty, "Первое обращение к свойству KeyInPattern");
            Assert.That(keyInPattern.Count, Is.EqualTo(4), "Колличество значений должно быть 4");
            
            keyInPattern = patternMock.Object.KeyInPattern;
            //Assert       Результат
            Assert.That(keyInPattern, !Is.Null.Or.Empty, "Второе обращение к свойству KeyInPattern");

        }
    }
}