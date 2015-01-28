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

namespace CustomerManagement_Practice5App
{
    public partial class CustomerManagementUI : Form
    {
        public CustomerManagementUI()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=.\SQLEXPRESS; Database=CustomerDB;Integrated Security=True";

        private void enqueueButton_Click(object sender, EventArgs e)
        {
            SaveData();
            
            ShowData();
        }

        private void SaveData()
        {
            string name = enqueueNameTextBox.Text;
            string complain = enqueueComplainTextBox.Text;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO tCustomer VALUES('" + name + "','" + complain + "', 'NotServed')";
            SqlCommand command = new SqlCommand(query, connection);

            int rowAffected = command.ExecuteNonQuery();


            if (rowAffected > 0)
            {
                MessageBox.Show("Succesfully Saved Data!!!");
            }
            else
            {
                MessageBox.Show("ERROR!!! Could not save Data!!!");
            }
        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            List<Customer> customerList = new List<Customer>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string minSerialNoQuery = "SELECT MIN(serialNo) FROM tCustomer WHERE status = 'NotServed'";
            SqlCommand minSerialCommand = new SqlCommand(minSerialNoQuery, connection);

            SqlDataReader reader = minSerialCommand.ExecuteReader();

            reader.Read();

            int minSerial = Convert.ToInt32(reader[0]);

            connection.Close();
            connection.Open();

            string dequeueQuery = "SELECT * FROM tCustomer WHERE serialNo="+minSerial;
            SqlCommand dequeueCommand = new SqlCommand(dequeueQuery, connection);

            SqlDataReader reader2 = dequeueCommand.ExecuteReader();

            while (reader2.Read())
            {
                Customer aCustomer = new Customer();
                aCustomer.serial = (int)reader2["serialNo"];
                aCustomer.name = reader2["name"].ToString();
                aCustomer.complain = reader2["complain"].ToString();
                aCustomer.status = reader2["status"].ToString();

                customerList.Add(aCustomer);
            }

            

            foreach (Customer aCustomer in customerList)
            {
                serialDequeueTextBox.Text = aCustomer.serial.ToString();
                nameDequeueTextBox.Text = aCustomer.name;
                complainDequeueTextBox.Text = aCustomer.complain;
            }

            connection.Close();

            UpdateData();
            ShowData();
        }

        private void CustomerManagementUI_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            List<Customer> customerList = new List<Customer>();

            waitingQueueListView.Items.Clear();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM tCustomer WHERE status = 'NotServed'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Customer aCustomer = new Customer();
                aCustomer.serial = (int)reader["serialNo"];
                aCustomer.name = reader["name"].ToString();
                aCustomer.complain = reader["complain"].ToString();
                aCustomer.status = reader["status"].ToString();

                customerList.Add(aCustomer);

            }

            foreach (Customer aCustomer in customerList)
            {
                ListViewItem aListViewItem = new ListViewItem();
                aListViewItem.Text = aCustomer.serial.ToString();
                aListViewItem.SubItems.Add(aCustomer.name);
                aListViewItem.SubItems.Add(aCustomer.complain);
                aListViewItem.SubItems.Add(aCustomer.status);

                aListViewItem.Tag = aCustomer;

                waitingQueueListView.Items.Add(aListViewItem);
            }

            connection.Close();
        }

        public void UpdateData()
        {
            int serial = Convert.ToInt32(serialDequeueTextBox.Text);

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "UPDATE tCustomer SET status= 'OnService' WHERE serialNo = " + serial;

            SqlCommand command = new SqlCommand(query,connection);
            command.ExecuteNonQuery();


            connection.Close();
        }
    }
}
