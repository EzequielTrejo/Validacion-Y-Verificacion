using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leoncito_Panaderia
{
    public partial class NuevaVenta : Form
    {
        DataTable ProductosVendidos = new DataTable();
        DataTable TablaFinal = new DataTable();
        public NuevaVenta()
        {
            InitializeComponent();
        }

        private void NuevaVenta_Load(object sender, EventArgs e)
        {
            ProductosVendidos.Columns.Add("Codigo", typeof(string));
            ProductosVendidos.Columns.Add("Cantidad", typeof(int));
            ProductosVendidos.Columns.Add("Descripcion", typeof(string));
            ProductosVendidos.Columns.Add("PrecioUnitario", typeof(decimal));
            ProductosVendidos.Columns.Add("Total", typeof(decimal));
            //preguntar al profesor por ultimas tres columnas
        }

        public void btnAgregar_Click(object sender, EventArgs e)
        {
            Funciones.Verificacion Ver = new Funciones.Verificacion();
            if(Ver.Validate(Convert.ToInt32(txtCantidad.Text)) == true)
            {
                TablaFinal = TablaProductosVendidos();
            }
        }

        public DataTable TablaProductosVendidos()
        {

            if(ProductosVendidos.Columns.Count == 0)
            {
                ProductosVendidos.Columns.Add("Codigo", typeof(string));
                ProductosVendidos.Columns.Add("Cantidad", typeof(int));
                ProductosVendidos.Columns.Add("Descripcion", typeof(string));
                ProductosVendidos.Columns.Add("PrecioUnitario", typeof(decimal));
                return ProductosVendidos;
            }
            else
            {
                Funciones.Cuentas Cuentas = new Funciones.Cuentas();
                Random Random = new Random();
                decimal Precio;
                decimal Total;
                Precio = Random.Next(1, 50000);
                Total = Cuentas.Suma(Convert.ToInt32(txtCantidad.Text), Precio);
                DataRow NR = ProductosVendidos.NewRow();
                NR["Codigo"] = txtCodProd.Text;
                NR["Cantidad"] = txtCantidad.Text;
                NR["Descripcion"] = "No Dísponible";
                NR["PrecioUnitario"] = Precio;
                ProductosVendidos.Rows.Add(NR);
                return ProductosVendidos;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Text = "";
            txtCodProd.Text = "";
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            RealizacionDelPago RDP = new RealizacionDelPago();
            RDP.Product = TablaFinal;
            this.Hide();
            RDP.Show();
        }

    }
}
