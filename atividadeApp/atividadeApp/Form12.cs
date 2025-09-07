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
    public partial class frmCardapio : Form
    {
        public frmCardapio()
        {
            InitializeComponent();
        }

        private void btnConverterC_Click(object sender, EventArgs e)
        {
            int Codigo;
            Codigo = Convert.ToInt32(txtCodigo.Text);

            switch (Codigo)
            {
                case 100:
                    txtLanche.Text = "Cachorro Quente - R$ 25,00";
                    break;
                case 101:
                    txtLanche.Text = "Bauru - R$ 15,00";
                    break;
                case 102:
                    txtLanche.Text = "X-Burguer - R$ 35,00";
                    break;
                case 103:
                    txtLanche.Text = "Triplo X-Burguer - R$ 45,00";
                    break;
                default:
                    txtLanche.Text = "Código inválido! Tente novamente.";
                    break;
            }
        }

        private void btnLimparC_Click(object sender, EventArgs e)
        {
            txtLanche.Text = "";
            txtCodigo.Text = "";
        }

        private void btnVoltarC_Click(object sender, EventArgs e)
        {
            Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }
    }
}




