using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalaculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double number1, number2, result;
        char operation;

        private void startCalculate(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(labelCalculate.Text);
            if (operation == '+')
            {
                result = number2 + number1;
                labelResult.Text = result.ToString();
                labelCalculate.Text = result.ToString();

            }else if (operation == '-')
            {
                result = number2 - number1;
                labelResult.Text = result.ToString();
                labelCalculate.Text = result.ToString();

            }
            else if (operation == '*')
            {
                result = number2 * number1;
                labelResult.Text = result.ToString();
                labelCalculate.Text = result.ToString();

            }
            else
            {
                result = number2 / number1;
                labelResult.Text = result.ToString();
                labelCalculate.Text = result.ToString();

            }
        }

        private void ButtonZero_Click(object sender, EventArgs e)
        {
            labelCalculate.Text = "0";
            labelResult.Text = "0";
            MessageBox.Show("تم تصفير الآلة الحاسبة");
        }

        private void OnClickNumber(object sender, EventArgs e)
        {
            Button buttonClicked = (Button)sender;
            if (labelCalculate.Text == "0")
            {
                labelCalculate.Text = "";
                labelResult.Text = "";
                labelCalculate.Text += buttonClicked.Text;
                labelResult.Text += buttonClicked.Text;
            }
            else
            {
                labelCalculate.Text += buttonClicked.Text;
                labelResult.Text += buttonClicked.Text;
            }
        }


        private void OnClickOperation(object sender, EventArgs e)
        {

            string[] ops = { "+", "-", "*", "/" };

            Button buttonClicked = (Button)sender;
            if (labelResult.Text.Contains("+")|| labelResult.Text.Contains("-")|| labelResult.Text.Contains("*") || labelResult.Text.Contains("/"))
            {
                MessageBox.Show("اكمل العملية السابقة");
            }
            else
            {
                operation = Convert.ToChar(buttonClicked.Text);
                number1 = Convert.ToDouble(labelCalculate.Text); ;
                labelCalculate.Text = "";
                labelResult.Text += buttonClicked.Text;
            }
        }





    }
}
