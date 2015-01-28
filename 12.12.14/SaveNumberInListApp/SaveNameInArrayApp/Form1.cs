using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveNumberInListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        //string[] name = new string[10];
        ArrayList myList= new ArrayList();
        private int highestValue = 5, i = 0, total=0;
        private void saveButton_Click(object sender, EventArgs e)
        {
            
            if (i < highestValue)
            {
                int a= Convert.ToInt16(numtextBox.Text);
                myList.Add(a);
                total += a;
                numtextBox.Clear();
                MessageBox.Show((i+1)+" th number successfully added...");
                i++;
                totalTextBox.Text = Convert.ToString(total);
                if (i == highestValue)
                {
                    outputListBox.Items.Clear();
                    foreach (int index in myList)
                    {
                        outputListBox.Items.Add(index);
                    }
                }
            }
            else
            {
                MessageBox.Show("memory full");
                

            }
            


        }

        private void showButton_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();
            foreach (int index in myList)
            {
                outputListBox.Items.Add(index);
            }
            totalTextBox.Text = Convert.ToString(total);
        }

        private void totalTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
