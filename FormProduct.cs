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
    public partial class FormProduct : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Northwind;Integrated Security=True");

        public FormProduct()
        {
            InitializeComponent();
        }

        public void Disp_DataProducts()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT P.ProductName,S.CompanyName,C.CategoryName,P.QuantityPerUnit,P.UnitPrice,P.UnitsInStock,P.UnitsOnOrder,P.ReorderLevel,P.Discontinued FROM Products P JOIN Categories C ON P.SupplierID = C.CategoryID JOIN Suppliers S ON P.SupplierID = S.SupplierID";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            Disp_DataProducts();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.NumberDecimal(e);
        }
    }
}
