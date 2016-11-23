using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.KalkulatorWeqqen
{
    class Calculation
    {
        public float firstOperand;
        public string operation;
        public float secondOperand;
        public float result;

        /// <summary>
        /// Liczy wynik operacji i ustawia result
        /// </summary>
        /// <returns></returns>
        public float policz()
        {
            result = 0;
            switch (operation)
            {
                case "+": result =  firstOperand + secondOperand; break;
                case "*": result = firstOperand * secondOperand; break;
                case "-": result = firstOperand - secondOperand; break;
                case "/": result = firstOperand / secondOperand; break;
                default:
                    break;
            }
            return result;

        }

    }
}
