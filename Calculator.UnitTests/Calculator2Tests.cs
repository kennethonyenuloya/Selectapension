using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Calculator.UnitTests
{
    public class Calculator2Tests
    {
        Calculator2 calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator2();
        }

        [Test]
        [TestCase(100, 4,5, 121.67)] 
        public void CompoundIncrease_WhenCalled_ReturnTheValue(int? amount, int? rate, int? time, double expectedResult)
        {
            var result = calculator.CompoundIncrease(amount, rate, time);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(null,4,5)]        
        public void CompoundIncrease_WhenAtLeastOneArgumentIsNull_ThrowArgumentNullException(int? amount, int? rate, int? time)
        {
            Assert.That(() => calculator.CompoundIncrease(amount, rate, time),
                Throws.Exception.TypeOf<ArgumentNullException>());
        }

        [Test]
        [TestCase(100, 0, 5)]
        public void CompoundIncrease_WhenAtLeastOneArgumentIsOutOfRange_ThrowArgumentOutOfRangeException(int? amount, int? rate, int? time)
        {
            Assert.That(() => calculator.CompoundIncrease(amount, rate, time),
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(100, 4, 5, 81.54)]
        public void CompoundDecrease_WhenCalled_ReturnTheValue(int? amount, int? rate, int? time, double expectedResult)
        {
            var result = calculator.CompoundDecrease(amount, rate, time);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(null, 4, 5)]
        public void CompoundDecrease_WhenAtLeastOneArgumentIsNull_ThrowArgumentNullException(int? amount, int? rate, int? time)
        {
            Assert.That(() => calculator.CompoundDecrease(amount, rate, time),
                Throws.Exception.TypeOf<ArgumentNullException>());
        }

        [Test]
        [TestCase(100, 0, 5)]
        public void CompoundDecrease_WhenAtLeastOneArgumentIsOutOfRange_ThrowArgumentOutOfRangeException(int? amount, int? rate, int? time)
        {
            Assert.That(() => calculator.CompoundDecrease(amount, rate, time),
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }


    }
}