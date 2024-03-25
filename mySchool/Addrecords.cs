using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace mySchool
{
    public partial class Addrecord : Form
    {
        public Addrecord()
        {
            InitializeComponent();
            dobpicker.ValueChanged += dobpicker_ValueChanged;

        }

        private void dobdate_Click(object sender, EventArgs e)
        {
            
            
        }

        private void dobpicker_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {

        }

        private void namelabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studid = txtstudentid.Text;
            string myClassValue = txtclass.Text;
            DateTime dobValue = dobpicker.Value;
            string gender = "";

            if (rbmale.Checked)
            {
                gender = "Male";
            }
            else if (rbfemale.Checked)
            {
                gender = "Female";
            }
            else if (rcomplicated.Checked)
            {
                gender = "Complicated";
            }
            else if (rbisex.Checked)
            {
                gender = "Bisexual";
            }
            else
            {
                MessageBox.Show("Why are you gay?");
                return;
            }

            string connectionString = "Server=localhost;Uid=root;Pwd=mikemike;";
            string updateQuery = $"UPDATE MySchool.StudentDetails SET myclass = '{myClassValue}', dob = '{dobValue.ToString("yyyy-MM-dd")}', gender = '{gender}' WHERE studentid = '{studid}'";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);

            try
            {
                connection.Open();
                int rowsAffected = updateCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Details updated successfully");
                    Navigation navigation = new Navigation();
                    navigation.Show();
                    this.Hide();
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


    }
}
