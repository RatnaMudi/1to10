using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDatabaseApp
{
    public partial class ViewUI : Form
    {
        public ViewUI()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchResultListView.Items.Clear();
            List<Student> studentList = new List<Student>();
            string inputId = searchIdTextBox.Text;
            string connectionString = @"Data Source=LICT\SQLEXPRESS; Database=UniversityDB;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM tStudent";

            if (!String.IsNullOrEmpty(inputId))
            {
                query = "SELECT * FROM tStudent WHERE Id='" + inputId + "'";
            }

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Student student = new Student();
                student.id = (int)reader["Id"];
                student.name = reader["Name"].ToString();
                student.emailAddress = reader["EmailAddress"].ToString();
                student.address = reader["Address"].ToString();
                student.phoneNumber = reader["PhoneNumber"].ToString();
                studentList.Add(student);
            }

          

            foreach (Student aStudent in studentList)
            {
                ListViewItem aListViewItem = new ListViewItem();
                aListViewItem.Text = aStudent.id.ToString();
                aListViewItem.SubItems.Add(aStudent.name);
                aListViewItem.SubItems.Add(aStudent.emailAddress);
                aListViewItem.SubItems.Add(aStudent.address);
                aListViewItem.SubItems.Add(aStudent.phoneNumber);

                aListViewItem.Tag = aStudent;

                searchResultListView.Items.Add(aListViewItem);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            searchResultListView.Items.Clear();
            List<Student> studentList = new List<Student>();
            // take input to update
            string name = nameTextBox.Text;
            string emailAddress = emailAddressTextBox.Text;
            string address = addressTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;
            int inputId = Convert.ToInt32(idTextBox.Text);

            // connection string
            string connectionString = @"Data Source=LICT\SQLEXPRESS; Database=UniversityDB;Integrated Security=True";

            // connection
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // query
            string query = "UPDATE tStudent SET Name='"+name+"', EmailAddress='"+emailAddress+"', Address='"+address+"', PhoneNumber='"+phoneNumber+"' WHERE Id="+inputId;

            // command
            SqlCommand command = new SqlCommand(query, connection);

            int rowAffected = command.ExecuteNonQuery();

            if (rowAffected > 0)
            {
                MessageBox.Show("Succesfully Updated Data!!!");
            }
            else
            {
                MessageBox.Show("ERROR!!! Could not Update Data!!!");
            }

            string query2 = "SELECT * FROM tStudent";
            SqlCommand command2 = new SqlCommand(query2, connection);
            SqlDataReader reader = command2.ExecuteReader();

            while (reader.Read())
            {
                Student student = new Student();
                student.id = (int)reader["Id"];
                student.name = reader["Name"].ToString();
                student.emailAddress = reader["EmailAddress"].ToString();
                student.address = reader["Address"].ToString();
                student.phoneNumber = reader["PhoneNumber"].ToString();
                studentList.Add(student);
            }



            foreach (Student aStudent in studentList)
            {
                ListViewItem aListViewItem = new ListViewItem();
                aListViewItem.Text = aStudent.id.ToString();
                aListViewItem.SubItems.Add(aStudent.name);
                aListViewItem.SubItems.Add(aStudent.emailAddress);
                aListViewItem.SubItems.Add(aStudent.address);
                aListViewItem.SubItems.Add(aStudent.phoneNumber);

                aListViewItem.Tag = aStudent;

                searchResultListView.Items.Add(aListViewItem);
            }

            connection.Close();
        }

        private void searchResultListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem selectedItem = searchResultListView.SelectedItems[0];
            Student selectedStudent = (Student)selectedItem.Tag;

            idTextBox.Text = selectedStudent.id.ToString();
            nameTextBox.Text = selectedStudent.name;
            emailAddressTextBox.Text = selectedStudent.emailAddress;
            addressTextBox.Text = selectedStudent.address;
            phoneNumberTextBox.Text = selectedStudent.phoneNumber;
        }

        private void ViewUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuUI aMenuUi = new MenuUI();
            aMenuUi.Show();
            Hide();
        }
    }
}
