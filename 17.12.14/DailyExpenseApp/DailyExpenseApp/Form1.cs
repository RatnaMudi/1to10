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

namespace DailyExpenseApp
{
    public partial class DailyExpense : Form
    {
        private string path = @"H:\View_Entry_DailyExpense.CSV";

        public DailyExpense()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
                FileStream bStream = new FileStream(path, FileMode.Append);
                CSVLib.CsvFileWriter aWriter = new CSVLib.CsvFileWriter(bStream);

                List<string> dailyExpenseRecord = new List<string>();
                dailyExpenseRecord.Add(amountText.Text);
                dailyExpenseRecord.Add(categorySelectText.Text);
                dailyExpenseRecord.Add(particularText.Text);
                aWriter.WriteRow(dailyExpenseRecord);

               amountText.Text = String.Empty;
               categorySelectText.Text = String.Empty;
               particularText.Text = String.Empty;
           
                bStream.Close();
        }

        private void ShowExpenseButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                FileStream aStream = new FileStream(path, FileMode.Open);
                CsvFileReader aReader = new CsvFileReader(aStream);
                List<string> expenseRecord = new List<string>();
                List<Double> salaryRecord = new List<Double>();
                Double totalAmount = 0, max;
                totalExpenseText.Text = String.Empty;
                maxExpenseText.Text = String.Empty;
                while (aReader.ReadRow(expenseRecord))
                {
                    string amount = expenseRecord[0];

                    expenseRecord.Add(amount);
                    salaryRecord.Add(Convert.ToDouble(expenseRecord[0]));
                    totalAmount += Convert.ToDouble(expenseRecord[0]);

                }

                totalExpenseText.Text = totalAmount.ToString();
                max = salaryRecord.Max();
                maxExpenseText.Text = Convert.ToString(max);
                aStream.Close();
            }
            else
            {
                MessageBox.Show("No record exists!");
            }

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            int f = 0;
           
            if (File.Exists(path))
            {
                FileStream aStream = new FileStream(path, FileMode.Open);
                CsvFileReader aReader = new CsvFileReader(aStream);
                List<string> categoryViewRecord = new List<string>();

                string insertData = categoryViewText.Text.ToLower();
                Double totalAmount = 0;
                
                showListText.Items.Clear();
                totalText.Text = String.Empty;
                while (aReader.ReadRow(categoryViewRecord))
                {

                    if (categoryViewRecord[1] == categoryViewText.Text)
                    {
                        f = 1;
                        string amount = categoryViewRecord[0];
                        string category = categoryViewRecord[1];
                        string particular = categoryViewRecord[2];
                        string details = amount + "  " + category + "  " + particular + "\n";
                        totalAmount += Convert.ToDouble(categoryViewRecord[0]);
                        showListText.Items.Add(details);

                    }
                    totalText.Text = totalAmount.ToString();
                }
                aStream.Close();
            }
            else
            {
                MessageBox.Show("No record exists!");
            }
            if (f == 0)
                    MessageBox.Show("Data doen't Exists!!");

                
           

        }
    }
}
