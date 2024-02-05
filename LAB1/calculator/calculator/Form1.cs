using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty; //to read the input when clicked 
        string Op1 = string.Empty; //First operand 
        string Op2 = string.Empty; //Second operand 
        char Operator; //Operator 
        double res = 0.0; //Final result
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Op2 = input; 
            double num1, num2; 
            double.TryParse(Op1, out num1); 
            double.TryParse(Op2, out num2); 
            if (Operator == '+') 
            { 
            res = Math.Pow(num1,0.5); 
            this.textBox1.Text = res.ToString(); 
            } 
            else if (Operator == '-') 
            { 
            res = Math.Pow(num1,2); 
            textBox1.Text = res.ToString(); 
            } 
            else if (Operator == '*') 
            { 
            res = Math.Sin(num1); 
            textBox1.Text = res.ToString(); 
            }
            else if (Operator == '/') 
            { 
            if (num2 != 0) 
            { 
            res = Math.Cos(num1); 
            textBox1.Text = res.ToString(); 
            } 
            else 
            { 
            textBox1.Text = "DIV/Zero!"; 
            } 
            } 
            input = string.Empty;

            if (Operator == '1')
            {
                res = Math.Pow(num1, 0.5);
                this.textBox1.Text = res.ToString();
            }
            else if (Operator == '2')
            {
                res = Math.Pow(num1, 2);
                textBox1.Text = res.ToString();
            }
            else if (Operator == '3')
            {
                res = Math.Sin(num1);
                textBox1.Text = res.ToString();
            }
            else if (Operator == '4')
            {
                if (num2 != 0)
                {
                    res = Math.Cos(num1);
                    textBox1.Text = res.ToString();
                }
                else
                {
                    textBox1.Text = "DIV/Zero!";
                }
            }
            input = string.Empty;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Op1 = input; 
            Operator = '+'; 
            input = string.Empty;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '-';
            input = string.Empty;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '/';
            input = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "1";
            this.textBox1.Text += input;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Answer_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "2";
            this.textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "3";
            this.textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "4";
            this.textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "5";
            this.textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "6";
            this.textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "7";
            this.textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "8";
            this.textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "9";
            this.textBox1.Text += input;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '*';
            input = string.Empty;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "9";
            this.textBox1.Text += input;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '2';
            input = string.Empty;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '1';
            input = string.Empty;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '3';
            input = string.Empty;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '4';
            input = string.Empty;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {

        }
    }
}
