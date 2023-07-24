using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personnel_Registration
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GA77R8Q;Initial Catalog=Personal_Database;Integrated Security=True");
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand command = new SqlCommand("Select * From Tbl_Admin where UserName=@p1 and Password=@p2", conn);
            command.Parameters.AddWithValue("@p1",TxtUserName.Text);
            command.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader reader = command.ExecuteReader();


            if  ( reader.Read() )
            {
                FrmMainForm frm = new FrmMainForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password!");
            }


            conn.Close();
        }
    }
}
