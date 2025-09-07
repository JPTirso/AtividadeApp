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
    public partial class frmLivros : Form
    {
        public frmLivros()
        {
            InitializeComponent();
        }

        private void btnConverterL_Click(object sender, EventArgs e)
        {
            Double Qnt, Valort;
            Qnt = Convert.ToDouble(txtLivros.Text);
            if (Qnt <= 10)
            {
                Valort = Qnt * 12;
            }
            else
            {
                Valort = Qnt * 8;
            }
            txtPreco.Text = Convert.ToString(Valort);
        }

        private void btnLimparL_Click(object sender, EventArgs e)
        {
            txtLivros.Text = "";
            txtPreco.Text = "";
        }

        private void btnVoltarL_Click(object sender, EventArgs e)
        {
            Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }
    }
}
