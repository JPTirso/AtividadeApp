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
            mtsSair = new ToolStripMenuItem();
            médiaDasNotasToolStripMenuItem = new ToolStripMenuItem();
            mtsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // mtsMenu
            // 
            mtsMenu.ImageScalingSize = new Size(20, 20);
            mtsMenu.Items.AddRange(new ToolStripItem[] { mtsProgramas, mtsSair });
            mtsMenu.Location = new Point(0, 0);
            mtsMenu.Name = "mtsMenu";
            mtsMenu.Size = new Size(800, 24);
            mtsMenu.TabIndex = 0;
            mtsMenu.Text = "menuStrip1";
            // 
            // mtsProgramas
            // 
            mtsProgramas.DropDownItems.AddRange(new ToolStripItem[] { mtsiTemperatura, mtsiVelocidade, realParaDolarToolStripMenuItem, quadradoDaSomaToolStripMenuItem, areaDaCircunferenciaToolStripMenuItem, médiaDasNotasToolStripMenuItem });
            mtsProgramas.Name = "mtsProgramas";
            mtsProgramas.Size = new Size(76, 20);
            mtsProgramas.Text = "Programas";
            mtsProgramas.Click += programasToolStripMenuItem_Click;
            // 
            // mtsiTemperatura
            // 
            mtsiTemperatura.Name = "mtsiTemperatura";
            mtsiTemperatura.Size = new Size(212, 22);
            mtsiTemperatura.Text = "Conversor de temperatura";
            mtsiTemperatura.Click += mtsiTemperatura_Click;
            // 
            // mtsiVelocidade
            // 
            mtsiVelocidade.Name = "mtsiVelocidade";
            mtsiVelocidade.Size = new Size(212, 22);
            mtsiVelocidade.Text = "Velocidade Média";
            mtsiVelocidade.Click += mtsiVelocidade_Click;
            // 
            // realParaDolarToolStripMenuItem
            // 
            realParaDolarToolStripMenuItem.Name = "realParaDolarToolStripMenuItem";
            realParaDolarToolStripMenuItem.Size = new Size(212, 22);
            realParaDolarToolStripMenuItem.Text = "Real para Dolar";
            realParaDolarToolStripMenuItem.Click += realParaDolarToolStripMenuItem_Click;
            // 
            // quadradoDaSomaToolStripMenuItem
            // 
            quadradoDaSomaToolStripMenuItem.Name = "quadradoDaSomaToolStripMenuItem";
            quadradoDaSomaToolStripMenuItem.Size = new Size(212, 22);
            quadradoDaSomaToolStripMenuItem.Text = "Quadrado da Soma";
            quadradoDaSomaToolStripMenuItem.Click += quadradoDaSomaToolStripMenuItem_Click;
            // 
            // areaDaCircunferenciaToolStripMenuItem
            // 
            areaDaCircunferenciaToolStripMenuItem.Name = "areaDaCircunferenciaToolStripMenuItem";
            areaDaCircunferenciaToolStripMenuItem.Size = new Size(212, 22);
            areaDaCircunferenciaToolStripMenuItem.Text = "Area da Circunferencia";
            areaDaCircunferenciaToolStripMenuItem.Click += areaDaCircunferenciaToolStripMenuItem_Click;
            // 
            // mtsSair
            // 
            mtsSair.Name = "mtsSair";
            mtsSair.Size = new Size(38, 20);
            mtsSair.Text = "Sair";
            mtsSair.Click += mtsSair_Click;
            // 
            // médiaDasNotasToolStripMenuItem
            // 
            médiaDasNotasToolStripMenuItem.Name = "médiaDasNotasToolStripMenuItem";
            médiaDasNotasToolStripMenuItem.Size = new Size(212, 22);
            médiaDasNotasToolStripMenuItem.Text = "Média das notas";
            médiaDasNotasToolStripMenuItem.Click += médiaDasNotasToolStripMenuItem_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mtsMenu);
            MainMenuStrip = mtsMenu;
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
    }
}
