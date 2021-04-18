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
    public partial class NewStaff : Form
    {
        public NewStaff()
        {
            InitializeComponent();
        }
        SqlConnection Connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Samster\\Documents\\gym.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand Command = new SqlCommand();
        private void NewMember_Load(object sender, EventArgs e)
        {
            Command.Connection = Connect;
        }
        private void pic_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_reset_Click_1(object sender, EventArgs e)
        {
            textBox_Name.Clear();
            textBox_Email.Clear();
            textBox_cell.Clear();
            dateofbirth.Value = DateTime.Now;
            joinDate.Value = DateTime.Now;
            comboBox_gym.ResetText();
            combo_Gender.ResetText();
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
            Connect.Open();
            Command.CommandText = "INSERT INTO NewStaff (Name, Gender, DOB , Cell,Email,JoinDate,GymTime) values('" +
                                  name + "','" + gender + "','" + dob + "','" + cell + "','" + email + "','" +
                                  joinDateText + "','" + gymTime + "')";
            Command.Connection = Connect;
            Command.ExecuteNonQuery();
            Connect.Close();
            MessageBox.Show("Data Inserted SuccessFully" + name + email);
            textBox_Name.Clear();
            textBox_Email.Clear();
            textBox_cell.Clear();
            dateofbirth.Value = DateTime.Now;
            joinDate.Value = DateTime.Now;
            comboBox_gym.ResetText();
            combo_Gender.ResetText();
        }

        private void NewStaff_Load(object sender, EventArgs e)
        {

        }
    }
}
