using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaNorthwind
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

       

        private void AbrirFormaPersona(object Frm_Persona)
        {
            if(this.PanelContenedor.Controls.Count>0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }

            Form fPer = Frm_Persona as Form;
            fPer.TopLevel = false;
            fPer.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fPer);
            this.PanelContenedor.Tag = fPer;
            fPer.Show();


        }

        private void AbrirFormaEmployee(object Frm_Employee)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }

            Form fEmp = Frm_Employee as Form;
            fEmp.TopLevel = false;
            fEmp.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fEmp);
            this.PanelContenedor.Tag = fEmp;
            fEmp.Show();


        }

        private void AbrirFormaOrders(object Frm_Orders)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }

            Form fOrders = Frm_Orders as Form;
            fOrders.TopLevel = false;
            fOrders.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fOrders);
            this.PanelContenedor.Tag = fOrders;
            fOrders.Show();


        }

        private void AbrirFormaProducts(object Frm_Products)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }

            Form fProducts = Frm_Products as Form;
            fProducts.TopLevel = false;
            fProducts.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fProducts);
            this.PanelContenedor.Tag = fProducts;
            fProducts.Show();


        }

        private void AbrirFormaSuppliers(object Frm_Suppliers)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }

            Form fSuppliers = Frm_Suppliers as Form;
            fSuppliers.TopLevel = false;
            fSuppliers.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fSuppliers);
            this.PanelContenedor.Tag = fSuppliers;
            fSuppliers.Show();


        }

        private void AbrirFormaShippers(object Frm_Shippers)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }

            Form fShippers = Frm_Shippers as Form;
            fShippers.TopLevel = false;
            fShippers.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fShippers);
            this.PanelContenedor.Tag = fShippers;
            fShippers.Show();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormaPersona(new FormPersonal());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormaEmployee(new FormEmployee());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormaOrders(new FormOrders());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormaProducts(new FormProduct());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormaSuppliers(new FormSuppliers());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormaShippers(new FormShipper());

        }

        private void PanelContenedor_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
