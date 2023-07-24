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
using System.Data.Common;

namespace Personnel_Registration
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GA77R8Q;Initial Catalog=Personal_Database;Integrated Security=True");

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            conn.Open();

            // toplam personel sayısı
            SqlCommand command1 = new SqlCommand("Select Count (*) From Tbl_Personal",conn);
            SqlDataReader reader1 = command1.ExecuteReader();
            
            while(reader1.Read())
            {
                LblTotalPersonnel.Text = reader1[0].ToString();
            }

            conn.Close();           

            conn.Open();

            // Evli Personel Sayısı
            SqlCommand command2 = new SqlCommand("Select Count(*) From Tbl_Personal Where PerStatus=1",conn);
            SqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                LblMarriedPersonnel.Text = reader2[0].ToString();
            }

            conn.Close();

            conn.Open();

            // Bekar Personel Sayısı
            SqlCommand command3 = new SqlCommand("Select Count(*) From Tbl_Personal Where PerStatus=0", conn);
            SqlDataReader reader3 = command3.ExecuteReader();

            while (reader3.Read())
            {
                LblSinglePersonnel.Text = reader3[0].ToString();
            }

            conn.Close();

            conn.Open();

            // Bekar Personel Sayısı
            SqlCommand command4 = new SqlCommand("Select Count(distinct(PerCity)) From Tbl_Personal", conn);
            SqlDataReader reader4 = command4.ExecuteReader();

            while (reader4.Read())
            {
                LblNumberOfCities.Text = reader4[0].ToString();
            }

            conn.Close();

            conn.Open();

            // Toplam Maaş
            SqlCommand command5 = new SqlCommand("Select Sum(PerSalary)  From Tbl_Personal", conn);
            SqlDataReader reader5 = command5.ExecuteReader();

            while (reader5.Read())
            {
                LblTotalSalary.Text = reader5[0].ToString();
            }

            conn.Close();

            conn.Open();
            // Ortlama Maaş
            SqlCommand command6 = new SqlCommand("Select Avg(PerSalary)  From Tbl_Personal", conn);
            SqlDataReader reader6 = command6.ExecuteReader();

            while (reader6.Read())
            {
                LblAvgSalary.Text = reader6[0].ToString();
            }

            conn.Close();


        }
    }
}
