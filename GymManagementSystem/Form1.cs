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
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }
        
        private void main_form_Load(object sender, EventArgs e)
        {
            
        }
        private void pic_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lbl_logo_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_newMember_Click(object sender, EventArgs e)
        {
            NewMember nm = new NewMember();
            nm.Show();
        }

        private void btn_newStaff_Click(object sender, EventArgs e)
        {
            NewStaff ns = new NewStaff();
            ns.Show();
        }

        private void btn_searchMember_Click(object sender, EventArgs e)
        {
            ShowMember sm = new ShowMember();
            sm.Show();
        }

        private void btn_deleteMember_Click(object sender, EventArgs e)
        {
            DeleteMember dm = new DeleteMember();
            dm.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();

        }
    }
}
