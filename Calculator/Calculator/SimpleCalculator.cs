using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class SimpleCalculator : ICalculator
    {
        public string getDisplay()
        {
            return "Niezepsuty, ale jednak nic nie liczy";
        }

        public void sendData(char data)
        {
            throw new NotImplementedException();
        }
    }
}
