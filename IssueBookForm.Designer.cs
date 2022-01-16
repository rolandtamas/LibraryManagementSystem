
namespace LibraryManagementSystem
{
    partial class IssueBookForm
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
            this.ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StdCombo = new System.Windows.Forms.ComboBox();
            this.DepartmentIssue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneIssue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BookCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.IssuedBooksDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.IssuedBooksDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 64);
            this.label1.TabIndex = 15;
            this.label1.Text = "Issue Books";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(118, 94);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(75, 27);
            this.ID.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Issue ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Issue To:";
            // 
            // StdCombo
            // 
            this.StdCombo.FormattingEnabled = true;
            this.StdCombo.Location = new System.Drawing.Point(118, 142);
            this.StdCombo.Name = "StdCombo";
            this.StdCombo.Size = new System.Drawing.Size(151, 28);
            this.StdCombo.TabIndex = 20;
            this.StdCombo.SelectedIndexChanged += new System.EventHandler(this.StdCombo_SelectedIndexChanged);
            // 
            // DepartmentIssue
            // 
            this.DepartmentIssue.Location = new System.Drawing.Point(118, 184);
            this.DepartmentIssue.Name = "DepartmentIssue";
            this.DepartmentIssue.ReadOnly = true;
            this.DepartmentIssue.Size = new System.Drawing.Size(151, 27);
            this.DepartmentIssue.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Department";
            // 
            // PhoneIssue
            // 
            this.PhoneIssue.Location = new System.Drawing.Point(118, 224);
            this.PhoneIssue.Name = "PhoneIssue";
            this.PhoneIssue.ReadOnly = true;
            this.PhoneIssue.Size = new System.Drawing.Size(151, 27);
            this.PhoneIssue.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Phone No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Book";
            // 
            // BookCombo
            // 
            this.BookCombo.FormattingEnabled = true;
            this.BookCombo.Location = new System.Drawing.Point(118, 266);
            this.BookCombo.Name = "BookCombo";
            this.BookCombo.Size = new System.Drawing.Size(151, 28);
            this.BookCombo.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 309);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(239, 27);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 29);
            this.button1.TabIndex = 29;
            this.button1.Text = "Issue Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IssuedBooksDataGrid
            // 
            this.IssuedBooksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IssuedBooksDataGrid.Location = new System.Drawing.Point(374, 61);
            this.IssuedBooksDataGrid.Name = "IssuedBooksDataGrid";
            this.IssuedBooksDataGrid.RowHeadersWidth = 51;
            this.IssuedBooksDataGrid.RowTemplate.Height = 29;
            this.IssuedBooksDataGrid.Size = new System.Drawing.Size(601, 345);
            this.IssuedBooksDataGrid.TabIndex = 30;            
            // 
            // IssueBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 450);
            this.Controls.Add(this.IssuedBooksDataGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BookCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PhoneIssue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DepartmentIssue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StdCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IssueBookForm";
            this.Text = "IssueBookForm";
            this.Load += new System.EventHandler(this.IssueBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IssuedBooksDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox StdCombo;
        private System.Windows.Forms.TextBox DepartmentIssue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PhoneIssue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox BookCombo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView IssuedBooksDataGrid;
    }
}