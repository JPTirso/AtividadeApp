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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        private void frmNotas_Load(object sender, EventArgs e)
        {

        }

        private void btnConverterN_Click(object sender, EventArgs e)
        {
            double nt1, nt2, nt3, median;
            nt1 = Convert.ToDouble(txtNota1.Text);
            nt2 = Convert.ToDouble(txtNota2.Text);
            nt3 = Convert.ToDouble(txtNota3.Text);
            median = (nt1 * 2) + (nt2 * 3) + (nt3 * 5) / 10;
            txtMediaN.Text = median.ToString();
        }

        private void btnVoltarN_Click(object sender, EventArgs e)
        {
            Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }

        private void btnLimparN_Click(object sender, EventArgs e)
        {
            txtMediaN.Text = "";
            txtNota1.Text = ""; 
            txtNota2.Text = "";
            txtNota3.Text = "";

        }
    }
}
