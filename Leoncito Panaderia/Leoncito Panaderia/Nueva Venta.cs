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
        Funciones.Cuentas Cuentas = new Funciones.Cuentas();
        DataTable ProductosVendidos = new DataTable();
        DataTable TablaFinal = new DataTable();
        decimal SumaTotal;
        decimal Total;
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
        }

        public void btnAgregar_Click(object sender, EventArgs e)
        {
            Funciones.Verificacion Ver = new Funciones.Verificacion();
            if(Ver.Validate(Convert.ToInt32(txtCantidad.Text)) == true)
            {
                TablaFinal = TablaProductosVendidos();
                txtSumaTotal.Text = Total.ToString();
            }
            Limpiar();
        }

        public DataTable TablaProductosVendidos()
        {

            if(ProductosVendidos.Columns.Count == 0)
            {
                ProductosVendidos.Columns.Add("Codigo", typeof(string));
                ProductosVendidos.Columns.Add("Cantidad", typeof(int));
                ProductosVendidos.Columns.Add("Descripcion", typeof(string));
                ProductosVendidos.Columns.Add("PrecioUnitario", typeof(decimal));
                ProductosVendidos.Columns.Add("Total", typeof(decimal));
                return ProductosVendidos;
            }
            else
            {
                Total = Cuentas.Suma(Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtPrecioUnitario.Text));
                DataRow NR = ProductosVendidos.NewRow();
                NR["Codigo"] = txtCodProd.Text;
                NR["Cantidad"] = txtCantidad.Text;
                NR["Descripcion"] = txtDescripcion.Text;
                NR["PrecioUnitario"] = Convert.ToInt32(txtPrecioUnitario.Text);
                NR["Total"] = Total;
                ProductosVendidos.Rows.Add(NR);
                return ProductosVendidos;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            txtCantidad.Text = "";
            txtCodProd.Text = "";
            txtDescripcion.Text = "";
            txtPrecioUnitario.Text = "";
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            RealizacionDelPago RDP = new RealizacionDelPago();
            SumaTotal = Cuentas.ResultadoFinal(ProductosVendidos);
            RDP.Product = TablaFinal;
            RDP.ResultadoFinal = SumaTotal;
            this.Hide();
            RDP.Show();
        }

        private void txtCodProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(KeyPress e.KeyChar = )
            {

            }
        }
    }
}
