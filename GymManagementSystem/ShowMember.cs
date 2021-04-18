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
    public partial class ShowMember : Form
    {
        public ShowMember()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Samster\\Documents\\gym.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand command = new SqlCommand();

        private void ShowMember_Load(object sender, EventArgs e)
        {
            command.Connection = connect;
            connect.Open();
            command.CommandText =
                "SELECT * FROM Newmember ";
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];
            connect.Close();
        }
        private void pic_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (textBox_searchMember.Text != "")
            {
                connect.Open();
                command.CommandText =
                    "SELECT * FROM Newmember WHERE MID = " + Int32.Parse(textBox_searchMember.Text) + "";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView.DataSource = ds.Tables[0];
                connect.Close();
            }
            else
            {
                MessageBox.Show("Please Enter Valid Id", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
