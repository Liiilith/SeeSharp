using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.KalkulatorWeqqen
{
    public class Calculator : ICalculator
    {

        [Flags]
        enum CalcState
        {
            OperationSet = 1,
            FirstOperandSet = 2,
            SecondOperandSet = 4,
            Calculated = 8,
            Cleared = 16
        }

        CalcState currentState = CalcState.Cleared;
        Calculation currentCalculation = new Calculation();
        string currentInput = "";
        string currentDisplay = "";

        /// <summary>
        /// Zwraca aktualne wyswietlnie z kalkulatora
        /// </summary>
        /// <returns></returns>
        public string getDisplay()
        {
            // tescik
            return currentDisplay;
        }

        public void sendData(char data)
        {
            string dataStr = data.ToString();

            if (dataStr == "E")
            {
                currentState = CalcState.Cleared;
                Calculation currentCalculation = new Calculation();
                currentDisplay = "0";
            }
            switch (currentState)
            {
                case CalcState.OperationSet:
                    {
                        if (isOperation(dataStr))
                        {
                            currentCalculation.operation = dataStr;

                        }
                        if (isDigit(dataStr))
                        {
                            currentInput += dataStr;
                            currentDisplay = currentInput;
                            currentState = CalcState.SecondOperandSet;
                        }
                    }
                    break;
                case CalcState.FirstOperandSet:
                    {
                        if (isOperation(dataStr)) // 4+4+
                        {
                            if (dataStr != "=")
                            {
                                float.TryParse(currentInput, out currentCalculation.firstOperand);
                                currentCalculation.operation = dataStr;
                                currentState = CalcState.OperationSet;
                                currentInput = "";
                            }
                        }
                        if (isDigit(dataStr))
                        {
                            if ((dataStr == ".") && (currentInput.IndexOf(".") != -1)) break;
                            currentInput += dataStr;
                            currentDisplay = currentInput;
                        }
                    }
                    break;
                case CalcState.SecondOperandSet:
                    {
                        if (isOperation(dataStr)) // 4+4+
                        {
                            if (currentInput != "")
                                float.TryParse(currentInput, out currentCalculation.secondOperand);
                            currentCalculation.policz();
                            currentDisplay = currentCalculation.result.ToString();
                            currentCalculation.firstOperand = currentCalculation.result;
                            currentInput = "";

                            if (dataStr != "=")  //4+5-
                            {
                                currentCalculation.operation = dataStr;
                            }
                            //currentState = CalcState.Calculated;
                        }
                        if (isDigit(dataStr)) // dodajemy koljen cyfry do drugiego operanda
                        {
                            if ((dataStr == ".") && (currentInput.IndexOf(".") != -1)) break;
                            currentInput += dataStr;
                            currentDisplay = currentInput;
                        }
                    }
                    break;
                case CalcState.Calculated:
                    break;
                case CalcState.Cleared:
                    {
                        if (isDigit(dataStr))
                        {
                            if ((dataStr == ".") && (currentInput.IndexOf(".") != -1)) break;
                            currentInput += dataStr;
                            currentDisplay = currentInput;
                            currentState = CalcState.FirstOperandSet;
                        }
                    }
                    break;
                default:
                    break;
            }

            
        }

        bool isDigit(string data)
        {
            int result;
            if (data == ".") return true;
            if (Int32.TryParse(data, out result)) return true;
            return false;
        }

        bool isOperation(string data)
        {

            if (data == "+") return true;
            if (data == "-") return true;
            if (data == "/") return true;
            if (data == "*") return true;
            if (data == "C") return true; //resetuje kalkulator
            if (data == "E") return true; //kasuje cyfrę
            if (data == "=") return true;
            return false;
        }

    }
}
