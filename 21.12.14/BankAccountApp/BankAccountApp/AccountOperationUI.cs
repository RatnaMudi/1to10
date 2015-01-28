using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountApp
{
    public partial class AccountOperationUI : Form
    {
        public AccountOperationUI()
        {
            InitializeComponent();
        }
        Account anAccount= new Account();

        private void createbButton_Click(object sender, EventArgs e)
        {
            anAccount.number = accountNoTextBox.Text;
            anAccount.name = customerNameTextBox.Text;

            accountNoTextBox.ReadOnly = true;
            customerNameTextBox.ReadOnly = true;
            createbButton.Enabled = false;
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(transactionAmountTextBox.Text);
            anAccount.DepositAmount(amount);
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(transactionAmountTextBox.Text);
            anAccount.WithdrawAmount(amount);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(anAccount.GetReport());
        }
    }
}
