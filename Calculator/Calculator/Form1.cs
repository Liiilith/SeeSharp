using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        ICalculator specificCalculator;
        //bez Int.: SimpleCalculator simpleCalculator = new SimpleCalculator();
        //bez Int.: BrokenCalculator brokenCalculator = new BrokenCalculator();


        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            specificCalculator = new SimpleCalculator();
            specificCalculator.getDisplay();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            specificCalculator = new BrokenCalculator();
            specificCalculator.getDisplay();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }





    }
}
