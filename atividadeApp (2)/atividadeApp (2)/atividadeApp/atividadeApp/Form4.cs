using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividadeApp
{
    public partial class frmDolar : Form
    {
        public frmDolar()
        {
            InitializeComponent();
        }

        private void lblDolar_Click(object sender, EventArgs e)
        {

        }

        private void btnConversorD_Click(object sender, EventArgs e)
        {
            double Real, Cambio, Dolar;
            Real = Convert.ToDouble(txtReal.Text);
            Cambio = Convert.ToDouble(txtCambio.Text);
            Dolar = Real / Cambio;
            txtDolar.Text = Dolar.ToString();
        }

        private void btnVoltarD_Click(object sender, EventArgs e)
        {
            Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }

        private void btnLimparD_Click(object sender, EventArgs e)
        {
            txtReal.Text = "";
            txtCambio.Text = "";
            txtDolar.Text = "";
        }
    }
}
