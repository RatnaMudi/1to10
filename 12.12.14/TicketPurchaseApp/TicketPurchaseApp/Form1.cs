using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketPurchaseApp
{
        
    public partial class Form1 : Form
    {
        string name;
        int ticket;
        int totalPrice;
        public Form1()
        {        

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            name = customerNameTextBox.Text;
            ticket = Convert.ToInt16(noOfTicketTextBox.Text);
            totalPrice = ticket * 10;
            noOfTicketTextBox.Clear();
            customerNameTextBox.Clear();
            MessageBox.Show(name + ", please pay " + totalPrice + " taka to buy " + ticket + " ticket(s)");
            
            
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            noOfTicketTextBox.Clear();
            customerNameTextBox.Clear();
            MessageBox.Show("Customer Name : " + name + "\n" + "No Of Ticket : " + ticket + "\n"+ "Total Price : " + totalPrice);
            
        }

    

        
    }
}
