using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TxtTeFileOperationApp
{
    public partial class Form1 : Form
    {
        string path = @"E:\info.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            
            FileStream aFileStream = new FileStream(path, FileMode.Append);
            StreamWriter aStreamWriter = new StreamWriter(aFileStream);
            aStreamWriter.Write(name);
            aStreamWriter.WriteLine();
            aStreamWriter.Close();
            aFileStream.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(path, FileMode.Open);
            StreamReader aStreamReader = new StreamReader(aFileStream);
            namesListBox.Items.Clear();
            while (!aStreamReader.EndOfStream)
            {
                string aName = aStreamReader.ReadLine();
                namesListBox.Items.Add(aName);
            }
            aStreamReader.Close();
            aFileStream.Close();
        }


    }
}
