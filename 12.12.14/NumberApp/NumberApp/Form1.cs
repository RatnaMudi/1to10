using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int number = Convert.ToInt16(numberTextBox.Text);
            for (int i = 1; i <= number; i++)
            {
                listOutput.Items.Add(i);
            }
            numberTextBox.Clear();
            //listOutput.Items.Clear();
         }

        private void listOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            listOutput.Items.Clear();
        }
        }
    }

