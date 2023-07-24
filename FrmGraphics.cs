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
    public partial class FrmGraphics : Form
    {
        public FrmGraphics()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GA77R8Q;Initial Catalog=Personal_Database;Integrated Security=True");

        private void FrmGraphics_Load(object sender, EventArgs e)
        {

            // Grafik - 1 Şehirler ve kişi sayısı
            conn.Open();

            SqlCommand commandg1 = new SqlCommand("Select PerCity,Count(*) From Tbl_Personal Group By PerCity",conn);
            SqlDataReader adapter = commandg1.ExecuteReader();

            while (adapter.Read() )
            {
                chart1.Series["Cities"].Points.AddXY(adapter[0], adapter[1]);
            }


            conn.Close();


            // Meslekler ve maaşlar

            conn.Open();

            SqlCommand commandg2 = new SqlCommand("Select PerJob,Avg(PerSalary) From Tbl_Personal Group By PerJob", conn);
            SqlDataReader adapter1 = commandg2.ExecuteReader();

            while (adapter1.Read())
            {
                chart2.Series["Job - Salary"].Points.AddXY(adapter1[0], adapter1[1]);
            }


            conn.Close();

        }
    }
}
