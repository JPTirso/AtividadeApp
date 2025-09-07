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
    public partial class frmSN : Form
    {
        public frmSN()
        {
            InitializeComponent();
        }
        double st;
        private void btnConverterSN_Click(object sender, EventArgs e)
        {
            double idade, sf;
            string nome, sexo;
            idade = Convert.ToDouble(txtIdade.Text);
            sf = Convert.ToDouble(txtSF.Text);
            sexo = txtSexo.Text;
            nome = txtNome.Text;
            if (sexo.Equals("M") || sexo.Equals("m") && idade >= 30)
            {
                st = sf + 100;
            }
            else if (sexo.Equals("M") || sexo.Equals("m") && idade < 30)
            {
                st = sf + 30;
            }
            else if (sexo.Equals("F") || sexo.Equals("f") && idade >= 30)
            {
                st = sf + 200;
            }
            else if (sexo.Equals("F") || sexo.Equals("f") && idade < 30)
            {
                st = sf + 150;
            }

            txtMensagem.Text = "Parebens, " + nome + " seu novo salario é de " + st.ToString();
        }

        private void btnLimparSN_Click(object sender, EventArgs e)
        {
            txtIdade.Text = "";
            txtMensagem.Text = "";
            txtNome.Text = "";
            txtSF.Text = "";
            txtSexo.Text = "";

        }

        private void btnVoltarSN_Click(object sender, EventArgs e)
        {
            Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }
    }
}
