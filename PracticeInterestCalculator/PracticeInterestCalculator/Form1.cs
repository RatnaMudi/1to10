using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeInterestCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double interestRate = 0;
            string bankName = comboBox1.Text;
            if (bankName == "BRAC")
            {
                interestRate = 6;
            }

            int timeInYear = Convert.ToInt32(textBox1.Text);
            double principalAmount = Convert.ToDouble(textBox2.Text);

            double total = ((timeInYear*interestRate)/100)*principalAmount;
        }

    }
}
