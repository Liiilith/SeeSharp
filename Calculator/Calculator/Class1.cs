using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    abstract class Class1
    {

        int liczbaSloikow;
        private int iloscZwrocen;
        private int myVar;

        public int MyProperty
        {
            get {
                iloscZwrocen++;
                return myVar;
            }
            set {
                if (value < 3)
                {
                    myVar = 0;
                }
                Console.WriteLine(value);
                myVar = value;

            }
        }


        protected abstract int policz();


    }
}
