using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class BrokenCalculator : ICalculator
    {
        public string getDisplay()
        {
            return "Nie nie dziala";
        }

        public void sendData(char data)
        {
            throw new NotImplementedException();
        }
    }
}
