using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pic_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text == "admin" && textBox_password.Text == "admin")
            {
                main_form main = new main_form();
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("Username or password is Incorrect");
            }
        }
    }
}
