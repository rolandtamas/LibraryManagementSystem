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
    public partial class StudentForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Roland\Desktop\Facultate\SE\LibraryManagementSystem\database\UniversityLibrary.mdf;Integrated Security=True;Connect Timeout=30");
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = StudentsDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            FullNameRegistration.Text = StudentsDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            DepartmentRegistration.Text = StudentsDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            SemesterCombo.SelectedItem = StudentsDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            PhoneRegistration.Text = StudentsDataGrid.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            PopulateDataGrid();
        }

        private void PopulateDataGrid()
        {
            connection.Open();
            string Query = "Select * from StudentsTable";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Query, connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            StudentsDataGrid.DataSource = ds.Tables[0];
            connection.Close();
        }

        //Add a new Student
        private void button1_Click(object sender, EventArgs e)
        {
            if (FullNameRegistration.Text.Equals("") || DepartmentRegistration.Text.Equals("") || SemesterCombo.SelectedItem.ToString().Equals("") || PhoneRegistration.Text.Equals(""))
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insert into StudentsTable (StudName, StudDept, StudSem, StudPhone) values('"+ FullNameRegistration.Text + "','" + DepartmentRegistration.Text + "','" + SemesterCombo.SelectedItem.ToString() + "','" + PhoneRegistration.Text + "')");
                command.Connection = connection;
                command.ExecuteNonQuery();
                MessageBox.Show("Student added successfully!");
                connection.Close();
                PopulateDataGrid();
            }
        }

        //Edit student
        private void button2_Click(object sender, EventArgs e)
        {
            if (ID.Text.Equals("") || FullNameRegistration.Text.Equals("") || DepartmentRegistration.Text.Equals("") || SemesterCombo.SelectedItem.ToString().Equals("") || PhoneRegistration.Text.Equals(""))
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                SqlCommand command = new SqlCommand("update StudentsTable set StudName='" + FullNameRegistration.Text + "',StudDept='" + DepartmentRegistration.Text + "',StudSem='" + SemesterCombo.SelectedItem.ToString() + "',StudPhone='" + PhoneRegistration.Text + "' where StudID='" + ID.Text + "';");
                command.Connection = connection;
                command.ExecuteNonQuery();
                MessageBox.Show("Student updated successfully!");
                connection.Close();
                PopulateDataGrid();
            }
        }

        //Delete a student
        private void button3_Click(object sender, EventArgs e)
        {
            if (ID.Text.Equals(""))
            {
                MessageBox.Show("Please enter an ID in the textbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from StudentsTable where StudID = " + ID.Text + ";");
                command.Connection = connection;
                command.ExecuteNonQuery();
                MessageBox.Show("Student updated successfully!");
                connection.Close();
                PopulateDataGrid();
            }
        }
    }
}
