using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Calculator.UnitTests
{
    public class Calculator1Tests
    {
        Calculator1? calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator1();
        }

        [Test]
        [TestCase( new[] { 10, 24, 15, 80, 99, 203, 400, 50, 90, 99, 100 }, 63)] 
        [TestCase(new[] { 10, 20, 30, 40, 50 }, 30)]
        public void MeanofNumberInput_WhenCalled_ReturnTheMean(int[] list, double expectedResult)
        {
            calculator=new Calculator1();

            var result = calculator.MeanofNumberInput(list);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(null)]        
        public void MeanofNumberInput_WhenInputIsNull_ThrowArgumentNullException(int[] list)
        {
            calculator = new Calculator1();

            Assert.That(() => calculator.MeanofNumberInput(list),
                Throws.Exception.TypeOf<ArgumentNullException>());
        }

        [Test]
        [TestCase(49, 7)]
        [TestCase(25,5)]
        public void SquareRoot_WhenCalled_ReturnTheSquareRoot(int? number, double expectedResult)
        {
            calculator = new Calculator1();

            var result = calculator.SquareRoot(number);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(-10)]
        public void SquareRoot_WhenNumberIsOutOfRange_ThrowArgumentOutOfRangeException(int? number)
        {
            calculator = new Calculator1();

            Assert.That(() => calculator.SquareRoot(number),
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(null)]
        public void SquareRoot_WhenNumberIsNull_ThrowArgumentNullException(int? number)
        {
            calculator = new Calculator1();

            Assert.That(() => calculator.SquareRoot(number),
                Throws.Exception.TypeOf<ArgumentNullException>());
        }

        [Test]
       // [TestCase(new[] { 10, 24, 15, 80, 99, 203, 400, 50, 90, 99, 100 }, 63)]
        [TestCase(new[] { 6, 2, 3, 1 }, 1.87)]
        public void StandardDeviation_WhenCalled_ReturnTheStandardDeviation(int[] list, double expectedResult)
        {
            calculator = new Calculator1();

            var result = calculator.StandardDeviation(list);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(null)]
        public void StandardDeviation_WhenInputIsNull_ThrowArgumentNullException(int[] list)
        {
            calculator = new Calculator1();

            Assert.That(() => calculator.StandardDeviation(list),
                Throws.Exception.TypeOf<ArgumentNullException>());
        }
    }
}