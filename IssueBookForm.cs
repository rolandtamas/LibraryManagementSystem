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
    public partial class IssueBookForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Roland\Desktop\Facultate\SE\LibraryManagementSystem\database\UniversityLibrary.mdf;Integrated Security=True;Connect Timeout=30");
        public IssueBookForm()
        {
            InitializeComponent();
        }

        // Load students in combobox
        private void FillStudents()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT StudName FROM StudentsTable",connection);
            SqlDataReader dr;
            dr = command.ExecuteReader();
            while(dr.Read())
            {
                StdCombo.Items.Add(dr[0].ToString());
            }
            dr.Close();
            connection.Close();
        }

        // Load books in combobox
        private void FillBooks()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT BookTitle FROM BooksTable", connection);
            SqlDataReader dr;
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                BookCombo.Items.Add(dr[0].ToString());
            }
            dr.Close();
            connection.Close();
        }

        private void IssueBookForm_Load(object sender, EventArgs e)
        {
            FillStudents();
            FillBooks();
            PopulateDataGrid();
        }

        //Complete textboxes with student data
        private void StdCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from StudentsTable where StudName='" + StdCombo.SelectedItem.ToString()+"';",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach(DataRow row in dt.Rows)
            {
                DepartmentIssue.Text = row["StudDept"].ToString();
                PhoneIssue.Text = row["StudPhone"].ToString();
            }
            connection.Close();
            
        }

        // Issue a book
        private void button1_Click(object sender, EventArgs e)
        {
            if (ID.Text.Equals("") || StdCombo.SelectedItem.Equals("") || DepartmentIssue.Text.Equals("") || PhoneIssue.Text.Equals("") || BookCombo.SelectedItem.Equals("") || dateTimePicker1.Value.Equals(""))
            {
                MessageBox.Show(this, "Some information is missing, please try again.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into IssuedBooksTable values('" + ID.Text + "', '" + StdCombo.SelectedItem.ToString()+"', '"+DepartmentIssue.Text+"', '"+PhoneIssue.Text+"', '"+BookCombo.SelectedItem.ToString()+"', '"+dateTimePicker1.Value+"');", connection);
                command.ExecuteNonQuery();
                MessageBox.Show(this, "Book issued successfully");
                connection.Close();
                PopulateDataGrid();
            }
        }

        private void PopulateDataGrid()
        {
            connection.Open();
            string Query = "Select * from IssuedBooksTable";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Query, connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            IssuedBooksDataGrid.DataSource = ds.Tables[0];
            connection.Close();
        }     
    }
}
