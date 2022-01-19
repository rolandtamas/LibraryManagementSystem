using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ReturnBookForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Roland\Desktop\Facultate\SE\LibraryManagementSystem\database\UniversityLibrary.mdf;Integrated Security=True;Connect Timeout=30");
        public ReturnBookForm()
        {
            InitializeComponent();
        }

        private void IssuedBooksDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            ID.Text = IssuedBooksDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            StudentID.Text = IssuedBooksDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            IssuedTo.Text = IssuedBooksDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            DepartmentIssue.Text = IssuedBooksDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            PhoneIssue.Text = IssuedBooksDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            Book.Text = IssuedBooksDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            IssueDate.Value = DateTime.Parse(IssuedBooksDataGrid.SelectedRows[0].Cells[6].Value.ToString());

        }

        // Return an issued book
        private void button1_Click(object sender, EventArgs e)
        {          
            if (ReturnID.Text.Equals("") || ID.Text.Equals("") || StudentID.Text.Equals("") || IssuedTo.Text.Equals("") || DepartmentIssue.Text.Equals("") || PhoneIssue.Text.Equals("") || Book.Text.Equals("") || IssueDate.Value.Equals("") || ReturnDate.Value.Equals(""))
            {
                MessageBox.Show(this, "Please select a book from the Issued Books table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into ReturnedBooksTable values('" + ReturnID.Text + "', '" + StudentID.Text + "', '" + IssuedTo.Text.ToString() + "', '" + DepartmentIssue.Text + "', '" + PhoneIssue.Text + "', '" + Book.Text.ToString() + "', '" + IssueDate.Value+ "', '" + ReturnDate.Value + "');", connection);
                command.ExecuteNonQuery();
                MessageBox.Show(this, "Book returned successfully");
                SqlCommand deleteCommand = new SqlCommand("delete from IssuedBooksTable where IssueID='"+ID.Text.ToString()+"';", connection);
                deleteCommand.ExecuteNonQuery();
                connection.Close();
                UpdateBookQuantity();
                PopulateIssueDataGrid();
                PopulateReturnDataGrid();
            }            
        }

        private void UpdateBookQuantity()
        {
            connection.Open();
            int Quantity = 0, newQuantity;
            SqlCommand command = new SqlCommand("Select * from BooksTable where BookTitle='" + Book.Text.ToString() + "';", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                Quantity = Convert.ToInt32(row["Quantity"].ToString());
            }
            newQuantity = Quantity + 1;
            SqlCommand updateCommand = new SqlCommand("update BooksTable set Quantity='" + newQuantity.ToString() + "' where BookTitle='" + Book.Text.ToString() + "';", connection);
            updateCommand.ExecuteNonQuery();
            connection.Close();
        }

        private void ReturnBookForm_Load(object sender, EventArgs e)
        {
            PopulateIssueDataGrid();
            PopulateReturnDataGrid();
        }

        private void PopulateReturnDataGrid()
        {
            connection.Open();
            string Query = "Select * from ReturnedBooksTable";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Query, connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            ReturnedBooksDataGrid.DataSource = ds.Tables[0];
            connection.Close();
        }

        private void PopulateIssueDataGrid()
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
