using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UITest_Calculator
{
    public class TestClass

    {
        MainScreenModel _msModel;
        [SetUp]
        public void StartAppBeforeEachTest()
        {
            AppInitializer.StartApp();
        }

        //EnterData Tests
        [Test]

        public void EnterData()
        {
            _msModel.TapOnOne()
                .TapOnTwo()
                .TapOnThree()
                .TapOnFour()
                .TapOnFive()
                .TapOnSix()
                .TapOnSeven()
                .TapOnEight()
                .TapOnNine()
                .TapOnZero()
                .TapOnComma();
            Assert.AreEqual("1234567890,", _msModel.GetTextFromTextField());
        }
        [Test]
        public void StartTypeWithComma()
        {
            _msModel.TapOnComma()
                .TapOnOne();
            Assert.AreEqual("0,1", _msModel.GetTextFromTextField());

        }
        [Test]
        public void EnterCommaAfterSymbols()
        {
            _msModel.TapOnOne()
                .TapOnComma()
                .TapOnOne();
            Assert.AreEqual("1,1", _msModel.GetTextFromTextField());
        }
        [Test]
        public void DeleteNumbersFromEmptyField()
        {
            _msModel.TapOnAC();
            Assert.AreEqual("0", _msModel.GetTextFromTextField());
        }
        [Test]
        public void DeleteSymbols()
        {
            _msModel.TapOnOne()
               .TapOnComma()
               .TapOnOne()
               .TapOnAC();
            Assert.AreEqual("0", _msModel.GetTextFromTextField());

        }
        //Sum Tests
        [Test]
        public void MyFirstMobileTest()
        {
            _msModel.TapOnOne()
                .TapOnPlus()
                .TapOnOne()
                .TapOnEqual();
            Assert.AreEqual("2", _msModel.GetTextFromTextField());

        }
        [Test]
        public void SumTwoFractNumbers()
        {
            _msModel.TapOnOne()
              .TapOnComma()
              .TapOnOne()
              .TapOnPlus()
             .TapOnOne()
              .TapOnComma()
              .TapOnOne()
              .TapOnEqual();
            Assert.AreEqual("2,2", _msModel.GetTextFromTextField());
        }
        [Test]
        public void SumThreeWholeNumbers()
        {
            _msModel.TapOnOne()

              .TapOnPlus()
             .TapOnOne()

              .TapOnPlus()
             .TapOnOne()

              .TapOnEqual();
            Assert.AreEqual("3", _msModel.GetTextFromTextField());
        }
        [Test]
        public void SumThreeFractNumbers()
        {
            _msModel.TapOnOne()
              .TapOnComma()
              .TapOnOne()
              .TapOnPlus()
             .TapOnOne()
              .TapOnComma()
              .TapOnOne()
              .TapOnPlus()
             .TapOnOne()
              .TapOnComma()
              .TapOnOne()
              .TapOnEqual();
            Assert.AreEqual("3,3", _msModel.GetTextFromTextField());
        }
        //Substraction Tests
        [Test]
        public void SubTwoWholeNumbers()
        {
            _msModel.TapOnTwo()
             .TapOnMinus()
             .TapOnOne()

              .TapOnEqual();
            Assert.AreEqual("1", _msModel.GetTextFromTextField());
        }
        [Test]
        public void SubTwoFractNumbers()
        {
            _msModel.TapOnOne()
              .TapOnComma()
              .TapOnOne()
              .TapOnMinus()
             .TapOnOne()
              .TapOnComma()
              .TapOnOne()
              .TapOnEqual();
            Assert.AreEqual("0", _msModel.GetTextFromTextField());
        }
        [Test]
        public void SubThreeWholeNumbers()
        {
            _msModel.TapOnOne()
              .TapOnMinus()
             .TapOnOne()
              .TapOnMinus()
             .TapOnOne()
              .TapOnEqual();
            Assert.AreEqual("-1", _msModel.GetTextFromTextField());
        }
        [Test]
        public void SubThreeFractNumbers()
        {
            _msModel.TapOnOne()
              .TapOnComma()
              .TapOnOne()
              .TapOnMinus()
             .TapOnZero()
              .TapOnComma()
              .TapOnOne()
           .TapOnMinus()
             .TapOnZero()
              .TapOnComma()
              .TapOnFive()
              .TapOnEqual();
            Assert.AreEqual("0,5", _msModel.GetTextFromTextField());
        }
        //Action after equal and equal twice
        [Test]
        public void TapEqualTwice()
        {
            _msModel.TapOnOne()
                .TapOnPlus()
                .TapOnOne()
                .TapOnEqual()
                .TapOnEqual();
            Assert.AreEqual("3", _msModel.GetTextFromTextField());
        }
        [Test]
        public void ActionAfterEqual()
        {
            _msModel.TapOnOne()
                .TapOnPlus()
                .TapOnOne()
                .TapOnEqual()
                .TapOnPlus()
                .TapOnOne()
                .TapOnEqual();
            Assert.AreEqual("3", _msModel.GetTextFromTextField());

        }
        //Multiplication 

        [Test]
        public void MultiplicationTwoWholeNumbers()
        {
            _msModel.TapOnOne()
                .TapOnMultiply()
                .TapOnTwo()
                .TapOnEqual();
            Assert.AreEqual("2", _msModel.GetTextFromTextField());

        }
        [Test]
        public void MultiplicationTwoFractNumbers()
        {
            _msModel.TapOnOne()
              .TapOnComma()
              .TapOnOne()
              .TapOnMultiply()
             .TapOnOne()
              .TapOnComma()
              .TapOnOne()
              .TapOnEqual();
            Assert.AreEqual("1,21", _msModel.GetTextFromTextField());
        }
        [Test]
        public void MultiplicationThreeWholeNumbers()
        {
            _msModel.TapOnOne()
             .TapOnMultiply()
             .TapOnTwo()
            .TapOnMultiply()
             .TapOnThree()
              .TapOnEqual();
            Assert.AreEqual("6", _msModel.GetTextFromTextField());
        }
        [Test]
        public void MultiplicationThreeFractNumbers()
        {
            _msModel.TapOnOne()
              .TapOnComma()
              .TapOnOne()
              .TapOnMultiply()
             .TapOnOne()
              .TapOnComma()
              .TapOnOne()
              .TapOnMultiply()
             .TapOnOne()
              .TapOnComma()
              .TapOnOne()
              .TapOnEqual();
            Assert.AreEqual("1,331", _msModel.GetTextFromTextField());
        }
        //Division
        [Test]
        public void DivisionTwoWholeNumbers()
        {
            _msModel.TapOnOne()
                .TapOnDiv()
                .TapOnTwo()
                .TapOnEqual();
            Assert.AreEqual("0,5", _msModel.GetTextFromTextField());

        }
        [Test]
        public void DivisionTwoFractNumbers()
        {
            _msModel.TapOnTwo()
              .TapOnComma()
              .TapOnTwo()
               .TapOnDiv()
             .TapOnOne()
              .TapOnComma()
              .TapOnOne()
              .TapOnEqual();
            Assert.AreEqual("2", _msModel.GetTextFromTextField());
        }
        [Test]
        public void DivisionThreeWholeNumbers()
        {
            _msModel.TapOnNine()
            .TapOnDiv()
             .TapOnThree()
            .TapOnDiv()
             .TapOnOne()
              .TapOnEqual();
            Assert.AreEqual("3", _msModel.GetTextFromTextField());
        }
        [Test]
        public void DivisionThreeFractNumbers()
        {
            _msModel.TapOnOne()
              .TapOnComma()
              .TapOnOne()
                  .TapOnDiv()
             .TapOnOne()
              .TapOnComma()
              .TapOnOne()
                  .TapOnDiv()
             .TapOnOne()
              .TapOnComma()
              .TapOnOne()
              .TapOnEqual();
            Assert.AreEqual("0,90909091", _msModel.GetTextFromTextField());
        }


    }
}
