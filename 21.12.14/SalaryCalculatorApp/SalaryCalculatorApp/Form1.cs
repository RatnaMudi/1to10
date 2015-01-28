using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Employee anEmployee= new Employee();

            anEmployee.name = enterEmployeeNameTextBox.Text;
            anEmployee.salary = Convert.ToDouble(enterBasicSalaryTextBox.Text);
            anEmployee.houseRent = Convert.ToDouble(enterHouseRentTextBox.Text);
            anEmployee.medical = Convert.ToDouble(enterMedicalAllowanceTextBox.Text);

            double totalSalary = anEmployee.Get_Salary();

            MessageBox.Show(anEmployee.name+", your salary is: "+ totalSalary);
            enterBasicSalaryTextBox.Clear();
            enterBasicSalaryTextBox.Clear();
            enterHouseRentTextBox.Clear();
            enterMedicalAllowanceTextBox.Clear();
        }
    }
}
