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
using CSVLib;

namespace StudentRecordApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private string fileLocation = @"E:\StudentRecord.csv";
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            FileStream aStream= new FileStream(fileLocation, FileMode.Append);
            CsvFileWriter aWriter= new CsvFileWriter(aStream);
            List<string> aStudentRecord= new List<string>();
            aStudentRecord.Add(regNoTextBox.Text);
            aStudentRecord.Add(nameTextBox.Text);
            aWriter.WriteRow(aStudentRecord);
            aStream.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream aStream = new FileStream(fileLocation, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> aStudentRecord = new List<string>();
            showListBox.Items.Clear();
            while (aReader.ReadRow(aStudentRecord))
            {
                string regNo = aStudentRecord[0];
                string name = aStudentRecord[1];
                showListBox.Items.Add(regNo + " " + name);

            }
            aStream.Close();
        }
    }
}
