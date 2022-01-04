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
    public partial class BooksForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Roland\Desktop\Facultate\SE\LibraryManagementSystem\database\UniversityLibrary.mdf;Integrated Security=True;Connect Timeout=30");
        public BooksForm()
        {
            InitializeComponent();
        }

        //Fields get completed from the datagrid, on click
        private void BooksDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BookTitle.Text = BooksDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            BookAuthor.Text = BooksDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            Publisher.Text = BooksDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            Price.Text = BooksDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            Quantity.Text = BooksDataGrid.SelectedRows[0].Cells[4].Value.ToString();
        }

        //Add new book to the database
        private void button1_Click(object sender, EventArgs e)
        {
            if (BookTitle.Text.Equals("") || BookAuthor.Text.Equals("") || Publisher.Text.Equals("") || Price.Text.Equals("") || Quantity.Text.Equals(""))
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insert into BooksTable values('" + BookTitle.Text + "','" + BookAuthor.Text + "','" + Publisher.Text + "','" + Price.Text + "','" + Quantity.Text + "')");
                command.Connection = connection;
                command.ExecuteNonQuery();
                MessageBox.Show("Book added successfully!");
                connection.Close();
                PopulateDataGrid();
            }
        }

        //Edit a book from database
        private void button2_Click(object sender, EventArgs e)
        {
            if (BookTitle.Text.Equals("") || BookAuthor.Text.Equals("") || Publisher.Text.Equals("") || Price.Text.Equals("") || Quantity.Text.Equals(""))
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                SqlCommand command = new SqlCommand("update BooksTable set BookTitle='" + BookTitle.Text + "',BookAuthor='" + BookAuthor.Text + "',Publisher='" + Publisher.Text + "',Price='" + Price.Text + "',Quantity='" + Quantity.Text + "' where BookTitle='" + BookTitle.Text + "';");
                command.Connection = connection;
                command.ExecuteNonQuery();
                MessageBox.Show("Book updated successfully!");
                connection.Close();
                PopulateDataGrid();
            }
        }

        //Delete a book from database
        private void button3_Click(object sender, EventArgs e)
        {
            if (BookTitle.Text.Equals(""))
            {
                MessageBox.Show("Please enter a title in the textbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from BooksTable where BookTitle = '" + BookTitle.Text + "';");
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
                PopulateDataGrid();
                MessageBox.Show("Book deleted successfully!");
            }
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            PopulateDataGrid();
        }

        private void PopulateDataGrid()
        {
            connection.Open();
            string Query = "Select * from BooksTable";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Query, connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            BooksDataGrid.DataSource = ds.Tables[0];
            connection.Close();
        }
    }
}
