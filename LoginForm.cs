using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class LoginForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Roland\Desktop\Facultate\SE\LibraryManagementSystem\database\UniversityLibrary.mdf;Integrated Security=True;Connect Timeout=30");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(UserTextBox.Text.Equals("") || PasswordTextBox.Text.Equals(""))
            {
                MessageBox.Show("Login failed. Please enter your login data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DoLogin();
            }
        }

        private void DoLogin()
        {
            connection.Open();
            string Query = "Select * from LibrarianTable where LibrarianName ='" + UserTextBox.Text + "' and LibrarianPassword ='" + PasswordTextBox.Text + "';";
            SqlCommand command = new SqlCommand(Query, connection);
            var reader = command.ExecuteReader();
            if(reader.Read())
            {
                var username = reader["LibrarianName"];
                var password = reader["LibrarianPassword"];
                if(UserTextBox.Text.Equals(username) && PasswordTextBox.Text.Equals(password))
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                
            }
            else
            {
                MessageBox.Show("Login failed. Wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            switch (MessageBox.Show(this, "Are you sure you want to close?", "Close Window", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    Application.Exit();
                    break;
            }
        }
    }
}
