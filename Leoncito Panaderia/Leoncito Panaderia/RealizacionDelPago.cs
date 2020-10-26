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
    public partial class RealizacionDelPago : Form
    {
        public DataTable Product = new DataTable();
        public decimal ResultadoFinal;
        public RealizacionDelPago()
        {
            InitializeComponent();
        }

        private void RealizacionDelPago_Load(object sender, EventArgs e)
        {
            dgvInformeDeCompra.DataSource = Product;
            lblTotal.Text = ResultadoFinal.ToString();
        }

        private void txtMontoCliente_MouseClick(object sender, MouseEventArgs e)
        {
            txtMontoCliente.Text = "";
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            decimal Vuelto = Convert.ToDecimal(txtMontoCliente.Text) - Convert.ToDecimal(lblTotal.Text);
            lblVuelto.Text = Vuelto.ToString();

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            NuevaVenta NV = new NuevaVenta();
            Product.Clear();
            this.Hide();
            NV.Show();
        }
    }
}
