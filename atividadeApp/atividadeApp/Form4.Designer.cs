namespace atividadeApp
{
    partial class frmDolar
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
            lblReal = new Label();
            lblCambio = new Label();
            lblDolar = new Label();
            btnConversorD = new Button();
            btnLimparD = new Button();
            btnVoltarD = new Button();
            txtReal = new TextBox();
            txtCambio = new TextBox();
            txtDolar = new TextBox();
            SuspendLayout();
            // 
            // lblReal
            // 
            lblReal.AutoSize = true;
            lblReal.Location = new Point(86, 84);
            lblReal.Name = "lblReal";
            lblReal.Size = new Size(215, 20);
            lblReal.TabIndex = 0;
            lblReal.Text = "Quantos reais deseja converter:";
            lblReal.Click += lblReal_Click;
            // 
            // lblCambio
            // 
            lblCambio.AutoSize = true;
            lblCambio.Location = new Point(86, 186);
            lblCambio.Name = "lblCambio";
            lblCambio.Size = new Size(253, 20);
            lblCambio.TabIndex = 1;
            lblCambio.Text = "Quanto esta o cambio do dolar hoje:";
            lblCambio.Click += this.lblCambio_Click;
            // 
            // lblDolar
            // 
            lblDolar.AutoSize = true;
            lblDolar.Location = new Point(86, 288);
            lblDolar.Name = "lblDolar";
            lblDolar.Size = new Size(188, 20);
            lblDolar.TabIndex = 2;
            lblDolar.Text = "A quantidade de dolares é:";
            lblDolar.Click += lblDolar_Click;
            // 
            // btnConversorD
            // 
            btnConversorD.Location = new Point(86, 476);
            btnConversorD.Name = "btnConversorD";
            btnConversorD.Size = new Size(145, 61);
            btnConversorD.TabIndex = 3;
            btnConversorD.Text = "Converter";
            btnConversorD.UseVisualStyleBackColor = true;
            btnConversorD.Click += btnConversorD_Click;
            // 
            // btnLimparD
            // 
            btnLimparD.Location = new Point(357, 476);
            btnLimparD.Name = "btnLimparD";
            btnLimparD.Size = new Size(145, 61);
            btnLimparD.TabIndex = 4;
            btnLimparD.Text = "Limpar";
            btnLimparD.UseVisualStyleBackColor = true;
            btnLimparD.Click += btnLimparD_Click;
            // 
            // btnVoltarD
            // 
            btnVoltarD.Location = new Point(628, 476);
            btnVoltarD.Name = "btnVoltarD";
            btnVoltarD.Size = new Size(145, 61);
            btnVoltarD.TabIndex = 5;
            btnVoltarD.Text = "Voltar";
            btnVoltarD.UseVisualStyleBackColor = true;
            btnVoltarD.Click += btnVoltarD_Click;
            // 
            // txtReal
            // 
            txtReal.Location = new Point(543, 77);
            txtReal.Name = "txtReal";
            txtReal.Size = new Size(125, 27);
            txtReal.TabIndex = 6;
            txtReal.TextChanged += this.txtReal_TextChanged;
            // 
            // txtCambio
            // 
            txtCambio.Location = new Point(543, 179);
            txtCambio.Name = "txtCambio";
            txtCambio.Size = new Size(125, 27);
            txtCambio.TabIndex = 7;
            txtCambio.TextChanged += this.txtCambio_TextChanged;
            // 
            // txtDolar
            // 
            txtDolar.Location = new Point(543, 281);
            txtDolar.Name = "txtDolar";
            txtDolar.ReadOnly = true;
            txtDolar.Size = new Size(125, 27);
            txtDolar.TabIndex = 8;
            txtDolar.TextChanged += this.txtDolar_TextChanged;
            // 
            // frmDolar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(txtDolar);
            Controls.Add(txtCambio);
            Controls.Add(txtReal);
            Controls.Add(btnVoltarD);
            Controls.Add(btnLimparD);
            Controls.Add(btnConversorD);
            Controls.Add(lblDolar);
            Controls.Add(lblCambio);
            Controls.Add(lblReal);
            Name = "frmDolar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Real para Dolar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReal;
        private Label lblCambio;
        private Label lblDolar;
        private Button btnConversorD;
        private Button btnLimparD;
        private Button btnVoltarD;
        private TextBox txtReal;
        private TextBox txtCambio;
        private TextBox txtDolar;
    }
}