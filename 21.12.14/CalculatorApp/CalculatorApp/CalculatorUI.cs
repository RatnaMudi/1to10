using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorUI : Form
    {
        Calculator aCalculator = new Calculator();

        public CalculatorUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            aCalculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            aCalculator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = aCalculator.Add().ToString();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            aCalculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            aCalculator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = aCalculator.Subtract().ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            aCalculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            aCalculator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = aCalculator.Multiply().ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            aCalculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            aCalculator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = aCalculator.Divide().ToString();
        }


    }
}
