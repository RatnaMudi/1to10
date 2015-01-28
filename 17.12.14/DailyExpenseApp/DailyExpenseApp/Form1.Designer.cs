namespace DailyExpenseApp
{
    partial class DailyExpense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.amountText = new System.Windows.Forms.TextBox();
            this.particularText = new System.Windows.Forms.TextBox();
            this.categorySelectText = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalExpenseText = new System.Windows.Forms.TextBox();
            this.maxExpenseText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.categoryViewText = new System.Windows.Forms.ComboBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.showListText = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.totalText = new System.Windows.Forms.TextBox();
            this.ShowExpenseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daily Expense Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "View Categorywise Expense";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Particular";
            // 
            // amountText
            // 
            this.amountText.Location = new System.Drawing.Point(102, 42);
            this.amountText.Name = "amountText";
            this.amountText.Size = new System.Drawing.Size(168, 20);
            this.amountText.TabIndex = 5;
            // 
            // particularText
            // 
            this.particularText.Location = new System.Drawing.Point(102, 95);
            this.particularText.Multiline = true;
            this.particularText.Name = "particularText";
            this.particularText.Size = new System.Drawing.Size(168, 49);
            this.particularText.TabIndex = 6;
            // 
            // categorySelectText
            // 
            this.categorySelectText.FormattingEnabled = true;
            this.categorySelectText.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.categorySelectText.Location = new System.Drawing.Point(102, 67);
            this.categorySelectText.Name = "categorySelectText";
            this.categorySelectText.Size = new System.Drawing.Size(168, 21);
            this.categorySelectText.TabIndex = 7;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(195, 170);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "View Summary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total Expense";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Maximum Expense";
            // 
            // totalExpenseText
            // 
            this.totalExpenseText.Location = new System.Drawing.Point(139, 245);
            this.totalExpenseText.Name = "totalExpenseText";
            this.totalExpenseText.Size = new System.Drawing.Size(131, 20);
            this.totalExpenseText.TabIndex = 12;
            // 
            // maxExpenseText
            // 
            this.maxExpenseText.Location = new System.Drawing.Point(139, 281);
            this.maxExpenseText.Name = "maxExpenseText";
            this.maxExpenseText.Size = new System.Drawing.Size(131, 20);
            this.maxExpenseText.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(364, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Category";
            // 
            // categoryViewText
            // 
            this.categoryViewText.FormattingEnabled = true;
            this.categoryViewText.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.categoryViewText.Location = new System.Drawing.Point(420, 42);
            this.categoryViewText.Name = "categoryViewText";
            this.categoryViewText.Size = new System.Drawing.Size(163, 21);
            this.categoryViewText.TabIndex = 15;
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(508, 69);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(75, 23);
            this.ShowButton.TabIndex = 16;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // showListText
            // 
            this.showListText.FormattingEnabled = true;
            this.showListText.Location = new System.Drawing.Point(367, 111);
            this.showListText.Name = "showListText";
            this.showListText.Size = new System.Drawing.Size(216, 147);
            this.showListText.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(449, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Total";
            // 
            // totalText
            // 
            this.totalText.Location = new System.Drawing.Point(487, 288);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(100, 20);
            this.totalText.TabIndex = 19;
            // 
            // ShowExpenseButton
            // 
            this.ShowExpenseButton.Location = new System.Drawing.Point(195, 216);
            this.ShowExpenseButton.Name = "ShowExpenseButton";
            this.ShowExpenseButton.Size = new System.Drawing.Size(75, 23);
            this.ShowExpenseButton.TabIndex = 20;
            this.ShowExpenseButton.Text = "Show";
            this.ShowExpenseButton.UseVisualStyleBackColor = true;
            this.ShowExpenseButton.Click += new System.EventHandler(this.ShowExpenseButton_Click);
            // 
            // DailyExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 367);
            this.Controls.Add(this.ShowExpenseButton);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.showListText);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.categoryViewText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.maxExpenseText);
            this.Controls.Add(this.totalExpenseText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.categorySelectText);
            this.Controls.Add(this.particularText);
            this.Controls.Add(this.amountText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DailyExpense";
            this.Text = "DailyExpense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox amountText;
        private System.Windows.Forms.TextBox particularText;
        private System.Windows.Forms.ComboBox categorySelectText;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox totalExpenseText;
        private System.Windows.Forms.TextBox maxExpenseText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox categoryViewText;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.ListBox showListText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox totalText;
        private System.Windows.Forms.Button ShowExpenseButton;
    }
}

