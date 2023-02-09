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
    public partial class FormEmployee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Northwind;Integrated Security=True");

        public FormEmployee()
        {
            InitializeComponent();
        }

        public void Disp_DataEmployees()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM EMPLOYEES";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        void ComboboxTit()
        {
            con.Open();

            SqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select distinct TitleOfCourtesy from Employees";
            SqlDataReader reader2 = cmd3.ExecuteReader();

            while (reader2.Read())   //loop reader and fill the combobox
            {
                comboBox2.Items.Add(reader2["TitleOfCourtesy"].ToString());
            }
            con.Close();
        }

        void ComboboxTit2()
        {
            con.Open();

            SqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select distinct [Title] from EMPLOYEES";
            SqlDataReader reader2 = cmd3.ExecuteReader();

            while (reader2.Read())   //loop reader and fill the combobox
            {
                comboBox1.Items.Add(reader2["TITLE"].ToString());
            }
            con.Close();
        }

        private void PhoneLenght()
        {
            
        }
        private void FormEmployee_Load(object sender, EventArgs e)
        {
            Disp_DataEmployees();
            ComboboxTit();
            ComboboxTit2();
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.PhoneNum(e);
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            
                if (txtPhone.TextLength == 10)
                {
                    txtPhone.ForeColor = Color.Black;
                }

                else
                {
                    txtPhone.ForeColor = Color.Red;

                }
                
            }

        private void txtExtension_TextChanged(object sender, EventArgs e)
        {
            //if (txtExtension.TextLength == 4)
            //{
            //    txtExtension.ForeColor = Color.Black;

            //}
            ////if (txtPhone.TextLength >= 10 || txtPhone.TextLength <= 10)
            ////{

            ////}

            //else
            //{
            //    txtExtension.ForeColor = Color.Red;

            //}
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //Validacion.PhoneNum(e);

        }

        private void txtExtension_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.PhoneNum(e);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);
        }
    }
}
