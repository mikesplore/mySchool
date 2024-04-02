using MySql.Data.MySqlClient;
using System;

using System.Windows.Forms;

namespace mySchool
{
    public partial class Deleteform : Form
    {
        public Deleteform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string studentId = txtstudentid.Text;

            string connectionString = "Server=localhost;Database=MySchool;Uid=root;Pwd=mikemike;";
            string query = $"SELECT firstname, lastname, dob, gender, myclass FROM StudentDetails WHERE studentid = '{studentId}'";

            MySqlConnection connection = new MySqlConnection(connectionString);

            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) // Check if there is data returned
                {
                    string firstName = reader["firstname"].ToString();
                    string lastName = reader["lastname"].ToString();
                    string dob = reader["dob"].ToString();
                    string gender = reader["gender"].ToString();
                    string studentClass = reader["myclass"].ToString();

                    // Display or use the retrieved information as it
                    txtLName.Text =lastName;
                    txtFName.Text =firstName;
                    txtDOB.Text = dob;
                    txtGender.Text = gender;
                    txtclass.Text = studentClass;
                }
                else
                {
                    MessageBox.Show("Student ID not found");
                }
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

        private void btSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFName.Text;
            string lastName = txtLName.Text;
            string dob = txtDOB.Text;
            string gender = txtGender.Text;
            string studentClass = txtclass.Text;
            string studentId = txtstudentid.Text; 

            string connectionString = "Server=localhost;Database=MySchool;Uid=root;Pwd=mikemike;";
            string query = $"UPDATE StudentDetails SET firstname = '{firstName}', lastname = '{lastName}', dob = '{dob}', gender = '{gender}', myclass = '{studentClass}' WHERE studentid = '{studentId}'";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Details updated successfully.");
                    Navigation navigation = new Navigation();
                    navigation.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to update details. Student ID not found.");
                }
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

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string studentId = txtstudentid.Text; // Assuming there's a text box for student ID

            string connectionString = "Server=localhost;Database=MySchool;Uid=root;Pwd=mikemike;";
            string query = $"DELETE FROM StudentDetails WHERE studentid = '{studentId}'";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record deleted successfully.");
                    ClearTextBoxes();
                    Navigation navigation = new Navigation();
                    navigation.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to delete record. Student ID not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

             void ClearTextBoxes()
            {
                txtFName.Text = "";
                txtLName.Text = "";
                txtDOB.Text = "";
                txtGender.Text = "";
                txtclass.Text = "";
                txtstudentid.Text = "";
            }
        }
    }
}
