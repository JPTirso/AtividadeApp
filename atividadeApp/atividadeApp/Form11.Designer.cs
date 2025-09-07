namespace atividadeApp
{
    partial class frmImc
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
            txtImc = new TextBox();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            btnVoltarImc = new Button();
            btnLimparImc = new Button();
            btnConversorImc = new Button();
            lblImc = new Label();
            lblPeso = new Label();
            lblAltura = new Label();
            SuspendLayout();
            // 
            // txtImc
            // 
            txtImc.Location = new Point(571, 274);
            txtImc.Name = "txtImc";
            txtImc.ReadOnly = true;
            txtImc.Size = new Size(125, 27);
            txtImc.TabIndex = 17;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(571, 172);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(125, 27);
            txtPeso.TabIndex = 16;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(571, 70);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(125, 27);
            txtAltura.TabIndex = 15;
            // 
            // btnVoltarImc
            // 
            btnVoltarImc.Location = new Point(656, 469);
            btnVoltarImc.Name = "btnVoltarImc";
            btnVoltarImc.Size = new Size(145, 61);
            btnVoltarImc.TabIndex = 14;
            btnVoltarImc.Text = "Voltar";
            btnVoltarImc.UseVisualStyleBackColor = true;
            btnVoltarImc.Click += btnVoltarImc_Click;
            // 
            // btnLimparImc
            // 
            btnLimparImc.Location = new Point(385, 469);
            btnLimparImc.Name = "btnLimparImc";
            btnLimparImc.Size = new Size(145, 61);
            btnLimparImc.TabIndex = 13;
            btnLimparImc.Text = "Limpar";
            btnLimparImc.UseVisualStyleBackColor = true;
            btnLimparImc.Click += btnLimparImc_Click;
            // 
            // btnConversorImc
            // 
            btnConversorImc.Location = new Point(114, 469);
            btnConversorImc.Name = "btnConversorImc";
            btnConversorImc.Size = new Size(145, 61);
            btnConversorImc.TabIndex = 12;
            btnConversorImc.Text = "Converter";
            btnConversorImc.UseVisualStyleBackColor = true;
            btnConversorImc.Click += btnConversorImc_Click;
            // 
            // lblImc
            // 
            lblImc.AutoSize = true;
            lblImc.Location = new Point(114, 281);
            lblImc.Name = "lblImc";
            lblImc.Size = new Size(188, 20);
            lblImc.TabIndex = 11;
            lblImc.Text = "A quantidade de dolares é:";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(114, 179);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(253, 20);
            lblPeso.TabIndex = 10;
            lblPeso.Text = "Quanto esta o cambio do dolar hoje:";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(114, 77);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(215, 20);
            lblAltura.TabIndex = 9;
            lblAltura.Text = "Quantos reais deseja converter:";
            // 
            // frmImc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(txtImc);
            Controls.Add(txtPeso);
            Controls.Add(txtAltura);
            Controls.Add(btnVoltarImc);
            Controls.Add(btnLimparImc);
            Controls.Add(btnConversorImc);
            Controls.Add(lblImc);
            Controls.Add(lblPeso);
            Controls.Add(lblAltura);
            Name = "frmImc";
            Text = "Calculadora de IMC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtImc;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Button btnVoltarImc;
        private Button btnLimparImc;
        private Button btnConversorImc;
        private Label lblImc;
        private Label lblPeso;
        private Label lblAltura;
    }
}