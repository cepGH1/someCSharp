using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEPWindowsFormApp1
{
    public partial class Form1 : Form
    {
        string numShowing = "";
        double myInput1 = 0.0D;
        string myOperation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            numShowing = numShowing + "7";
            textBox1.Text = numShowing;


        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "";
            numShowing = numShowing + "8";
            textBox1.Text = numShowing;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            numShowing = numShowing + "9";
            textBox1.Text = numShowing;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            numShowing = numShowing + "6";
            textBox1.Text = numShowing;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            myInput1 = Convert.ToDouble(textBox1.Text);
            myOperation = "mult";
            numShowing = "";

            
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            numShowing = numShowing + "5";
            textBox1.Text = numShowing;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            numShowing = numShowing + "4";
            textBox1.Text = numShowing;
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            numShowing = numShowing + "1";
            textBox1.Text = numShowing;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            numShowing = numShowing + "2";
            textBox1.Text = numShowing;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            numShowing = numShowing + "3";
            textBox1.Text = numShowing;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            myInput1 = Convert.ToDouble(textBox1.Text);
            myOperation = "minus";
            numShowing = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            myInput1 = Convert.ToDouble(textBox1.Text);
            myOperation = "add";
            numShowing = "";
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            if(myOperation == "mult")
            {
                myInput1 = myInput1 * Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(myInput1);
            }
            if(myOperation == "add")
            {
                myInput1 = myInput1 + Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(myInput1);
            }
            if (myOperation == "minus")
            {
                myInput1 = myInput1 - Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(myInput1);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1 = null;
            numShowing = "";
            myInput1 = 0;
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            numShowing = numShowing + ".";
            textBox1.Text = numShowing;
        }

        private void changeSignButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if(numShowing[0] == '-')
            {
                numShowing = numShowing.Substring(1);
            }
            else
            {
                numShowing = '-' + numShowing;
            }
            textBox1.Text = numShowing;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            numShowing = numShowing + "0";
            textBox1.Text = numShowing;
        }
    }
}
