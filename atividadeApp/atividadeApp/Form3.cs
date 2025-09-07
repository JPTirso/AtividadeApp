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
    public partial class frmVelocidade : Form
    {
        public frmVelocidade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmVelocidade_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltarV_Click(object sender, EventArgs e)
        {
            Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }

        private void btnLimparV_Click(object sender, EventArgs e)
        {
            txtTempo.Text = "";
            txtDistancia.Text = "";
            txtLitros.Text = "";
            txtVelocidade.Text = "";
        }

        private void btnConverterV_Click(object sender, EventArgs e)
        {
            double Tempo, Distancia, Litros, Velocidade;
            Tempo = Convert.ToDouble(txtTempo.Text);
            Velocidade = Convert.ToDouble(txtVelocidade.Text);
            Distancia = Tempo * Velocidade;
            Litros = Distancia / 12;
            txtLitros.Text = Litros.ToString();
            txtDistancia.Text = Distancia.ToString();

        }
    }
}
