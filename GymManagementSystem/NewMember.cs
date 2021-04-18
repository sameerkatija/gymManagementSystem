using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GymManagementSystem
{
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Samster\\Documents\\gym.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand command = new SqlCommand();
        private void NewMember_Load(object sender, EventArgs e)
        {
            command.Connection = connect;
        }
        private void pic_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            string email = textBox_Email.Text;
            Int64 cell = Int64.Parse(textBox_cell.Text);
            string dob = dateofbirth.Text;
            string joinDateText = joinDate.Text;
            string gymTime = comboBox_gym.Text;
            string gender = combo_Gender.Text;
            
            connect.Open();
            command.CommandText = "INSERT INTO Newmember (Name, Gender, DOB , Cell,Email,JoinDate,GymTime) values('" +
                                  name + "','" + gender + "','" + dob + "','" + cell + "','" + email + "','" +
                                  joinDateText + "','" + gymTime + "')";
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Data Inserted SuccessFully");

            textBox_Name.Clear();
            textBox_Email.Clear();
            textBox_cell.Clear();
            dateofbirth.Value = DateTime.Now;
            joinDate.Value = DateTime.Now;
            comboBox_gym.ResetText();
            combo_Gender.ResetText();

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            textBox_Name.Clear();
            textBox_Email.Clear();
            textBox_cell.Clear();
            dateofbirth.Value = DateTime.Now;
            joinDate.Value = DateTime.Now;
            comboBox_gym.ResetText();
            combo_Gender.ResetText();
        }
    }
}
