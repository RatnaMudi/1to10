using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDatabaseApp
{
    public partial class MenuUI : Form
    {
        public MenuUI()
        {
            InitializeComponent();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            ViewUI aViewUi = new ViewUI();
            aViewUi.Show();
            Hide();
        }

        private void entryButton_Click(object sender, EventArgs e)
        {
            StudentEntryForm aStudentEntryForm = new StudentEntryForm();
            aStudentEntryForm.Show();
            Hide();
        }

        private void MenuUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
