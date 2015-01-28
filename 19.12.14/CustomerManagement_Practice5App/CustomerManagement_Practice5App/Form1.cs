using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerManagement_Practice5App
{
    public partial class Form1 : Form
    {
        private int slNo = 0;
        Queue<Customer> customerStack= new Queue<Customer>();
 
        public Form1()
        {
            InitializeComponent();
        }

        private int serial = 0;
        private void enqueueButton_Click(object sender, EventArgs e)
        {
            serial++;
            Customer cusEnqueue= new Customer();
            cusEnqueue.name = enqueueNameTextBox.Text;
            cusEnqueue.complain = enqueueComplainTextBox.Text;
            
            ListViewItem aListView= new ListViewItem();
            aListView.Text = serial.ToString();
            aListView.SubItems.Add(cusEnqueue.name);
            aListView.SubItems.Add(cusEnqueue.complain);
            waitingQueueListView.Items.Add(aListView);
            MessageBox.Show(cusEnqueue.name+"'s serial no is: "+ serial);
        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            ListViewItem list=new ListViewItem();
            list = waitingQueueListView.TopItem;
            serialDequeueTextBox.Text = list.Text;
            nameDequeueTextBox.Text = list.SubItems[1].Text;
            complainDequeueTextBox.Text = list.SubItems[2].Text;
            waitingQueueListView.Items.Remove(list);
        }
    }
}
