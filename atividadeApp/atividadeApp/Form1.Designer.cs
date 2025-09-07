namespace atividadeApp
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mtsMenu = new MenuStrip();
            mtsProgramas = new ToolStripMenuItem();
            mtsiTemperatura = new ToolStripMenuItem();
            mtsiVelocidade = new ToolStripMenuItem();
            realParaDolarToolStripMenuItem = new ToolStripMenuItem();
            quadradoDaSomaToolStripMenuItem = new ToolStripMenuItem();
            areaDaCircunferenciaToolStripMenuItem = new ToolStripMenuItem();
            médiaDasNotasToolStripMenuItem = new ToolStripMenuItem();
            rendaDeUmJogoToolStripMenuItem = new ToolStripMenuItem();
            preçoDeLivrosToolStripMenuItem = new ToolStripMenuItem();
            novoSalarioToolStripMenuItem = new ToolStripMenuItem();
            mtsSair = new ToolStripMenuItem();
            calculadoraDeIMCToolStripMenuItem = new ToolStripMenuItem();
            mtsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // mtsMenu
            // 
            mtsMenu.ImageScalingSize = new Size(20, 20);
            mtsMenu.Items.AddRange(new ToolStripItem[] { mtsProgramas, mtsSair });
            mtsMenu.Location = new Point(0, 0);
            mtsMenu.Name = "mtsMenu";
            mtsMenu.Padding = new Padding(7, 3, 0, 3);
            mtsMenu.Size = new Size(914, 30);
            mtsMenu.TabIndex = 0;
            mtsMenu.Text = "menuStrip1";
            // 
            // mtsProgramas
            // 
            mtsProgramas.DropDownItems.AddRange(new ToolStripItem[] { mtsiTemperatura, mtsiVelocidade, realParaDolarToolStripMenuItem, quadradoDaSomaToolStripMenuItem, areaDaCircunferenciaToolStripMenuItem, médiaDasNotasToolStripMenuItem, rendaDeUmJogoToolStripMenuItem, preçoDeLivrosToolStripMenuItem, novoSalarioToolStripMenuItem, calculadoraDeIMCToolStripMenuItem });
            mtsProgramas.Name = "mtsProgramas";
            mtsProgramas.Size = new Size(94, 24);
            mtsProgramas.Text = "Programas";
            mtsProgramas.Click += programasToolStripMenuItem_Click;
            // 
            // mtsiTemperatura
            // 
            mtsiTemperatura.Name = "mtsiTemperatura";
            mtsiTemperatura.Size = new Size(265, 26);
            mtsiTemperatura.Text = "Conversor de temperatura";
            mtsiTemperatura.Click += mtsiTemperatura_Click;
            // 
            // mtsiVelocidade
            // 
            mtsiVelocidade.Name = "mtsiVelocidade";
            mtsiVelocidade.Size = new Size(265, 26);
            mtsiVelocidade.Text = "Velocidade Média";
            mtsiVelocidade.Click += mtsiVelocidade_Click;
            // 
            // realParaDolarToolStripMenuItem
            // 
            realParaDolarToolStripMenuItem.Name = "realParaDolarToolStripMenuItem";
            realParaDolarToolStripMenuItem.Size = new Size(265, 26);
            realParaDolarToolStripMenuItem.Text = "Real para Dolar";
            realParaDolarToolStripMenuItem.Click += realParaDolarToolStripMenuItem_Click;
            // 
            // quadradoDaSomaToolStripMenuItem
            // 
            quadradoDaSomaToolStripMenuItem.Name = "quadradoDaSomaToolStripMenuItem";
            quadradoDaSomaToolStripMenuItem.Size = new Size(265, 26);
            quadradoDaSomaToolStripMenuItem.Text = "Quadrado da Soma";
            quadradoDaSomaToolStripMenuItem.Click += quadradoDaSomaToolStripMenuItem_Click;
            // 
            // areaDaCircunferenciaToolStripMenuItem
            // 
            areaDaCircunferenciaToolStripMenuItem.Name = "areaDaCircunferenciaToolStripMenuItem";
            areaDaCircunferenciaToolStripMenuItem.Size = new Size(265, 26);
            areaDaCircunferenciaToolStripMenuItem.Text = "Area da Circunferencia";
            areaDaCircunferenciaToolStripMenuItem.Click += areaDaCircunferenciaToolStripMenuItem_Click;
            // 
            // médiaDasNotasToolStripMenuItem
            // 
            médiaDasNotasToolStripMenuItem.Name = "médiaDasNotasToolStripMenuItem";
            médiaDasNotasToolStripMenuItem.Size = new Size(265, 26);
            médiaDasNotasToolStripMenuItem.Text = "Média das notas";
            médiaDasNotasToolStripMenuItem.Click += médiaDasNotasToolStripMenuItem_Click;
            // 
            // rendaDeUmJogoToolStripMenuItem
            // 
            rendaDeUmJogoToolStripMenuItem.Name = "rendaDeUmJogoToolStripMenuItem";
            rendaDeUmJogoToolStripMenuItem.Size = new Size(265, 26);
            rendaDeUmJogoToolStripMenuItem.Text = "Renda de um jogo";
            rendaDeUmJogoToolStripMenuItem.Click += rendaDeUmJogoToolStripMenuItem_Click;
            // 
            // preçoDeLivrosToolStripMenuItem
            // 
            preçoDeLivrosToolStripMenuItem.Name = "preçoDeLivrosToolStripMenuItem";
            preçoDeLivrosToolStripMenuItem.Size = new Size(265, 26);
            preçoDeLivrosToolStripMenuItem.Text = "Preço de livros";
            preçoDeLivrosToolStripMenuItem.Click += preçoDeLivrosToolStripMenuItem_Click;
            // 
            // novoSalarioToolStripMenuItem
            // 
            novoSalarioToolStripMenuItem.Name = "novoSalarioToolStripMenuItem";
            novoSalarioToolStripMenuItem.Size = new Size(265, 26);
            novoSalarioToolStripMenuItem.Text = "Novo salario";
            novoSalarioToolStripMenuItem.Click += novoSalarioToolStripMenuItem_Click;
            // 
            // mtsSair
            // 
            mtsSair.Name = "mtsSair";
            mtsSair.Size = new Size(48, 24);
            mtsSair.Text = "Sair";
            mtsSair.Click += mtsSair_Click;
            // 
            // calculadoraDeIMCToolStripMenuItem
            // 
            calculadoraDeIMCToolStripMenuItem.Name = "calculadoraDeIMCToolStripMenuItem";
            calculadoraDeIMCToolStripMenuItem.Size = new Size(265, 26);
            calculadoraDeIMCToolStripMenuItem.Text = "Calculadora de IMC";
            calculadoraDeIMCToolStripMenuItem.Click += calculadoraDeIMCToolStripMenuItem_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(mtsMenu);
            MainMenuStrip = mtsMenu;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            mtsMenu.ResumeLayout(false);
            mtsMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mtsMenu;
        private ToolStripMenuItem mtsProgramas;
        private ToolStripMenuItem mtsSair;
        private ToolStripMenuItem mtsiTemperatura;
        private ToolStripMenuItem mtsiVelocidade;
        private ToolStripMenuItem realParaDolarToolStripMenuItem;
        private ToolStripMenuItem quadradoDaSomaToolStripMenuItem;
        private ToolStripMenuItem areaDaCircunferenciaToolStripMenuItem;
        private ToolStripMenuItem médiaDasNotasToolStripMenuItem;
        private ToolStripMenuItem rendaDeUmJogoToolStripMenuItem;
        private ToolStripMenuItem preçoDeLivrosToolStripMenuItem;
        private ToolStripMenuItem novoSalarioToolStripMenuItem;
        private ToolStripMenuItem calculadoraDeIMCToolStripMenuItem;
    }
}
