using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.KalkulatorPgaw
{
    public class Calculator
    {
        public string dzialanie;
        private string operand1 = "";
        private string operand2 = "";
        public bool operacja = false;
        public bool rownasie = false;
        public bool przecinek = false;
        public string wynik = "";
        private string display = "";



        public Calculator()
        {

        }

        bool isOperation(string text)
        {
            if (text == "+") return true;
            if (text == "-") return true;
            if (text == "*") return true;
            if (text == "/") return true;
            if (text == "=") return true;
            return false;
        }
        bool isNumber(string text)
        {
            int result;
            if (Int32.TryParse(text, out result)) return true;
            return false;
        }
        public string getDisplay()
        {
            return display;

        }

        public string policz()
        {
            if (operand1 == "")
            {
                return "";
            }

            switch (dzialanie)
            {
                case "+":
                    wynik = (float.Parse(operand1) + float.Parse(operand2)).ToString();
                    break;
                case "-":
                    wynik = (float.Parse(operand1) - float.Parse(operand2)).ToString();
                    break;
                case "*":
                    wynik = (float.Parse(operand1) * float.Parse(operand2)).ToString();
                    break;
                case "/":
                    wynik = (float.Parse(operand1) / float.Parse(operand2)).ToString();
                    break;
                default:
                    wynik = "";
                    break;
            }
            operacja = false;
            return wynik;

        }

        internal void dzialaj(string text)
        {

            if (text == "C")
            {
                operand1 = "";
                operand2 = "";
                dzialanie = null;
                wynik = "";
                display = wynik;
                przecinek = false;
                return;
            }

    //        if (text == "CE")
            if (text == "E")
            {
                operand2 = "0";
                display = operand1;
                //historia.Text = opera.operand1 + " " + opera.dzialanie;
                //opera.operacja = true; 
            }

   //        if (text == "Sinus")
            if (text == "S")
            {
                double kat = Math.PI * float.Parse(display) / 180.0;
                double sinus = Math.Sin(kat);
                //  historia.Text = "sinus(" + wyniktextBox.Text + "') =";
                display = sinus.ToString();
                operand1 = display;
                operand2 = "";
            }

                if (text == ",")
            //if (text == ".")
            {
                if (przecinek == true)
                {
                    return;
                }

                else if (przecinek == false && display == "0" || display == "Hello!" || display == "")
                {
                    display = "0,";
                    przecinek = true;
                }
                else if (przecinek == false && operand1 != "" && dzialanie == null)
                {
                    display = display + ",";
                    operand1 = operand1 + ",";
                    przecinek = true;
                }


                else if (przecinek == false && operand1 != "" && display != "" && dzialanie != null)
                {
                    display = display + ",";
                    operand2 = operand2 + ",";
                    przecinek = true;
                }
                else
                {
                    display = display + ",";
                    operand1 = operand1 + ",";
                    przecinek = true;
                }
            }

            //      if (text == "Backspace <-")
            if (text == "B")
            {
                if (display.Length == 0 || display.Length == 1)
                {
                    display = "";
                    text = "";
                    operand1 = "";
                    operand2 = "";
                    dzialanie = null;
                    wynik = "";

                    return;
                }
                if (display.Length != 0 && display.Length != 1 && operand1 != "")
                {
                    display = display.Remove(display.Length - 1);
                    text = text.Remove(text.Length - 1);
                    operand1 = operand1.Remove(operand1.Length - 1);
                    operand2 = "";
                    return;
                }

            }
            if (operand1 != "" && operand2 == "" && dzialanie == null && isNumber(text))
            {
                operand1 += text;
                display += text;
                return;
            }
            if (operand1 == "" && dzialanie == null && isNumber(text))
            {
                operand1 = text;
                display = text;
                return;
            }


            if (operand1 != "" && operand2 != "" && dzialanie != "" && isOperation(text))
            {
                if (text == "=")
                {
                    policz();
                    operand1 = wynik;
                    display = wynik;
                    rownasie = true;
                    return;
                }
                if (rownasie == true && wynik != "")
                {
                    dzialanie = text;
                    display = text;
                    operand1 = wynik;
                    operand2 = "";
                    rownasie = false;
                    return;
                }
                else
                {
                    policz();
                    operand1 = wynik;
                    display = wynik;
                    dzialanie = text;
                    operand2 = "";
                    return;
                }
            }
            if (operand1 == "" && isNumber(text))
            {
                operand1 = text;
                display = text;
                return;

            }
            if (operand1 != "" && operand2 == "" && isOperation(text))
            {
                dzialanie = text;
                display = text;
                przecinek = false;
                return;
            }

            if (operand1 != "" && operand2 != "" && isOperation(text))
            {
                dzialanie = text;
                display = text;
                przecinek = false;
                return;
            }
            if (operand1 != "" && operand2 != "" && dzialanie != "" && isNumber(text))
            {
                operand2 += text;
                display += text;
                return;
            }
            if (operand1 != "" && dzialanie != "" && isNumber(text))
            {
                operand2 = text;
                display = text;
                return;
            }

        }

    }
}
