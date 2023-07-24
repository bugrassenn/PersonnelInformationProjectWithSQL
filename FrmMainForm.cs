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
    public partial class FrmMainForm : Form
    {
        public FrmMainForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GA77R8Q;Initial Catalog=Personal_Database;Integrated Security=True");

        void clear()
        {
            TxtId.Text = "";
            TxtFirstName.Text = "";
            TxtLastName.Text = "";
            TxtJob.Text = "";
            MskSalary.Text = "";
            CmbCity.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            TxtFirstName.Focus();

        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

            // datagridwiev ile bize otomatik gelen kod satırı veritabanından çekip bize listeleme yapıyor.
            this.tbl_PersonalTableAdapter.Fill(this.personal_DatabaseDataSet.Tbl_Personal);

        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            // form1loaddan aldığımız kod otomatik geldi databaseden veri çekme 
            this.tbl_PersonalTableAdapter.Fill(this.personal_DatabaseDataSet.Tbl_Personal);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand command = new SqlCommand("insert into Tbl_Personal (PerFirstName,PerLastName,PerCity,PerSalary,PerJob, PerStatus) values (@p1,@p2,@p3,@p4,@p5,@p6)", conn);
            command.Parameters.AddWithValue("@p1", TxtFirstName.Text);
            command.Parameters.AddWithValue("@p2", TxtLastName.Text);
            command.Parameters.AddWithValue("@p3", CmbCity.Text);
            command.Parameters.AddWithValue("@p4", MskSalary.Text);
            command.Parameters.AddWithValue("@p5", TxtJob.Text);
            command.Parameters.AddWithValue("@p6", label8.Text);
            command.ExecuteNonQuery(); // sorguyu çalıştır.
            conn.Close();
            MessageBox.Show("Personnel Add");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if ( radioButton1.Checked == true )
            {
                label8.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int select = dataGridView1.SelectedCells[0].RowIndex; // select adlı değişkene atadık.

            TxtId.Text = dataGridView1.Rows[select].Cells[0].Value.ToString();
            TxtFirstName.Text = dataGridView1.Rows[select].Cells[1].Value.ToString();
            TxtLastName.Text = dataGridView1.Rows[select].Cells[2].Value.ToString();
            CmbCity.Text = dataGridView1.Rows[select].Cells[3].Value.ToString();
            MskSalary.Text = dataGridView1.Rows[select].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[select].Cells[5].Value.ToString();
            TxtJob.Text = dataGridView1.Rows[select].Cells[6].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if ( label8.Text == "True" )
            {
                radioButton1.Checked = true;
            }

            if ( label8.Text == "False" ) 
            { 
                radioButton2.Checked = true; 
            }  
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand commandDelete = new SqlCommand("Delete From Tbl_Personal Where Perid=@k1",conn);

            commandDelete.Parameters.AddWithValue("@k1",TxtId.Text);
            commandDelete.ExecuteNonQuery();        
            conn.Close();
            MessageBox.Show("Record deleted");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand commandUpdate = new SqlCommand("Update Tbl_Personal Set PerFirstName=@a1,PerLastName=@a2,PerCity=@a3,PerSalary=@a4,PerStatus=@a5,PerJob=@a6 where Perid=@a7",conn);
            commandUpdate.Parameters.AddWithValue("@a1",TxtFirstName.Text);
            commandUpdate.Parameters.AddWithValue("@a2",TxtLastName.Text);
            commandUpdate.Parameters.AddWithValue("@a3", CmbCity.Text);
            commandUpdate.Parameters.AddWithValue("@a4", MskSalary.Text);
            commandUpdate.Parameters.AddWithValue("@a5", label8.Text);
            commandUpdate.Parameters.AddWithValue("@a6", TxtJob.Text);
            commandUpdate.Parameters.AddWithValue("@a7", TxtId.Text);
            commandUpdate.ExecuteNonQuery();

            MessageBox.Show("Information Update");

            conn.Close();
        }

        private void BtnStatistics_Click(object sender, EventArgs e)
        {
            FrmStatistics fr = new FrmStatistics();
            fr.Show();
        }

        private void BtnGraphics_Click(object sender, EventArgs e)
        {
            FrmGraphics fr = new FrmGraphics();
            fr.Show();
        }
    }
}
