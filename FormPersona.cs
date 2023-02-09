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
    public partial class FormPersonal : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
        public FormPersonal()
        {
            InitializeComponent();
        }

        public void Disp_DataCustomers()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM CUSTOMERS";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        void Fillcombobox()
        {

            con.Open();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "SELECT DISTINCT CompanyName FROM CUSTOMERS";
            SqlDataReader reader = cmd2.ExecuteReader();

            while (reader.Read())   //loop reader and fill the combobox
            {
                comboBox1.Items.Add(reader["CompanyName"].ToString());
            }
            con.Close();


        }

        void Combobox2()
        {
            con.Open();

            SqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select distinct [ContactTitle] from Customers";
            SqlDataReader reader2 = cmd3.ExecuteReader();

            while (reader2.Read())   //loop reader and fill the combobox
            {
                comboBox2.Items.Add(reader2["CONTACTTITLE"].ToString());
            }
            con.Close();
        }

        void Combobox3()
        {
            con.Open();

            SqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select [RegionDescription] from Region";
            SqlDataReader reader2 = cmd3.ExecuteReader();

            while (reader2.Read())   //loop reader and fill the combobox
            {
                comboBox3.Items.Add(reader2["RegionDescription"].ToString());
            }
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Disp_DataCustomers();
            Fillcombobox();
            Combobox2();
            Combobox3();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.PhoneNum(e);
        }
    }
}
