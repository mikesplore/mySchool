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
            string connectionString = "Server=localhost;Uid=root;Pwd=mikemike;";

            string createDatabaseQuery = "CREATE DATABASE IF NOT EXISTS MySchool";

            string createTableQuery = "CREATE TABLE IF NOT EXISTS MySchool.StudentDetails (studentid VARCHAR(15), firstname VARCHAR(50), lastname VARCHAR(50), password VARCHAR(50), myclass VARCHAR(50), dob VARCHAR(10), gender VARCHAR(50))";

            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string password = txtPassword.Text;
            string studentid = txtStudentID.Text;
            string deletetable = "DELETE FROM StudentDetails";
            string insertQuery = $"INSERT INTO MySchool.StudentDetails (studentid, firstname, lastname, password) VALUES ('{studentid}', '{firstname}', '{lastname}', '{password}')";
            string droptable = "DROP TABLE StudentDetails";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand createDatabaseCommand = new MySqlCommand(createDatabaseQuery, connection);
            MySqlCommand createTableCommand = new MySqlCommand(createTableQuery, connection);
            MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
            MySqlCommand deleteCommand = new MySqlCommand(deletetable, connection);
            MySqlCommand droptableCommand = new MySqlCommand(droptable, connection);


            try
            {
                connection.Open();
                
                createDatabaseCommand.ExecuteNonQuery();
                connection.ChangeDatabase("MySchool");
                //droptableCommand.ExecuteNonQuery();
                //deleteCommand.ExecuteNonQuery();
                createTableCommand.ExecuteNonQuery();               
                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Data saved successfully");
                //navigate to login form
                Login Login = new Login();
                Login.Show();
                
                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
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
