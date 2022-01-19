
namespace LibraryManagementSystem
{
    partial class ReturnBookForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.StudentID = new System.Windows.Forms.TextBox();
            this.IssuedBooksDataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PhoneIssue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DepartmentIssue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ReturnedBooksDataGrid = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.IssueDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.IssuedTo = new System.Windows.Forms.TextBox();
            this.Book = new System.Windows.Forms.TextBox();
            this.ReturnID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IssuedBooksDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnedBooksDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Student ID";
            // 
            // StudentID
            // 
            this.StudentID.Location = new System.Drawing.Point(141, 207);
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Size = new System.Drawing.Size(151, 27);
            this.StudentID.TabIndex = 48;
            // 
            // IssuedBooksDataGrid
            // 
            this.IssuedBooksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IssuedBooksDataGrid.Location = new System.Drawing.Point(391, 107);
            this.IssuedBooksDataGrid.Name = "IssuedBooksDataGrid";
            this.IssuedBooksDataGrid.RowHeadersWidth = 51;
            this.IssuedBooksDataGrid.RowTemplate.Height = 29;
            this.IssuedBooksDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.IssuedBooksDataGrid.Size = new System.Drawing.Size(296, 345);
            this.IssuedBooksDataGrid.TabIndex = 47;
            this.IssuedBooksDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IssuedBooksDataGrid_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 29);
            this.button1.TabIndex = 46;
            this.button1.Text = "Return Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReturnDate
            // 
            this.ReturnDate.Location = new System.Drawing.Point(141, 373);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(239, 27);
            this.ReturnDate.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Return Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Book";
            // 
            // PhoneIssue
            // 
            this.PhoneIssue.Location = new System.Drawing.Point(141, 274);
            this.PhoneIssue.Name = "PhoneIssue";
            this.PhoneIssue.ReadOnly = true;
            this.PhoneIssue.Size = new System.Drawing.Size(151, 27);
            this.PhoneIssue.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Phone No.";
            // 
            // DepartmentIssue
            // 
            this.DepartmentIssue.Location = new System.Drawing.Point(141, 240);
            this.DepartmentIssue.Name = "DepartmentIssue";
            this.DepartmentIssue.ReadOnly = true;
            this.DepartmentIssue.Size = new System.Drawing.Size(151, 27);
            this.DepartmentIssue.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Issued To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 64);
            this.label1.TabIndex = 33;
            this.label1.Text = "Return Books";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(141, 141);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(75, 27);
            this.ID.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 50;
            this.label9.Text = "Issue ID";
            // 
            // ReturnedBooksDataGrid
            // 
            this.ReturnedBooksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReturnedBooksDataGrid.Location = new System.Drawing.Point(727, 107);
            this.ReturnedBooksDataGrid.Name = "ReturnedBooksDataGrid";
            this.ReturnedBooksDataGrid.RowHeadersWidth = 51;
            this.ReturnedBooksDataGrid.RowTemplate.Height = 29;
            this.ReturnedBooksDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReturnedBooksDataGrid.Size = new System.Drawing.Size(296, 345);
            this.ReturnedBooksDataGrid.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(438, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 64);
            this.label10.TabIndex = 53;
            this.label10.Text = "Issued Books";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(763, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(222, 64);
            this.label11.TabIndex = 54;
            this.label11.Text = "Returned Books";
            // 
            // IssueDate
            // 
            this.IssueDate.Enabled = false;
            this.IssueDate.Location = new System.Drawing.Point(141, 340);
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.Size = new System.Drawing.Size(239, 27);
            this.IssueDate.TabIndex = 56;
            this.IssueDate.Value = new System.DateTime(2022, 1, 19, 23, 5, 31, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 345);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 20);
            this.label12.TabIndex = 55;
            this.label12.Text = "Issue Date";
            // 
            // IssuedTo
            // 
            this.IssuedTo.Location = new System.Drawing.Point(141, 174);
            this.IssuedTo.Name = "IssuedTo";
            this.IssuedTo.ReadOnly = true;
            this.IssuedTo.Size = new System.Drawing.Size(151, 27);
            this.IssuedTo.TabIndex = 57;
            // 
            // Book
            // 
            this.Book.Location = new System.Drawing.Point(141, 307);
            this.Book.Name = "Book";
            this.Book.ReadOnly = true;
            this.Book.Size = new System.Drawing.Size(151, 27);
            this.Book.TabIndex = 58;
            // 
            // ReturnID
            // 
            this.ReturnID.Location = new System.Drawing.Point(141, 107);
            this.ReturnID.Name = "ReturnID";
            this.ReturnID.Size = new System.Drawing.Size(75, 27);
            this.ReturnID.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Return ID";
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 486);
            this.Controls.Add(this.ReturnID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Book);
            this.Controls.Add(this.IssuedTo);
            this.Controls.Add(this.IssueDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ReturnedBooksDataGrid);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.IssuedBooksDataGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PhoneIssue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DepartmentIssue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ReturnBookForm";
            this.Text = "ReturnBookForm";
            this.Load += new System.EventHandler(this.ReturnBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IssuedBooksDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnedBooksDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox StudentID;
        private System.Windows.Forms.DataGridView IssuedBooksDataGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker ReturnDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PhoneIssue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DepartmentIssue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView ReturnedBooksDataGrid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker IssueDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox IssuedTo;
        private System.Windows.Forms.TextBox Book;
        private System.Windows.Forms.TextBox ReturnID;
        private System.Windows.Forms.Label label2;
    }
}