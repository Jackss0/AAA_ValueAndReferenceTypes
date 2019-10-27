using MyUnitTesting;
using System;
using Xunit;

namespace MyUnitTestingTests
{
    public class UnitTest1
    {
        MyClass myClass = new MyClass();

        [Fact]
        public void ReturnMethodShoulReturnNull()
        {
            //Arrange
            string word = null;
            //Act
            var CurrentResult = myClass.ReturnWord(word);
            //Assert
            Assert.Null(CurrentResult);
        }

        [Fact] 
        public void ReturnMethodShoulReturnNotNull()
        {
            string word = "word";

            var CurrentResult = myClass.ReturnWord(word);

            Assert.NotNull(CurrentResult);
        }

        [Fact]
        public void ReturnMethodShoulReturnNotEmpty()
        {
            string word = "xd";

            var CurrentResult = myClass.ReturnWord(word);

            Assert.NotEmpty(CurrentResult);
        }
    }
}
