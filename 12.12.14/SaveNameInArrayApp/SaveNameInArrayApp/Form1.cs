using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveNameInArrayApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        string[] name = new string[10];
        private int highestValue = 5,i=0;
        private void saveButton_Click(object sender, EventArgs e)
        {
            
            if (i < highestValue)
            {
                name[i] = nametextBox.Text;
                nametextBox.Clear();
                MessageBox.Show((i+1)+" th name successfully added...");
                i++;
                if (i == highestValue)
                {
                    outputListBox.Items.Clear();
                    foreach (string index in name)
                    {
                        if (index != null)
                        {
                            outputListBox.Items.Add(index);

                        }
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
            foreach (string index in name)
            {
                if (index != null)
                {
                    outputListBox.Items.Add(index);
                }
            }
            totalTextBox.Text = Convert.ToString(i);
        }

        private void totalTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
