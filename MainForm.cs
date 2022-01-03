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
            //this.Hide();
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
    }
}
