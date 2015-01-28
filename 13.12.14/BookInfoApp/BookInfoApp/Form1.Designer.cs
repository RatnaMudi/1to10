namespace BookInfoApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addISBNTextBox = new System.Windows.Forms.TextBox();
            this.addBookDetailsTextBox = new System.Windows.Forms.TextBox();
            this.searchBookDetailsTextBox = new System.Windows.Forms.TextBox();
            this.searchISBNTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.addBookDetailsTextBox);
            this.groupBox1.Controls.Add(this.addISBNTextBox);
            this.groupBox1.Location = new System.Drawing.Point(207, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Book Info";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.findButton);
            this.groupBox2.Controls.Add(this.searchISBNTextBox);
            this.groupBox2.Controls.Add(this.searchBookDetailsTextBox);
            this.groupBox2.Location = new System.Drawing.Point(207, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Book";
            // 
            // addISBNTextBox
            // 
            this.addISBNTextBox.Location = new System.Drawing.Point(86, 38);
            this.addISBNTextBox.Name = "addISBNTextBox";
            this.addISBNTextBox.Size = new System.Drawing.Size(100, 20);
            this.addISBNTextBox.TabIndex = 0;
            // 
            // addBookDetailsTextBox
            // 
            this.addBookDetailsTextBox.Location = new System.Drawing.Point(86, 76);
            this.addBookDetailsTextBox.Multiline = true;
            this.addBookDetailsTextBox.Name = "addBookDetailsTextBox";
            this.addBookDetailsTextBox.Size = new System.Drawing.Size(100, 20);
            this.addBookDetailsTextBox.TabIndex = 1;
            // 
            // searchBookDetailsTextBox
            // 
            this.searchBookDetailsTextBox.Location = new System.Drawing.Point(81, 90);
            this.searchBookDetailsTextBox.Multiline = true;
            this.searchBookDetailsTextBox.Name = "searchBookDetailsTextBox";
            this.searchBookDetailsTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchBookDetailsTextBox.TabIndex = 1;
            // 
            // searchISBNTextBox
            // 
            this.searchISBNTextBox.Location = new System.Drawing.Point(81, 60);
            this.searchISBNTextBox.Name = "searchISBNTextBox";
            this.searchISBNTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchISBNTextBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(96, 113);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(81, 116);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 3;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Book Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Book Details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 404);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Book Information Save & Search";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addBookDetailsTextBox;
        private System.Windows.Forms.TextBox addISBNTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox searchISBNTextBox;
        private System.Windows.Forms.TextBox searchBookDetailsTextBox;
    }
}

