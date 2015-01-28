using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookInfoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Hashtable bookInfo= new Hashtable();
        //private string isbn, bookDetail;
        private void addButton_Click(object sender, EventArgs e)
        {
            if (bookInfo.ContainsKey(addISBNTextBox.Text)==true)
            {
                MessageBox.Show("Dear user, this book has been added before");
            }
            else
            {
                bookInfo.Add(addISBNTextBox.Text, addBookDetailsTextBox.Text);
                MessageBox.Show("book added successfully...");
            }

        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (bookInfo.ContainsKey(searchISBNTextBox.Text))
            {
                string find1 = Convert.ToString(bookInfo[searchISBNTextBox.Text]);
                searchBookDetailsTextBox.Text = find1;
            }
            else
            {
                MessageBox.Show("no book available");
            }

           }
    }
}
