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
    public partial class StudentEntryForm : Form
    {
        public StudentEntryForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //take user input
            string name = nameTextBox.Text;
            string emailAddress = emailAddressTextBox.Text;
            string address = addressTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;
            //connect to database
            //1. ConnectionString
            string connectionString = @"Data Source=LICT\SQLEXPRESS; Database=UniversityDB;Integrated Security=True";
            //string connectionString =
            //    @"Data Source=LICT\SQLEXPRESS;Initial Catalog=UniversityDB;Integrated Security=True";
            //2.Build a connection with ConnectionString
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            //insert data into database
            //1. Write down query
            string query = "INSERT INTO tStudent VALUES('" + name + "','" + emailAddress + "','" + address + "','" +
                           phoneNumber + "')";
            //string query = String.Format("INSERT INTO tStudent VALUES('{0}','{1}','{2}','{3}')", name, emailAddress, address, phoneNumber)
            //;
            //2. Execute query through connection
            SqlCommand command = new SqlCommand(query, connection);

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();

            if (rowAffected > 0)
            {
                MessageBox.Show("Succesfully Saved Data!!!");
            }
            else
            {
                MessageBox.Show("ERROR!!! Could not save Data!!!");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            MenuUI aMenuUi = new MenuUI();
            aMenuUi.Show();
            Hide();
        }

        private void StudentEntryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuUI aMenuUi = new MenuUI();
            aMenuUi.Show();
            Hide();
        }
    }
}
