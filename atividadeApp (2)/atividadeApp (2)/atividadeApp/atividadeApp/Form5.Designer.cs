namespace atividadeApp
{
    partial class frmPotencia
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
            lblNum1 = new Label();
            lblNum2 = new Label();
            lblNum3 = new Label();
            lblPotencia = new Label();
            btnConverterP = new Button();
            btnLimparP = new Button();
            btnVoltarP = new Button();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtNum3 = new TextBox();
            txtPotencia = new TextBox();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(86, 84);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(193, 20);
            lblNum1.TabIndex = 0;
            lblNum1.Text = "Informe o primeiro número:";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(86, 186);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(193, 20);
            lblNum2.TabIndex = 1;
            lblNum2.Text = "Informe o segundo número:";
            // 
            // lblNum3
            // 
            lblNum3.AutoSize = true;
            lblNum3.Location = new Point(86, 288);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(187, 20);
            lblNum3.TabIndex = 2;
            lblNum3.Text = "Informe o terceiro número:";
            // 
            // lblPotencia
            // 
            lblPotencia.AutoSize = true;
            lblPotencia.Location = new Point(86, 400);
            lblPotencia.Name = "lblPotencia";
            lblPotencia.Size = new Size(165, 20);
            lblPotencia.TabIndex = 3;
            lblPotencia.Text = "O quadrado da soma é:";
            // 
            // btnConverterP
            // 
            btnConverterP.Location = new Point(86, 476);
            btnConverterP.Name = "btnConverterP";
            btnConverterP.Size = new Size(145, 61);
            btnConverterP.TabIndex = 4;
            btnConverterP.Text = "Converter";
            btnConverterP.UseVisualStyleBackColor = true;
            btnConverterP.Click += btnConverterP_Click;
            // 
            // btnLimparP
            // 
            btnLimparP.Location = new Point(357, 476);
            btnLimparP.Name = "btnLimparP";
            btnLimparP.Size = new Size(145, 61);
            btnLimparP.TabIndex = 5;
            btnLimparP.Text = "Limpar";
            btnLimparP.UseVisualStyleBackColor = true;
            btnLimparP.Click += btnLimparP_Click;
            // 
            // btnVoltarP
            // 
            btnVoltarP.Location = new Point(628, 476);
            btnVoltarP.Name = "btnVoltarP";
            btnVoltarP.Size = new Size(145, 61);
            btnVoltarP.TabIndex = 6;
            btnVoltarP.Text = "Voltar";
            btnVoltarP.UseVisualStyleBackColor = true;
            btnVoltarP.Click += btnVoltarP_Click;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(543, 77);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(125, 27);
            txtNum1.TabIndex = 7;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(543, 179);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(125, 27);
            txtNum2.TabIndex = 8;
            // 
            // txtNum3
            // 
            txtNum3.Location = new Point(543, 281);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(134, 27);
            txtNum3.TabIndex = 9;
            // 
            // txtPotencia
            // 
            txtPotencia.Location = new Point(543, 393);
            txtPotencia.Name = "txtPotencia";
            txtPotencia.ReadOnly = true;
            txtPotencia.Size = new Size(125, 27);
            txtPotencia.TabIndex = 10;
            // 
            // frmPotencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(txtPotencia);
            Controls.Add(txtNum3);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(btnVoltarP);
            Controls.Add(btnLimparP);
            Controls.Add(btnConverterP);
            Controls.Add(lblPotencia);
            Controls.Add(lblNum3);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Name = "frmPotencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quadrado da Soma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private Label lblNum2;
        private Label lblNum3;
        private Label lblPotencia;
        private Button btnConverterP;
        private Button btnLimparP;
        private Button btnVoltarP;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtNum3;
        private TextBox txtPotencia;
    }
}