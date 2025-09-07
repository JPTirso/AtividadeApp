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
    public partial class frmCirculo : Form
    {
        public frmCirculo()
        {
            InitializeComponent();
        }

        private void btnVoltarC_Click(object sender, EventArgs e)
        {
            Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }

        private void btnLimparC_Click(object sender, EventArgs e)
        {
            txtRaio.Text = "";
            txtArea.Text = "";

        }

        private void btnConversorC_Click(object sender, EventArgs e)
        {
            double Raio, Area;
            Raio = Convert.ToDouble(txtRaio.Text);
            Area = Math.Pow(Raio, 2) * Math.PI;
            txtArea.Text = Area.ToString();
        }
    }
}
