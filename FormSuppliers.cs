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
    public partial class FormSuppliers : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Northwind;Integrated Security=True");

        public FormSuppliers()
        {
            InitializeComponent();
        }
        public void Disp_DataSuppliers()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM SUPPLIERS";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void FormSuppliers_Load(object sender, EventArgs e)
        {
            Disp_DataSuppliers();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.PhoneNum(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validacion.HomePage(e);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (Uri.IsWellFormedUriString(textBox7.Text, UriKind.Absolute))
            {
                textBox7.ForeColor = Color.Black;
            }
            else
            {
                textBox7.ForeColor = Color.Red;

            }
        }
    }
}
