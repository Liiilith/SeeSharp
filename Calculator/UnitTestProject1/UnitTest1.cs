using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.KalkulatorWeqqen;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Calculator.KalkulatorWeqqen.Calculator calculator;


        [TestCategory("Non Operation Logic")]
        [TestMethod]
        public void Number()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            Assert.AreEqual("4", calculator.getDisplay());
        }

        [TestCategory("Non Operation Logic")]
        [TestMethod]
        public void NumberNumber()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            calculator.sendData('7');
            calculator.sendData('2');
            calculator.sendData('3');
            calculator.sendData('7');
            Assert.AreEqual("47237", calculator.getDisplay());
        }

        [TestCategory("Non Operation Logic")]
        [TestMethod]
        public void NumOperNum()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            calculator.sendData('+');
            calculator.sendData('3');
            Assert.AreEqual("3", calculator.getDisplay());
        }

        [TestCategory("Non Operation Logic")]
        [TestMethod]
        public void NumOperNumNum()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            calculator.sendData('+');
            calculator.sendData('3');
            calculator.sendData('3');
            Assert.AreEqual("33", calculator.getDisplay());
        }

        [TestCategory("Non Operation Logic")]
        [TestMethod]
        public void NumOperNumSameOper()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            calculator.sendData('+');
            calculator.sendData('3');
            calculator.sendData('+');
            Assert.AreEqual("7", calculator.getDisplay());
        }



        [TestCategory("Non Operation Logic")]
        [TestMethod]
        public void NumOperNumEqEqEq()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            calculator.sendData('+');
            calculator.sendData('3');
            calculator.sendData('=');
            calculator.sendData('=');
            calculator.sendData('=');
            Assert.AreEqual("13", calculator.getDisplay());
        }


        [TestCategory("Complex Operation")]
        [TestMethod]
        public void NumOperNumDiffOperEq()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            calculator.sendData('+');
            calculator.sendData('3');
            calculator.sendData('*');
            calculator.sendData('2');
            calculator.sendData('=');
            Assert.AreEqual("14", calculator.getDisplay());
        }

        [TestCategory("Basic Operation")]
        [TestMethod]
        public void NumPlusNumEq()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            calculator.sendData('+');
            calculator.sendData('1');
            calculator.sendData('=');
            Assert.AreEqual("5", calculator.getDisplay());

        }

        [TestCategory("Basic Operation")]
        [TestMethod]
        public void NumMinusNumEq()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            calculator.sendData('-');
            calculator.sendData('1');
            calculator.sendData('=');
            Assert.AreEqual("3", calculator.getDisplay());

        }

        [TestCategory("Basic Operation")]
        [TestMethod]
        public void NumTimesNumEq()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            calculator.sendData('*');
            calculator.sendData('6');
            calculator.sendData('=');
            Assert.AreEqual("24", calculator.getDisplay());

        }

        [TestCategory("Basic Operation")]
        [TestMethod]
        public void NumDivNumEq()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('6');
            calculator.sendData('/');
            calculator.sendData('2');
            calculator.sendData('=');
            Assert.AreEqual("3", calculator.getDisplay());

        }


        [TestCategory("Basic Operation with Dot")]
        [TestMethod]
        public void NumDotNum()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('6');
            calculator.sendData('.');
            calculator.sendData('3');
            calculator.sendData('=');
            Assert.AreEqual("6.3", calculator.getDisplay());

        }

        [TestCategory("Basic Operation with Dot")]
        [TestMethod]
        public void NumDotNumPlusNumEq()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('6');
            calculator.sendData('.');
            calculator.sendData('3');
            calculator.sendData('+');
            calculator.sendData('2');
            calculator.sendData('=');
            Assert.AreEqual("8.3", calculator.getDisplay());

        }
    }
}
