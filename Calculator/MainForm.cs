/*
 * Program: Calculator (v1.0)
 * Description: Simple calculator that performs basic algebraic operations 
 * Programmer: Oleksii Butakov    
 * Last Modified: 7/19/2017 
 * 
 */


using System;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    { 
        StringBuilder str = new StringBuilder(); // performs much like running total 
        decimal num1; // 1st operand 
        decimal num2; // 2nd operand
        decimal answer;
        char action; // action token 

        public Calculator()
        {
            InitializeComponent();
        }

        private void updateOutputText()
        {
            txtOutput.Text = str.ToString();
        }

        // Saves first operand and clears the StringBuilder
        private void saveNum1()
        {
            if (str.Length > 0)
            {
                num1 = Convert.ToDecimal(str.ToString());
                txtOutput.AppendText("\r\n");
                str.Clear();
            }
            else
            {
                txtOutput.AppendText("\r\nError: enter the value");
            }

            Console.WriteLine(num1);
        }

        // Saves second operand and clears the StringBuilder
        private void saveNum2()
        {
            if (str.Length > 0)
            {
                num2 = Convert.ToDecimal(str.ToString());
                txtOutput.AppendText("\r\n");
                str.Clear();
            }
            else
            {
                txtOutput.AppendText("\r\nError: enter the value");
            }

            Console.WriteLine(num2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            str.Append(1);
            updateOutputText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            str.Append(2);
            updateOutputText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            str.Append(3);
            updateOutputText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            str.Append(4);
            updateOutputText();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            str.Append(5);
            updateOutputText();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            str.Append(6);
            updateOutputText();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            str.Append(7);
            updateOutputText();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            str.Append(8);
            updateOutputText();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            str.Append(9);
            updateOutputText();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            str.Append(0);
            updateOutputText();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            saveNum1();
            action = '+';
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            saveNum1();
            action = '-';
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            saveNum1();
            action = '*';
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
           
            saveNum1();
            action = '/';
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            saveNum1();
            action = '%';
        }

        private void btnSignChange_Click(object sender, EventArgs e)
        {
            char temp = '-';
            string strTemp = str.ToString();

            str.Clear();
            str.Append(temp);
            str.Append(strTemp);

            updateOutputText();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            str.Clear();
        }
        
        private void btnEqual_Click(object sender, EventArgs e)
        {
            saveNum2();

            switch(action)
            {
                case '+':
                    answer = num1 + num2;
                    str.Append(answer);
                    txtOutput.Text = (answer).ToString();
                    break;
                case '-':
                    answer = num1 - num2;
                    str.Append(answer);
                    txtOutput.Text = (answer).ToString();
                    break;
                case '/':
                    answer = num1 / num2;
                    str.Append(answer);
                    txtOutput.Text = (answer).ToString();
                    break;
                case '%':
                    answer = num1 % num2;
                    str.Append(answer);
                    txtOutput.Text = (answer).ToString();
                    break;
                case '*':
                    answer = num1 * num2;
                    str.Append(answer);
                    txtOutput.Text = (answer).ToString();
                    break;
                default:
                    break;
            }
        }


        private void btnDot_Click(object sender, EventArgs e)
        {
            str.Append(".");
        }
    }
}
