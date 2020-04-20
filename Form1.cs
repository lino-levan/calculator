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
    public partial class Calculator : Form
    {
        public static String number1 = "";
        public static String number2 = "";
        public static String operation = "";
        public Calculator()
        {
            InitializeComponent();
        }

        private void handleNumberClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            setNum(clickedButton.Text);
        }
        
        private void handleOperator(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            operation = clickedButton.Text;
            update();
        }

        private void compute(object sender, EventArgs e)
        {
            if(operation == "+")
            {
                number1 = (Convert.ToInt32(number1) + Convert.ToInt32(number2)).ToString();
                number2 = "";
                operation = "";
            }
            if (operation == "-")
            {
                number1 = (Convert.ToInt32(number1) - Convert.ToInt32(number2)).ToString();
                number2 = "";
                operation = "";
            }
            if (operation == "x")
            {
                number1 = (Convert.ToInt32(number1) * Convert.ToInt32(number2)).ToString();
                number2 = "";
                operation = "";
            }
            if (operation == "÷")
            {
                number1 = (Convert.ToInt32(number1)/Convert.ToInt32(number2)).ToString();
                number2 = "";
                operation = "";
            }
            update();
        }

        public void setNum(String input)
        {
            if (operation == "")
            {
                number1 += input;
            } else {
                number2 += input;
            }
            update();
        }

        public void update()
        {
            calculation.Text = number1 + operation + number2;
            if (calculation.Text == "")
            {
                calculation.Text = "0";
            }
        }

        private void clear(object sender, EventArgs e)
        {
            number1 = "";
            number2 = "";
            operation = "";
            update();
        }

        private void delete(object sender, EventArgs e)
        {
            if (number2.Length > 0)
            {
                number2 = number2.Remove(number2.Length - 1, 1);
            }
            else if(operation != "")
            {
                operation = "";
            }else if(number1.Length > 0)
            {
                number1 = number1.Remove(number1.Length - 1, 1);
            }
            update();
        }
    }
}
