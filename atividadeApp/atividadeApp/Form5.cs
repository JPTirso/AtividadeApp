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
    public partial class frmPotencia : Form
    {
        public frmPotencia()
        {
            InitializeComponent();
        }

        private void btnVoltarP_Click(object sender, EventArgs e)
        {
            Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }

        private void btnLimparP_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtNum3.Text = "";
            txtPotencia.Text = "";
        }

        private void btnConverterP_Click(object sender, EventArgs e)
        {
            double Num1, Num2, Num3, Potencia;
            Num1 = Convert.ToDouble(txtNum1.Text);
            Num2 = Convert.ToDouble(txtNum2.Text);
            Num3 = Convert.ToDouble(txtNum3.Text);
            Potencia = Math.Pow(Num1 + Num2 + Num3, 2);
            txtPotencia.Text = Potencia.ToString();
        }
    }
}
