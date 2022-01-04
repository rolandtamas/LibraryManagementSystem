
namespace LibraryManagementSystem
{
    partial class StudentForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.FullNameRegistration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DepartmentRegistration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SemesterCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PhoneRegistration = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.StudentsDataGrid = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Full Name";
            // 
            // FullNameRegistration
            // 
            this.FullNameRegistration.Location = new System.Drawing.Point(128, 145);
            this.FullNameRegistration.Name = "FullNameRegistration";
            this.FullNameRegistration.Size = new System.Drawing.Size(210, 27);
            this.FullNameRegistration.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(28, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Department";
            // 
            // DepartmentRegistration
            // 
            this.DepartmentRegistration.Location = new System.Drawing.Point(128, 198);
            this.DepartmentRegistration.Name = "DepartmentRegistration";
            this.DepartmentRegistration.Size = new System.Drawing.Size(210, 27);
            this.DepartmentRegistration.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(29, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Semester";
            // 
            // SemesterCombo
            // 
            this.SemesterCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SemesterCombo.FormattingEnabled = true;
            this.SemesterCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.SemesterCombo.Location = new System.Drawing.Point(128, 248);
            this.SemesterCombo.Name = "SemesterCombo";
            this.SemesterCombo.Size = new System.Drawing.Size(106, 28);
            this.SemesterCombo.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label6.Location = new System.Drawing.Point(28, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Phone No.";
            // 
            // PhoneRegistration
            // 
            this.PhoneRegistration.Location = new System.Drawing.Point(128, 296);
            this.PhoneRegistration.Name = "PhoneRegistration";
            this.PhoneRegistration.Size = new System.Drawing.Size(210, 27);
            this.PhoneRegistration.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Edit Student";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StudentsDataGrid
            // 
            this.StudentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDataGrid.Location = new System.Drawing.Point(394, 47);
            this.StudentsDataGrid.Name = "StudentsDataGrid";
            this.StudentsDataGrid.ReadOnly = true;
            this.StudentsDataGrid.RowHeadersWidth = 51;
            this.StudentsDataGrid.RowTemplate.Height = 29;
            this.StudentsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentsDataGrid.Size = new System.Drawing.Size(710, 360);
            this.StudentsDataGrid.TabIndex = 13;
            this.StudentsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsDataGrid_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(248, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 29);
            this.button3.TabIndex = 14;
            this.button3.Text = "Delete Student";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(128, 101);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(74, 27);
            this.ID.TabIndex = 16;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 450);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.StudentsDataGrid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PhoneRegistration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SemesterCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DepartmentRegistration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FullNameRegistration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FullNameRegistration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DepartmentRegistration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SemesterCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PhoneRegistration;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView StudentsDataGrid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID;
    }
}