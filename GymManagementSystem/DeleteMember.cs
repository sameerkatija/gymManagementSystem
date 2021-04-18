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
    public partial class DeleteMember : Form
    {
        public DeleteMember()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Samster\\Documents\\gym.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand command = new SqlCommand();

        private void DeleteMember_Load(object sender, EventArgs e)
        {
            command.Connection = connect;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pic_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (textBox_deleteMember.Text != "")
            {
                connect.Open();
                command.CommandText =
                    "DELETE FROM Newmember WHERE MID = " + Int32.Parse(textBox_deleteMember.Text) + "";
                command.Connection = connect;
                command.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Delete SuccessFully");
                textBox_deleteMember.Clear();
            }
            else
            {
                MessageBox.Show("Please Enter Valid Id", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
