namespace SalaryCalculatorApp
{
    partial class Form1
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
            this.enterEmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.enterBasicSalaryTextBox = new System.Windows.Forms.TextBox();
            this.enterHouseRentTextBox = new System.Windows.Forms.TextBox();
            this.enterMedicalAllowanceTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterEmployeeNameTextBox
            // 
            this.enterEmployeeNameTextBox.Location = new System.Drawing.Point(201, 25);
            this.enterEmployeeNameTextBox.Name = "enterEmployeeNameTextBox";
            this.enterEmployeeNameTextBox.Size = new System.Drawing.Size(211, 20);
            this.enterEmployeeNameTextBox.TabIndex = 0;
            // 
            // enterBasicSalaryTextBox
            // 
            this.enterBasicSalaryTextBox.Location = new System.Drawing.Point(201, 63);
            this.enterBasicSalaryTextBox.Name = "enterBasicSalaryTextBox";
            this.enterBasicSalaryTextBox.Size = new System.Drawing.Size(211, 20);
            this.enterBasicSalaryTextBox.TabIndex = 1;
            // 
            // enterHouseRentTextBox
            // 
            this.enterHouseRentTextBox.Location = new System.Drawing.Point(201, 102);
            this.enterHouseRentTextBox.Name = "enterHouseRentTextBox";
            this.enterHouseRentTextBox.Size = new System.Drawing.Size(211, 20);
            this.enterHouseRentTextBox.TabIndex = 2;
            // 
            // enterMedicalAllowanceTextBox
            // 
            this.enterMedicalAllowanceTextBox.Location = new System.Drawing.Point(201, 143);
            this.enterMedicalAllowanceTextBox.Name = "enterMedicalAllowanceTextBox";
            this.enterMedicalAllowanceTextBox.Size = new System.Drawing.Size(211, 20);
            this.enterMedicalAllowanceTextBox.TabIndex = 3;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(201, 186);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(211, 23);
            this.showButton.TabIndex = 4;
            this.showButton.Text = "Show Me Salary";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employee name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Basic Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "House Rent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Medical Allowance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "% of basic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "% of basic";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 378);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.enterMedicalAllowanceTextBox);
            this.Controls.Add(this.enterHouseRentTextBox);
            this.Controls.Add(this.enterBasicSalaryTextBox);
            this.Controls.Add(this.enterEmployeeNameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enterEmployeeNameTextBox;
        private System.Windows.Forms.TextBox enterBasicSalaryTextBox;
        private System.Windows.Forms.TextBox enterHouseRentTextBox;
        private System.Windows.Forms.TextBox enterMedicalAllowanceTextBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

