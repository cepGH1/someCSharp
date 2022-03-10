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
        Calculator myCalculator;
        string numShowing = "";
        double myInput1 = 0.0D;
        string myOperation = "";
        double myRunningTotal = 0.0D;
        int myOperationCount = 0;

        public Form1()
        {
            InitializeComponent();
            CEPclass2 clare = new CEPclass2("clare", 30, "red");
            myCalculator = new Calculator();
        } 

        private void useOperator( double myInput)
        {
           
        }
        private void button4_Click(object sender, EventArgs e)
        {
            double myInput2 = Convert.ToDouble(textBox1.Text);
            if (myOperationCount != 0)
            {
                myRunningTotal = myRunningTotal / myInput2;
                myOperationCount++;
            }
            else
            {
                myRunningTotal = myInput2;
                myOperationCount++;
            }

            numShowing = "";

            myOperation = "divide";
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
             double myInput2 = Convert.ToDouble(textBox1.Text);
            if(myOperationCount != 0)
            {
                myRunningTotal = myRunningTotal * myInput2;
                myOperationCount++;
            }
            else
            {
                myRunningTotal = myInput2;
                myOperationCount++;
            }

            numShowing = "";
            
            myOperation = "mult";

            
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
           double myInput2 = Convert.ToDouble(textBox1.Text);
            if (myOperationCount == 0)
            {
                myRunningTotal = myInput2;

            }
            else
            {
                myRunningTotal = myRunningTotal - myInput2;
            }
            myOperation = "minus";
            numShowing = "";
            myOperationCount++;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double myInput2 = Convert.ToDouble(textBox1.Text);
            if (myOperationCount == 0)
            {
                myRunningTotal = myInput2;

            }
            else
            {
                myRunningTotal = myRunningTotal + myInput2;
            }
            
            myOperation = "add";
            numShowing = ""; 
            myOperationCount++;

        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double myLastInput = Convert.ToDouble(textBox1.Text);

                if (myOperation == "mult")
                {
                    myRunningTotal = myRunningTotal * myLastInput;
                }
                if (myOperation == "add")
                {
                    myRunningTotal = myRunningTotal + myLastInput;
                }
                if (myOperation == "minus")
                {
                    myRunningTotal = myRunningTotal - myLastInput;
                }
                if (myOperation == "divide")
                {
                    myRunningTotal = myRunningTotal / myLastInput;
                }


                numShowing = Convert.ToString(myRunningTotal);
                textBox1.Text = numShowing;
                myOperationCount = 0;
            }
            else
            {
                textBox1.Text = "";
            }


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            numShowing = "";
            myInput1 = 0;
            myOperationCount = 0;
            myRunningTotal = 0;
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
            myRunningTotal = Convert.ToDouble(numShowing);
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            numShowing = numShowing + "0";
            textBox1.Text = numShowing;
        }
    }
}
