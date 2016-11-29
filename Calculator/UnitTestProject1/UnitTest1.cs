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

        [TestMethod]
        public void DotStart()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData(',');
            Assert.AreEqual("0,", calculator.getDisplay());
        }

        [TestMethod]
        public void DotInside()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            calculator.sendData(',');
            calculator.sendData('3');
            Assert.AreEqual("4,3", calculator.getDisplay());
        }

        [TestMethod]
        public void DotDouble()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            calculator.sendData(',');
            calculator.sendData(',');
            calculator.sendData('3');
            Assert.AreEqual("4,3", calculator.getDisplay());
        }

        [TestMethod]
        public void DotDoubleEnd()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            calculator.sendData(',');
            calculator.sendData('3');
            calculator.sendData(',');
            Assert.AreEqual("4,3", calculator.getDisplay());
        }


        [TestMethod]
        public void DotInsideOper()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            calculator.sendData(',');
            calculator.sendData('3');
            calculator.sendData('+');
            calculator.sendData(',');
            calculator.sendData('1');
            Assert.AreEqual("0,1", calculator.getDisplay());
        }


        [TestMethod]
        public void DotInsideOperEq()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            calculator.sendData(',');
            calculator.sendData('3');
            calculator.sendData('+');
            calculator.sendData('2');
            calculator.sendData(',');
            calculator.sendData('1');
            calculator.sendData('=');
            Assert.AreEqual("6,4", calculator.getDisplay());
        }


        [TestMethod]
        public void ClearC()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            calculator.sendData('C');
            Assert.AreEqual("0", calculator.getDisplay());
        }

        [TestMethod]
        public void ClearCafterOP()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            calculator.sendData('+');
            calculator.sendData('2');
            calculator.sendData('C');
            Assert.AreEqual("0", calculator.getDisplay());
        }

        [TestMethod]
        public void ClearCafterOPEq()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            calculator.sendData('+');
            calculator.sendData('2');
            calculator.sendData('=');
            calculator.sendData('C');
            Assert.AreEqual("0", calculator.getDisplay());
        }
        [TestMethod]
        public void ClearCafterOperDot()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            calculator.sendData(',');
            calculator.sendData('3');
            calculator.sendData('+');
            calculator.sendData(',');
            calculator.sendData('1');
            calculator.sendData('C');
            Assert.AreEqual("0", calculator.getDisplay());
        }

        [TestMethod]
        public void ClearBackspace()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            calculator.sendData('3');
            calculator.sendData('1');
            calculator.sendData('B');
            Assert.AreEqual("43", calculator.getDisplay());
        }

        [TestMethod]
        public void ClearBackspaceDouble()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            calculator.sendData('3');
            calculator.sendData('1');
            calculator.sendData('B');
            calculator.sendData('B');
            Assert.AreEqual("4", calculator.getDisplay());
        }

        [TestMethod]
        public void ClearCE()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            calculator.sendData('E');                          //jaki Char?             
            Assert.AreEqual("0", calculator.getDisplay());
        }

        [TestMethod]
        public void ClearCEOper()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('4');
            calculator.sendData('+');
            calculator.sendData('2');
            calculator.sendData('E');
            calculator.sendData('+');
            calculator.sendData('5');
            calculator.sendData('=');
            Assert.AreEqual("9", calculator.getDisplay());
        }
        [TestMethod]
        public void Sinus()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('9');
            calculator.sendData('0');
            calculator.sendData('S');
            Assert.AreEqual("1", calculator.getDisplay());
        }

        [TestMethod]
        public void SinusafterOper()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('8');
            calculator.sendData('6');
            calculator.sendData('+');
            calculator.sendData('4');
            calculator.sendData('=');
            calculator.sendData('S');
            Assert.AreEqual("1", calculator.getDisplay());
        }

        [TestMethod]
        public void OperafterSinus()
        {
            calculator = new Calculator.KalkulatorWeqqen.Calculator();
            calculator.sendData('9');
            calculator.sendData('0');
            calculator.sendData('S');
            calculator.sendData('+');
            calculator.sendData('4');
            calculator.sendData('=');
            Assert.AreEqual("5", calculator.getDisplay());

        }
    }
}
