using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //View students button
        private void button1_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();            
        }

        //View Available Books
        private void button2_Click(object sender, EventArgs e)
        {
            BooksForm booksForm = new BooksForm();
            booksForm.Show();
        }

        //View Librarians
        private void button5_Click(object sender, EventArgs e)
        {
            LibrarianForm librarianForm = new LibrarianForm();
            librarianForm.Show();
        }

        // View Issued Books
        private void button3_Click(object sender, EventArgs e)
        {
            IssueBookForm issueBookForm = new IssueBookForm();
            issueBookForm.Show();
        }

        // View Returned Books
        private void button4_Click(object sender, EventArgs e)
        {
            ReturnBookForm returnBookForm = new ReturnBookForm();
            returnBookForm.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            switch(MessageBox.Show(this, "Are you sure you want to close?", "Close Window", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    // close the application; do nothing since its in the form closing method
                    break;
            }
        }        
    }
}
