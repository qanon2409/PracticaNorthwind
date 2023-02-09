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


namespace PracticaNorthwind
{
    public partial class FormShipper : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Northwind;Integrated Security=True");

        public FormShipper()
        {
            InitializeComponent();
        }


        public void Disp_DataShipper()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM SHIPPERS";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void FormShipper_Load(object sender, EventArgs e)
        {

            Disp_DataShipper();

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.PhoneNum(e);
        }
    }
}
