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
    public partial class frmImc : Form
    {
        public frmImc()
        {
            InitializeComponent();
        }

        private void btnConversorImc_Click(object sender, EventArgs e)
        {
            double Altura, Peso, IMC;

            Altura = Convert.ToDouble(txtAltura.Text);
            Peso = Convert.ToDouble(txtPeso.Text);
            IMC = Peso / Altura * Altura;

            if (IMC < 17)
            {
                txtImc.Text = "Magreza Severa";
            }
            else if (IMC >= 17 && IMC < 18.5)
            {
                txtImc.Text = "Magreza Leve";
            }

            else if (IMC >= 18.5 && IMC < 25)
            {
                txtImc.Text = "Peso Normal";
            }

            else if (IMC >= 25 && IMC < 30)
            {
                txtImc.Text = "Sobrepeso";
            }


        }

        private void btnLimparImc_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtPeso.Text = "";
            txtImc.Text = "";
        }

        private void btnVoltarImc_Click(object sender, EventArgs e)
        {
            Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }
    }
}
