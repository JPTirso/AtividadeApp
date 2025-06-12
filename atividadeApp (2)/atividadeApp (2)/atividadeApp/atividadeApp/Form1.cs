namespace atividadeApp
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void programasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mtsiTemperatura_Click(object sender, EventArgs e)
        {
            Hide();
            frmTemperatura temperatura = new frmTemperatura();
            temperatura.Show();
        }

        private void mtsSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mtsiVelocidade_Click(object sender, EventArgs e)
        {
            Hide();
            frmVelocidade velocidade = new frmVelocidade();
            velocidade.Show();
        }

        private void realParaDolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmDolar dolar = new frmDolar();
            dolar.Show();
        }

        private void quadradoDaSomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmPotencia potencia = new frmPotencia();
            potencia.Show();
        }

        private void areaDaCircunferenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmCirculo circulo = new frmCirculo();
            circulo.Show();
        }

        private void m�diaDasNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmNotas notas = new frmNotas();
            notas.Show();
        }
    }
}
