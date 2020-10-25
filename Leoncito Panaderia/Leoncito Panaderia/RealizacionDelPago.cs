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
        public RealizacionDelPago()
        {
            InitializeComponent();
        }

        private void RealizacionDelPago_Load(object sender, EventArgs e)
        {
            dgvInformeDeCompra.DataSource = Product;
        }
    }
}
