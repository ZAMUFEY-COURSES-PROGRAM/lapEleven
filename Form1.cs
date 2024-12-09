using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lapEleven
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //BasicIf();
            //AdvancedIf();
            //IfElseIfElse();
            NestedIf();
        }

        private void BasicIf()
        {
            int num1;
            num1 = 15;

            if ( num1 == 15 ) //Inside the bracket 
            {
                label1.Text = "The Value of the Num1 is Correct";
                label1.ForeColor = Color.Green;
            }

        }

        private void AdvancedIf()
        {
            int num2;
            num2 = 200;

            if (num2 == 250) //Condition = num2 == 250
            { //Only Works on when the condition is true
                label1.Text = "The Value of the Num2 is Correct";
                label1.ForeColor = Color.Green;
            }
            else
            {//Only Works On When The Condition is False 
                label1.Text = "The Value of the Num2 is Wrong";
                label1.ForeColor = Color.Red;
            }
        }

        private void IfElseIfElse() {
            int cond1 = 104;

            if ( cond1 == 100 )
            {
                label1.Text = "If Statement is working";
                label1.ForeColor = Color.Green;
            }
            else if ( cond1 == 102)
            {
                label1.Text = "Else if Statement is working";
                label1.ForeColor = Color.Blue;
            }
            else
            {
                label1.Text = "Else Statement is working";
                label1.ForeColor = Color.Red;
            }
        }

        private void NestedIf()
        {
            int Cond = 202;

            if ( Cond == 201 )
            {
                label1.Text = "If Statement is working";
                label1.ForeColor = Color.Green;
            }
            if ( Cond != 209)
            {
                label1.Text = "Secound If Statement is working";
                label1.ForeColor = Color.Blue;
            }
            if ( Cond != 200)
            {
                //label1.Text = "Third If Statement is working";
                //label1.ForeColor = Color.Orange;
                MessageBox.Show("The Third If Statement is also working ...");
            }
        }
    }
}
