using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Ex1_Question1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double answer = 0;
        string sum = "15";
        double  num1 = 0;
        double num2 = 0;
        string operand = "";
        string divide = "/";

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = Double.Parse(txtAnswer.Text);
            txtAnswer.Clear();

            if (operand == "+")
            {
                answer = num1 + num2;
            }else if(operand == "-")
            {
                answer = num1 - num2;
            }else if(operand == divide)
            {
                answer= num1 / num2;
            }else if(operand == "*")
            {
                answer = num1 * num2;   
            }
           
            txtAnswer.Text = Convert.ToString(answer);
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 1;
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 2;
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 3;
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 4;
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 5;
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 6;
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 7;
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 8;
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 9;
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 0;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operand = "+";
            num1 = Double.Parse(txtAnswer.Text);
            txtAnswer.Clear();
        }

        private void btnNum2_Click_1(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 2;
        }

        private void btnNum3_Click_1(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 3;
        }

        private void btnNum4_Click_1(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 4;
        }

        private void btnNum5_Click_1(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 5;
        }

        private void btnNum6_Click_1(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 6;
        }

        private void btnNum7_Click_1(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 7;
        }

        private void btnNum8_Click_1(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 8;
        }

        private void btnNum9_Click_1(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 9;
        }

        private void btnNum0_Click_1(object sender, EventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + 0;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operand = "-";
            num1 = Double.Parse(txtAnswer.Text);
            txtAnswer.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operand = divide;
            num1 = Double.Parse(txtAnswer.Text);
            txtAnswer.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operand = "*";
            num1 = Double.Parse(txtAnswer.Text);
            txtAnswer.Clear();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtAnswer.Clear(); 
        }
    }
}