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
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (count<3)
            {
                Student aStudent = new Student();
                aStudent.regNo = regNoTextBox.Text;
                aStudent.firstName = firstNameTextBox.Text;
                aStudent.lastName = lastNameTextBox.Text;

                aStudents.Add(aStudent);
                count++;
            }
            else
            {
                MessageBox.Show("already 3 student info has been added");
            }
            

           
        }
        
        private void showButton_Click(object sender, EventArgs e)
        {
            string display = "Reg No       Full Name \n";
            foreach (Student i in aStudents)
            {
                display = display + i.regNo + "              " + i.GetFullName() + "\n";
               
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
