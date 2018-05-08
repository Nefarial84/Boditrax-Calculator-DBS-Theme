using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_DBS_Theme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Variables - For Global Scope
        double total1 = 0;
        double total2 = 0;

        bool btnPlus_Clicked = false;
        bool btnMinus_Clicked = false;
        bool btnMultiply_Clicked = false;
        bool btnDivision_Clicked = false;


        //*******************************************************
        //  Numerical Butttons
        //*******************************************************

        //Button 1
        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn1.Text;
        }
        //Button 2
        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn2.Text;
        }
        //Button 3
        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn3.Text;
        }
        //Button 4
        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn4.Text;
        }
        //Button 5
        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn5.Text;
        }
        //Button 6
        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn6.Text;
        }
        //Button 7
        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn7.Text;
        }
        //Button 8
        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn8.Text;
        }
        //Button 9
        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn9.Text;
        }
        //Button 0
        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn0.Text;
        }
        //Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        //Button Point
        private void btnPoint_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnPoint.Text;
        }
        //*******************************************************
        //  Addition - Subtraction - Multiplication - Devision
        //*******************************************************
        //Plus Button
        private void btnPlus_Click(object sender, EventArgs e)
        {
           btnPlus_Clicked = true;
           btnMinus_Clicked = false;
           btnMultiply_Clicked = false;
           btnDivision_Clicked = false;

            total1 = total1 + double.Parse(textBox1.Text);
            textBox1.Clear(); 
        }
        //Minus Button
        private void btnMinus_Click(object sender, EventArgs e)
        {
            btnPlus_Clicked = false;
            btnMinus_Clicked = true;
            btnMultiply_Clicked = false;
            btnDivision_Clicked = false;

            total1 = total1 + double.Parse(textBox1.Text);
            textBox1.Clear();
        }
        //Multiplication Button
        private void btnMultiply_Click(object sender, EventArgs e)
        {

            btnPlus_Clicked = false;
            btnMinus_Clicked = false;
            btnMultiply_Clicked = true;
            btnDivision_Clicked = false;

            total1 = total1 + double.Parse(textBox1.Text);
            textBox1.Clear();
        }
        //Devision
        private void btnDivide_Click(object sender, EventArgs e)
        {

            btnPlus_Clicked = false;
            btnMinus_Clicked = false;
            btnMultiply_Clicked = false;
            btnDivision_Clicked = true;

            total1 = total1 + double.Parse(textBox1.Text);
            textBox1.Clear();
        }
        //*******************************************************
        //                  Equals Logic
        //*******************************************************
        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (btnPlus_Clicked == true) total2 = total1 + double.Parse(textBox1.Text);
            if (btnMinus_Clicked == true) total2 = total1 - double.Parse(textBox1.Text);
            if (btnMultiply_Clicked == true) total2 = total1 * double.Parse(textBox1.Text);
            if (btnDivision_Clicked == true) total2 = total1 / double.Parse(textBox1.Text);

            textBox1.Text = total2.ToString();
            total1 = 0;
        }
        //*******************************************************


    }
}
