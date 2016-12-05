using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    interface ICalculator
    {
        void sendData(string data);
        string getDisplay();
    }
}