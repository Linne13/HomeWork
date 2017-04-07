using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form

    {
        
        Calculator calculator = new Calculator();
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            display.Text += btn.Text;
        }

    

       /* private void oper_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
        

            if (btn.Text == "+")
            {
                try
                {
                    calculator.firstNumber = double.Parse(display.Text);
                    display.Text = "";
                    calculator.symbol = '+';
                }

                catch (Exception)
                {

                }

            }

            if (btn.Text == "-")
            {
                try
                {
                    calculator.firstNumber = double.Parse(display.Text);
                    display.Text = "";
                    calculator.symbol = '-';
                }

                catch (Exception)
                {

                }
            }

            if (btn.Text == "*")
            {
                try
                {
                    calculator.firstNumber = double.Parse(display.Text);
                    display.Text = "";
                    calculator.symbol = '*';
                }
                catch (Exception)
                {
            

                }
            }

            if (btn.Text == "/")
            {
                try
                {
                    calculator.firstNumber = double.Parse(display.Text);
                    display.Text = "";
                    calculator.symbol = '/';
                }
                catch (Exception)
                {

                }
            }

            if (btn.Text == "^")
            {
                try
                {
                    calculator.firstNumber = double.Parse(display.Text);
                    display.Text = "";
                    calculator.symbol = '^';
                }
                catch (Exception)
                {

                }
            }
        */


       /* private bool CanPress()
        {
            if (!button11.Enabled)
                return false;

            if (!button12.Enabled)
                return false;

            if (!button13.Enabled)
                return false;

            if (!button14.Enabled)
                return false;

            if (!button19.Enabled)
                return false;

            return true;
        }

        private void FreeButtons()
        {
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button19.Enabled = true;
 
        }
        */

        private void Plus_click(object sender, EventArgs e)
        {
            
                calculator.firstNumber = double.Parse(display.Text);
                display.Text = "";
                calculator.symbol = '+';
                
        }

        private void Minus_click(object sender, EventArgs e)
        {
            calculator.firstNumber = double.Parse(display.Text);

            display.Text = "";
            calculator.symbol = '-';
        }

        private void Mult_click(object sender, EventArgs e)
        {
            calculator.firstNumber = double.Parse(display.Text);
            display.Text = "";
            calculator.symbol = '*';
        }

        private void Divide_click(object sender, EventArgs e)
        {
            calculator.firstNumber = double.Parse(display.Text);
            display.Text = "";
            calculator.symbol = '/';
        }

        private void Square_click(object sender, EventArgs e)
        {
            calculator.firstNumber = double.Parse(display.Text);
            display.Text = "";
            calculator.symbol = '^';
        }


       



            private void Equal_click(object sender, EventArgs e)
            {
           
                calculator.secondNumber = double.Parse(display.Text);
                if(calculator.symbol == '+')
                {
                    display.Text = calculator.Plus().ToString();
                }

                if(calculator.symbol == '-')
                {
                    display.Text = calculator.Minus().ToString();
                }

                if(calculator.symbol == '*')
                {
                    display.Text = calculator.Mult().ToString();
                }

                if(calculator.symbol == '/')
                {
                    display.Text = calculator.Divide().ToString();
                }

                if(calculator.symbol == '^')
                {
                    display.Text = calculator.Square().ToString();
                }
            }


       

        private void button18_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            try
            {
                display.Text = display.Text.Substring(0, display.Text.Length - 1);

            }
            catch(Exception)
            {

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if(!display.Text.Contains(','))
            {
                display.Text += ",";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
           
            if (!display.Text.Contains('-'))
            {
                display.Text = "-" + display.Text;
            }

            else
            {
                display.Text = display.Text.Replace("-", "");
            }
        
        }

    }
}
