using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.KalkulatorWeqqen;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Calculator.KalkulatorWeqqen.Calculator calculator;



        [TestMethod]
        public void Number()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            Assert.AreEqual("4", calculator.getDisplay());
        }

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

        [TestMethod]
        public void NumOperNum()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            calculator.sendData('+');
            calculator.sendData('3');
            Assert.AreEqual("3", calculator.getDisplay());
        }


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

        [TestMethod]
        public void NumOperNumEq()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            calculator.sendData('+');
            calculator.sendData('3');
            calculator.sendData('=');
            Assert.AreEqual("7", calculator.getDisplay());
        }

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


        [TestMethod]
        public void NumOperNumEqEq()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            calculator.sendData('+');
            calculator.sendData('3');
            calculator.sendData('=');
            calculator.sendData('=');
            Assert.AreEqual("10", calculator.getDisplay());
        }

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

    }
}
