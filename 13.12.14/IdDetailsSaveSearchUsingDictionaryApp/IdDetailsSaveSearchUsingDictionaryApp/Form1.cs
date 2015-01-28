using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdDetailsSaveSearchUsingDictionaryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, string> citizenInfoDictionary= new Dictionary<int, string>();

        private void saveButton_Click(object sender, EventArgs e)
        {
            citizenInfoDictionary.Add(Convert.ToInt16(idEntryTextBox.Text), detailEntryTextBox.Text);
            MessageBox.Show("added");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (citizenInfoDictionary.ContainsKey(Convert.ToInt16(idEntryTextBox.Text)))
            {
                MessageBox.Show(citizenInfoDictionary[Convert.ToInt16(idSearchTextBox.Text)]);
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            string display=" ";
            foreach (KeyValuePair<int, string> i in citizenInfoDictionary)
            {
                display += "Id= " + Convert.ToString(i.Key) + "Details= " + i.Value + "\n";
            }
            MessageBox.Show(display);
        }
    }
}
