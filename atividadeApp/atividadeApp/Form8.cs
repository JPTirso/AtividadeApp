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
    public partial class frmJogo : Form
    {
        public frmJogo()
        {
            InitializeComponent();
        }

        private void btnConverterJ_Click(object sender, EventArgs e)
        {
            double rendapop, rendageral, rendaarqui, rendac, pubt, rendat;
            pubt = Convert.ToDouble(txtPubt.Text);
            if (pubt > 0)
            {
                //calculamos a renda com o publico total * porcentagem de pessoas que compraram * custo do ingresso
                rendapop = pubt * 0.1 * 5;
                rendageral = pubt * 0.5 * 10;
                rendaarqui = pubt * 0.3 * 20;
                rendac = pubt * 0.1 * 30;
                rendat = rendapop + rendageral + rendaarqui + rendac;
                txtRendat.Text = rendat.ToString();

            }
            else
            {
                txtRendat.Text = "O valor colocado é invalido";
            }
        }

        private void btnLimparJ_Click(object sender, EventArgs e)
        {
            txtPubt.Text = "";
            txtRendat.Text = "";
        }

        private void btnVoltarJ_Click(object sender, EventArgs e)
        {
            Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }
    }
}
