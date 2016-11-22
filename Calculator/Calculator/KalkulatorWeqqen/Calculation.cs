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
