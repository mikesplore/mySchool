using MySql.Data.MySqlClient;
using System;

using System.Windows.Forms;

namespace mySchool
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtlstudentid.Text) ||
            string.IsNullOrWhiteSpace(txtlpassword.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            string lstudentid = txtlstudentid.Text;
            string lpassword = txtlpassword.Text;

            string connectionString = "Server=localhost;Database=MySchool;Uid=root;Pwd=mikemike;";
            string query = $"SELECT password FROM StudentDetails WHERE studentid = '{lstudentid}'";

            MySqlConnection connection = new MySqlConnection(connectionString);

            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    string storedPassword = result.ToString();

                    if (lpassword == storedPassword)
                    {
                        //navigate to navigation form
                        Navigation navigation = new Navigation();
                        navigation.Show();
                       
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password");
                    }
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

        private void studentid_Click(object sender, EventArgs e)
        {

        }

        private void txtlpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtlstudentid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
