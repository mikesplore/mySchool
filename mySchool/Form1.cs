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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=MySchool;Uid=mikesplore;Pwd=mikemike;";

            string firstname = firstnamelabel.Text;
            string lastname = lastnamelabel.Text;
            string password = passwordlabel.Text;
            string studentid = studentidlabel.Text;
            string query = $"INSERT INTO Student (studentid, firstname,lastname ,password ) VALUES ('{studentid}', '{firstname}', {lastname}, '{password}')";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) inserted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            MessageBox.Show("Data saved successfylly");
        }
    }
}
