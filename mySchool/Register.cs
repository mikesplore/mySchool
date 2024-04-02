using System;

using System.Windows.Forms;
using MySql.Data.MySqlClient;


   
namespace mySchool
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

   
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            // Check if any field is empty
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string connectionString = "Server=localhost;Uid=root;Pwd=mikemike;";

            string createDatabaseQuery = "CREATE DATABASE IF NOT EXISTS MySchool";

            string createTableQuery = @"CREATE TABLE IF NOT EXISTS MySchool.StudentDetails (
                                    studentid VARCHAR(15) PRIMARY KEY,
                                    firstname VARCHAR(50),
                                    lastname VARCHAR(50),
                                    password VARCHAR(50),
                                    myclass VARCHAR(50),
                                    dob VARCHAR(10),
                                    gender VARCHAR(50)
                                )";

            string studentid = txtStudentID.Text;
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string password = txtPassword.Text;
            string insertQuery = $"INSERT INTO MySchool.StudentDetails (studentid, firstname, lastname, password) VALUES ('{studentid}', '{firstname}', '{lastname}', '{password}')";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand createDatabaseCommand = new MySqlCommand(createDatabaseQuery, connection);
            MySqlCommand createTableCommand = new MySqlCommand(createTableQuery, connection);
            MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);

            try
            {
                connection.Open();

                createDatabaseCommand.ExecuteNonQuery();
                connection.ChangeDatabase("MySchool");
                createTableCommand.ExecuteNonQuery();

                // Check if the student ID already exists
                string checkStudentQuery = $"SELECT COUNT(*) FROM MySchool.StudentDetails WHERE studentid = '{studentid}'";
                MySqlCommand checkStudentCommand = new MySqlCommand(checkStudentQuery, connection);
                int studentCount = Convert.ToInt32(checkStudentCommand.ExecuteScalar());

                if (studentCount > 0)
                {
                    MessageBox.Show("Student ID already exists. Please enter a unique student ID.");
                    return; // Exit the method to prevent further execution
                }

                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Data saved successfully");

                // Navigate to login form
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }



        private void clearbutton_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPassword.Text = "";
            txtStudentID.Text = "";
        }

        private void lastnamelabel_Click(object sender, EventArgs e)
        {

        }

        private void firstnamelabel_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordlabel_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
