using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoPractice2App
{
    public partial class Form1 : Form
    {
        List<Student> aStudents = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent= new Student();
            aStudent.regNo = regNoTextBox.Text;
            aStudent.firstName = firstNameTextBox.Text;
            aStudent.lastName = lastNameTextBox.Text;

            aStudents.Add(aStudent);
        }
        
        private void showButton_Click(object sender, EventArgs e)
        {
            string display = " ";
            foreach (Student i in aStudents)
            {
                display += i.GetFullName() +"'s registration no is "+ i.regNo+" " +"\n";
               
            }
            MessageBox.Show(display);
            regNoTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            aStudents.Clear();
        }
    }
}
