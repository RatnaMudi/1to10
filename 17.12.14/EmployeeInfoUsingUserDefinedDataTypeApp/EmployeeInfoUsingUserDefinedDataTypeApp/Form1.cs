using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInfoUsingUserDefinedDataTypeApp
{
    public partial class Form1 : Form
    {
        Employee anEmployee= new Employee();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            anEmployee.id = idTextBox.Text;
            anEmployee.name = nameTextBox.Text;
            anEmployee.salary = Convert.ToDouble(salaryTextBox.Text);
            idTextBox.Clear();
            nameTextBox.Clear();
            salaryTextBox.Clear();
            MessageBox.Show("Id : "+ anEmployee.id + "\n" + "Name :" + anEmployee.name + "\n" + "Salary : "+ anEmployee.salary);
            
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = anEmployee.id;
            nameTextBox.Text = anEmployee.name;
            salaryTextBox.Text = Convert.ToString(anEmployee.salary);
        }
    }
}
