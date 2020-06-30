using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalculateDataLibrary.Tests
{
    public class CalculateDataTests
    {
        [Fact]
        public void AddTwoNumbersShouldReturnTwo()
        {
            //Arrange
            CalculateData add = new CalculateData();

            double expected = 2;

            //Act
            double actual = add.AddTwoNumbers(1, 1);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubtractTwoNumbersShouldReturnTwo()
        {
            //Arrange
            CalculateData subtract = new CalculateData();

            double expected = 2;

            //Act
            double actual = subtract.SubtractTwoNumbers(4, 2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MultiplyTwoNumbersShouldReturnTwo()
        {
            //Arrange
            CalculateData multiply = new CalculateData();

            double expected = 2;

            //Act
            double actual = multiply.MultiplyTwoNumbers(1, 2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DivideTwoNumbersShouldReturnTwo()
        {
            //Arrange
            CalculateData divide = new CalculateData();

            double expected = 2;

            //Act
            double actual = divide.DivideTwoNumbers(4, 2);

            //Assert
            Assert.Equal(expected, actual);
        }

        //Addition method theory tests
        [Theory]
        [InlineData(2, 5, 7)]
        [InlineData(2.5, 2.5, 5)]
        [InlineData(-5, 5, 0)]
        

        public void AdditionShouldReturnExpectedValue(double theFirstNumber, double theSecondNumber, double expected)
        {
            //Arrange
            CalculateData add = new CalculateData();

            //Act
            double actual = add.AddTwoNumbers(theFirstNumber, theSecondNumber);

            //Assert
            Assert.Equal(expected, actual);
        }

        //Subtraction theory tests
        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(10, 5, 5)]
        [InlineData(5, 2.5, 2.50)]

        public void SubtractionShouldReturnExpectedValue(double theFirstNumber, double theSecondNumber, double expected)
        {
            //Arrange
            CalculateData subtract = new CalculateData();

            //Act
            double actual = subtract.SubtractTwoNumbers(theFirstNumber, theSecondNumber);

            //Assert
            Assert.Equal(expected, actual);
        }

        //Multiplication Theory Tests
        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(10, 5, 50)]
        [InlineData(-5, -5, 25)]

        public void MultiplicationShouldReturnExpectedValue(double theFirstNumber, double theSecondNumber, double expected)
        {
            //Arrange
            CalculateData multiply = new CalculateData();

            //Act
            double actual = multiply.MultiplyTwoNumbers(theFirstNumber, theSecondNumber);

            //Assert
            Assert.Equal(expected, actual);
        }

        //Division Theory Tests
        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(10, 5, 2)]
        [InlineData(50, 5, 10)]
        [InlineData(15, 0, 0)]

        public void DivideShouldReturnExpectedValue(double theFirstNumber, double theSecondNumber, double expected)
        {
            //Arrange
            CalculateData divide = new CalculateData();

            //Act
            double actual = divide.DivideTwoNumbers(theFirstNumber, theSecondNumber);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
