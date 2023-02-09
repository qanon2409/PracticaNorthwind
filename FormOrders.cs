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
    public partial class FormOrders : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Northwind;Integrated Security=True");

        public FormOrders()
        {
            InitializeComponent();
        }
        public void Disp_DataOrders()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT C.ContactName,CONCAT(E.FirstName,' ',E.LastName) Employee,O.OrderDate,P.ProductName,OD.Quantity,OD.UnitPrice,OD.Discount,O.RequiredDate,O.ShippedDate,S.CompanyName,O.ShipCity, O.ShipCountry,O.ShipName,O.ShipPostalCode,O.ShipRegion FROM Orders O JOIN[Order Details] OD ON O.OrderID = OD.OrderID JOIN Customers C ON C.CustomerID = O.CustomerID JOIN Employees E ON O.EmployeeID = E.EmployeeID JOIN Shippers S ON O.ShipVia = S.ShipperID JOIN Products P ON OD.ProductID = P.ProductID";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }

        
        private void FormOrders_Load(object sender, EventArgs e)
        {
            Disp_DataOrders();

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.NumberDecimal(e);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }
    }
}
