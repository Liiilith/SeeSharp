using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Result
    {
        public double c;
        public int a;
        public string b;

        public Result(double p1)
        {
            c = p1;
            b = c.ToString();
        }

        public Result(int p1)
        {
            a = p1;
            b = a.ToString();
        }

        public Result(string s)
        {
            b = s;
        }
    }


    class Calcool : ICalculator

    {
        string num_display = "";
        string curr_operation = "";
        string operand = "";
        string temp_op = "";
        double aa, bb;
        int a, b;
        b_type c_type;
        Result A;
        Boolean done = false;
        ope op_Type;
        

        public string getDisplay()
        {
            return curr_operation+"|"+num_display;
        }

        public void sendData(string data)
        {
            set_TB(data);
        }

        public Result run_operation(int a, int b, ope op)
        {
            Result A;
            switch (op)
            {
                case ope.ADD:
                    A = ADD(a, b);
                    break;

                case ope.SUB:
                    A = SUB(a, b);
                    break;

                case ope.MULT:
                    A = MULT(a, b);
                    break;

                case ope.DIV:
                    A = DIV(a, b);
                    break;

                case ope.REV:
                    A = REV(a);
                    break;

                case ope.POW:
                    A = POW(a, b);
                    break;

                default:
                    A = new Result("ERROR");
                    break;
            }
            return A;
        }

        private void set_TB(string sender)
        {
            if (done == true)
            {
                num_display = "";
                curr_operation = "";
                done = false;

            }
            switch (get_type(sender))
            {
                case b_type.number:
                    num_display += sender;
                    curr_operation += sender;
                    temp_op = num_display;
                    break;
                case b_type.operation:
                    if (op_Type == ope.DIV)
                    {
                        aa = Convert.ToDouble(num_display);
                    }
                    //  a = Convert.ToDouble(num_display);
                    //Double.TryParse(num_display, out a);
                    a = Int32.Parse(num_display);
                    operand = sender;
                    op_Type = get_operation(sender);
                    curr_operation = temp_op + " " + operand + " ";
                    num_display = "";

                    break;

                case b_type.clear:
                    done = true;
                    break;

                case b_type.delete:

                    break;

                case b_type.result:

                    if (op_Type == ope.REV) b = 0;
                    else b = Int32.Parse(num_display);


                    A = run_operation(a, b, op_Type);
                       curr_operation += " =";
                       num_display = A.b;
                       done = true;
                    break;
                default:
                    break;

            }
        }

        private b_type get_type(string sender)
        {
          
            b_type type;
            switch (sender)
            {
                case "C":
                    type = b_type.clear;
                    break;
                case "Del":
                    type = b_type.delete;
                    break;
                case "ADD":
                    type = b_type.operation;
                    break;
                case "SUB":
                    type = b_type.operation;
                    break;
                case "MULT":
                    type = b_type.operation;
                    break;
                case "DIV":
                    type = b_type.operation;
                    break;
                case "REV":
                    type = b_type.operation;
                    break;
                case "1":
                    type = b_type.number;
                    break;
                case "2":
                    type = b_type.number;
                    break;
                case "3":
                    type = b_type.number;
                    break;
                case "4":
                    type = b_type.number;
                    break;
                case "5":
                    type = b_type.number;
                    break;
                case "6":
                    type = b_type.number;
                    break;
                case "7":
                    type = b_type.number;
                    break;
                case "8":
                    type = b_type.number;
                    break;
                case "9":
                    type = b_type.number;
                    break;
                case "0":
                    type = b_type.number;
                    break;

                case "RES":
                    type = b_type.result;
                    break;

                case "BRA":
                    type = b_type.brackets;
                    break;
                default:
                    type = b_type.number;
                    break;

            }

            return type;
        }

        private ope get_operation(string sender)
        {

            ope type;
            switch (sender)
            {
                case "ADD":
                    type = ope.ADD;
                    break;
                case "SUB":
                    type = ope.SUB;
                    break;
                case "MULT":
                    type = ope.MULT;
                    break;
                case "DIV":
                    type = ope.DIV;
                    break;
                case "REV":
                    type = ope.REV;
                    break;
               
                default:
                    type = ope.NULL;
                    break;

            }

            return type;
        }

        //  !===========================================================!

        public Result ADD(double a, double b)
        {
            return new Result(a + b);
        }

        public Result SUB(double a, double b)
        {
            return new Result(a - b);
        }

        public Result MULT(double a, double b)
        {
            return new Result(a * b);
        }

        public Result DIV(double a, double b)
        {
            if (b != 0) return new Result(a / b);
            else return new Result("ERROR");
        }

        public Result POW(double a, double b)
        {

            return new Result(a + b);
        }

        public Result REV(double b)
        {

            if (b != 0) return new Result(1 / b);
            else return new Result("ERROR");
        }
        //  !===========================================================!

        public Result ADD(int a, int b)
        {
            return new Result(a + b);
        }

        public Result SUB(int a, int b)
        {
            return new Result(a - b);
        }

        public Result MULT(int a, int b)
        {
            return new Result(a * b);
        }

        public Result DIV(int a, int b)
        {
            if (b != 0) return new Result(a / b);
            else return new Result("ERROR");
        }

        public Result POW(int a, int b)
        {

            return new Result(a + b);
        }

        public Result REV(int b)
        {

            if (b != 0) return new Result(1 / b);
            else return new Result("ERROR");
        }
        //  !=======================

    }
}
