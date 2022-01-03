
namespace LibraryManagementSystem
{
    partial class LibrarianForm
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
            this.LibrariansDataGrid = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PhoneRegistration = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordRegistration = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.FullNameRegistration = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LibrariansDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LibrariansDataGrid
            // 
            this.LibrariansDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LibrariansDataGrid.Location = new System.Drawing.Point(399, 122);
            this.LibrariansDataGrid.Name = "LibrariansDataGrid";
            this.LibrariansDataGrid.RowHeadersWidth = 51;
            this.LibrariansDataGrid.RowTemplate.Height = 29;
            this.LibrariansDataGrid.Size = new System.Drawing.Size(691, 297);
            this.LibrariansDataGrid.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 29);
            this.button2.TabIndex = 26;
            this.button2.Text = "Edit Librarian";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 29);
            this.button1.TabIndex = 25;
            this.button1.Text = "Add Librarian";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PhoneRegistration
            // 
            this.PhoneRegistration.Location = new System.Drawing.Point(133, 280);
            this.PhoneRegistration.Name = "PhoneRegistration";
            this.PhoneRegistration.Size = new System.Drawing.Size(210, 27);
            this.PhoneRegistration.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label6.Location = new System.Drawing.Point(33, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Phone No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "LibUserName";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(133, 122);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(75, 27);
            this.ID.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 64);
            this.label1.TabIndex = 14;
            this.label1.Text = "Librarian Registration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(33, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Password";
            // 
            // PasswordRegistration
            // 
            this.PasswordRegistration.Location = new System.Drawing.Point(133, 226);
            this.PasswordRegistration.Name = "PasswordRegistration";
            this.PasswordRegistration.PasswordChar = '*';
            this.PasswordRegistration.Size = new System.Drawing.Size(210, 27);
            this.PasswordRegistration.TabIndex = 20;
            this.PasswordRegistration.UseSystemPasswordChar = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(269, 471);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 29);
            this.button3.TabIndex = 28;
            this.button3.Text = "Delete Librarian";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FullNameRegistration
            // 
            this.FullNameRegistration.Location = new System.Drawing.Point(133, 173);
            this.FullNameRegistration.Name = "FullNameRegistration";
            this.FullNameRegistration.Size = new System.Drawing.Size(210, 27);
            this.FullNameRegistration.TabIndex = 29;
            // 
            // LibrarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 524);
            this.Controls.Add(this.FullNameRegistration);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LibrariansDataGrid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PhoneRegistration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PasswordRegistration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LibrarianForm";
            this.Text = "LibrarianForm";
            this.Load += new System.EventHandler(this.LibrarianForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LibrariansDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LibrariansDataGrid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PhoneRegistration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordRegistration;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox FullNameRegistration;
    }
}