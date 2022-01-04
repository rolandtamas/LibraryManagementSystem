using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class LibrarianForm : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Roland\Desktop\Facultate\SE\LibraryManagementSystem\database\UniversityLibrary.mdf;Integrated Security=True;Connect Timeout=30");
        public LibrarianForm()
        {
            InitializeComponent();
        }

        //Add new librarian to database
        private void button1_Click(object sender, EventArgs e)
        {
            if(FullNameRegistration.Text.Equals("") || PasswordRegistration.Text.Equals("") || PhoneRegistration.Text.Equals(""))
            {
                MessageBox.Show("Missing Information","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insert into LibrarianTable (LibrarianName, LibrarianPassword, LibrarianPhone) values('"+FullNameRegistration.Text+"','"+PasswordRegistration.Text+"','"+PhoneRegistration.Text+"')");
                command.Connection = connection;
                command.ExecuteNonQuery();
                MessageBox.Show("Librarian added successfully!");
                connection.Close();
                PopulateDataGrid();                
            }
        }

        //On loading the view, populate the datagrid
        private void LibrarianForm_Load(object sender, EventArgs e)
        {
            PopulateDataGrid();
        }

        private void PopulateDataGrid()
        {
            connection.Open();
            string Query = "Select * from LibrarianTable";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Query, connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            LibrariansDataGrid.DataSource = ds.Tables[0];
            connection.Close();
        }

        //Delete librarian by ID
        private void button3_Click(object sender, EventArgs e)
        {
            if(ID.Text.Equals(""))
            {
                MessageBox.Show("Please enter an ID in the textbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from LibrarianTable where LibrarianID = " + ID.Text + ";");
                command.Connection = connection;
                command.ExecuteNonQuery();               
                connection.Close();
                PopulateDataGrid();
                MessageBox.Show("Librarian deleted successfully!");
            }
        }

        //Select content of cell and complete text boxes
        private void LibrariansDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = LibrariansDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            FullNameRegistration.Text = LibrariansDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            PasswordRegistration.Text = LibrariansDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            PhoneRegistration.Text = LibrariansDataGrid.SelectedRows[0].Cells[3].Value.ToString();
        }
        //Update librarian
        private void button2_Click(object sender, EventArgs e)
        {
            if (ID.Text.Equals("") || FullNameRegistration.Text.Equals("") || PasswordRegistration.Text.Equals("") || PhoneRegistration.Text.Equals(""))
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                SqlCommand command = new SqlCommand("update LibrarianTable set LibrarianName='"+FullNameRegistration.Text+"',LibrarianPassword='" + PasswordRegistration.Text+"',LibrarianPhone='"+PhoneRegistration.Text+"' where LibrarianID='"+ID.Text+"';");
                command.Connection = connection;
                command.ExecuteNonQuery();
                MessageBox.Show("Librarian updated successfully!");
                connection.Close();
                PopulateDataGrid();
            }
        }
    }
}
