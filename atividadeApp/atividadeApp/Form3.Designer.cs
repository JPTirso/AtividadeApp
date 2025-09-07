namespace atividadeApp
{
    partial class frmVelocidade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnVoltarV = new Button();
            btnLimparV = new Button();
            btnConverterV = new Button();
            txtTempo = new TextBox();
            lblVelocidade = new Label();
            lblTempo = new Label();
            lblDistancia = new Label();
            lblLitro = new Label();
            txtVelocidade = new TextBox();
            txtLitros = new TextBox();
            txtDistancia = new TextBox();
            SuspendLayout();
            // 
            // btnVoltarV
            // 
            btnVoltarV.Location = new Point(628, 476);
            btnVoltarV.Margin = new Padding(3, 4, 3, 4);
            btnVoltarV.Name = "btnVoltarV";
            btnVoltarV.Size = new Size(145, 61);
            btnVoltarV.TabIndex = 0;
            btnVoltarV.Text = "Voltar";
            btnVoltarV.UseVisualStyleBackColor = true;
            btnVoltarV.Click += btnVoltarV_Click;
            // 
            // btnLimparV
            // 
            btnLimparV.Location = new Point(357, 476);
            btnLimparV.Margin = new Padding(3, 4, 3, 4);
            btnLimparV.Name = "btnLimparV";
            btnLimparV.Size = new Size(145, 61);
            btnLimparV.TabIndex = 1;
            btnLimparV.Text = "Limpar";
            btnLimparV.UseVisualStyleBackColor = true;
            btnLimparV.Click += btnLimparV_Click;
            // 
            // btnConverterV
            // 
            btnConverterV.Location = new Point(86, 476);
            btnConverterV.Margin = new Padding(3, 4, 3, 4);
            btnConverterV.Name = "btnConverterV";
            btnConverterV.Size = new Size(145, 61);
            btnConverterV.TabIndex = 2;
            btnConverterV.Text = "Converter";
            btnConverterV.UseVisualStyleBackColor = true;
            btnConverterV.Click += btnConverterV_Click;
            // 
            // txtTempo
            // 
            txtTempo.Location = new Point(543, 77);
            txtTempo.Margin = new Padding(3, 4, 3, 4);
            txtTempo.Name = "txtTempo";
            txtTempo.Size = new Size(114, 27);
            txtTempo.TabIndex = 3;
            // 
            // lblVelocidade
            // 
            lblVelocidade.AutoSize = true;
            lblVelocidade.Location = new Point(86, 186);
            lblVelocidade.Name = "lblVelocidade";
            lblVelocidade.Size = new Size(188, 20);
            lblVelocidade.TabIndex = 4;
            lblVelocidade.Text = "Digite a velocidade média:";
            // 
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.Location = new Point(86, 84);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(228, 20);
            lblTempo.TabIndex = 5;
            lblTempo.Text = "Digite o tempo gasto na viagem:";
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Location = new Point(86, 288);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(147, 20);
            lblDistancia.TabIndex = 6;
            lblDistancia.Text = "Distancia da viagem:";
            // 
            // lblLitro
            // 
            lblLitro.AutoSize = true;
            lblLitro.Location = new Point(86, 400);
            lblLitro.Name = "lblLitro";
            lblLitro.Size = new Size(193, 20);
            lblLitro.TabIndex = 7;
            lblLitro.Text = "Litros ultilizados na viagem:";
            // 
            // txtVelocidade
            // 
            txtVelocidade.Location = new Point(543, 179);
            txtVelocidade.Margin = new Padding(3, 4, 3, 4);
            txtVelocidade.Name = "txtVelocidade";
            txtVelocidade.Size = new Size(114, 27);
            txtVelocidade.TabIndex = 8;
            // 
            // txtLitros
            // 
            txtLitros.Location = new Point(543, 393);
            txtLitros.Margin = new Padding(3, 4, 3, 4);
            txtLitros.Name = "txtLitros";
            txtLitros.ReadOnly = true;
            txtLitros.Size = new Size(114, 27);
            txtLitros.TabIndex = 9;
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(543, 281);
            txtDistancia.Margin = new Padding(3, 4, 3, 4);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.ReadOnly = true;
            txtDistancia.Size = new Size(114, 27);
            txtDistancia.TabIndex = 10;
            // 
            // frmVelocidade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(txtDistancia);
            Controls.Add(txtLitros);
            Controls.Add(txtVelocidade);
            Controls.Add(lblLitro);
            Controls.Add(lblDistancia);
            Controls.Add(lblTempo);
            Controls.Add(lblVelocidade);
            Controls.Add(txtTempo);
            Controls.Add(btnConverterV);
            Controls.Add(btnLimparV);
            Controls.Add(btnVoltarV);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmVelocidade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Velocidade";
            Load += frmVelocidade_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltarV;
        private Button btnLimparV;
        private Button btnConverterV;
        private TextBox txtTempo;
        private Label lblVelocidade;
        private Label lblTempo;
        private Label lblDistancia;
        private Label lblLitro;
        private TextBox txtVelocidade;
        private TextBox txtLitros;
        private TextBox txtDistancia;
    }
}