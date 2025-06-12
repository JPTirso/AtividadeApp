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
    public partial class frmTemperatura : Form
    {
        public frmTemperatura()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCelsios.Text = "";
            txtFahrenheit.Text = "";
        }

        private void txtCelsios_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double C, F;
            C = Convert.ToDouble(txtCelsios.Text);
            F = (C * 1.8) + 32;
            txtFahrenheit.Text = F.ToString();
        }
    }
}
