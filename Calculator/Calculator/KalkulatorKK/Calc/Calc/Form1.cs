using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public enum ope
    {
        ADD,SUB,MULT,DIV,POW,REV,NULL
    };

    public enum b_type
    {
        number, operation, clear, delete, result, brackets
    };


    public partial class Form1 : Form
    {
        string num_display="";
        string curr_operation="";
        string operand = "";
        string temp_op = "";
        double aa, bb;
        int a, b;
        b_type c_type;
        Result A;
        Boolean done = false;
        ope op_Type;
        Calcool M=new Calcool() ;
        char[] delimiterChars = { '|' };
        public Form1()
        {
            InitializeComponent();
        }

        private void Cclick(object sender, EventArgs e)
        {
            M.sendData(get_Name(sender));
            string[] display = M.getDisplay().Split(delimiterChars);
            textBox1.Text = display[0];
            textBox1.Text = display[1];
        }

       

           
        private string get_Name(object sender)
        {
            Button b = sender as Button;
            return b.AccessibleName;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
