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
            lblNum1.Location = new Point(75, 63);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(155, 15);
            lblNum1.TabIndex = 0;
            lblNum1.Text = "Informe o primeiro número:";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(75, 140);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(156, 15);
            lblNum2.TabIndex = 1;
            lblNum2.Text = "Informe o segundo número:";
            // 
            // lblNum3
            // 
            lblNum3.AutoSize = true;
            lblNum3.Location = new Point(75, 216);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(150, 15);
            lblNum3.TabIndex = 2;
            lblNum3.Text = "Informe o terceiro número:";
            // 
            // lblPotencia
            // 
            lblPotencia.AutoSize = true;
            lblPotencia.Location = new Point(75, 300);
            lblPotencia.Name = "lblPotencia";
            lblPotencia.Size = new Size(130, 15);
            lblPotencia.TabIndex = 3;
            lblPotencia.Text = "O quadrado da soma é:";
            // 
            // btnConverterP
            // 
            btnConverterP.Location = new Point(90, 357);
            btnConverterP.Margin = new Padding(3, 2, 3, 2);
            btnConverterP.Name = "btnConverterP";
            btnConverterP.Size = new Size(135, 46);
            btnConverterP.TabIndex = 4;
            btnConverterP.Text = "Converter";
            btnConverterP.UseVisualStyleBackColor = true;
            btnConverterP.Click += btnConverterP_Click;
            // 
            // btnLimparP
            // 
            btnLimparP.Location = new Point(311, 357);
            btnLimparP.Margin = new Padding(3, 2, 3, 2);
            btnLimparP.Name = "btnLimparP";
            btnLimparP.Size = new Size(135, 46);
            btnLimparP.TabIndex = 5;
            btnLimparP.Text = "Limpar";
            btnLimparP.UseVisualStyleBackColor = true;
            btnLimparP.Click += btnLimparP_Click;
            // 
            // btnVoltarP
            // 
            btnVoltarP.Location = new Point(526, 357);
            btnVoltarP.Margin = new Padding(3, 2, 3, 2);
            btnVoltarP.Name = "btnVoltarP";
            btnVoltarP.Size = new Size(135, 46);
            btnVoltarP.TabIndex = 6;
            btnVoltarP.Text = "Voltar";
            btnVoltarP.UseVisualStyleBackColor = true;
            btnVoltarP.Click += btnVoltarP_Click;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(475, 58);
            txtNum1.Margin = new Padding(3, 2, 3, 2);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(110, 23);
            txtNum1.TabIndex = 7;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(475, 134);
            txtNum2.Margin = new Padding(3, 2, 3, 2);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(110, 23);
            txtNum2.TabIndex = 8;
            // 
            // txtNum3
            // 
            txtNum3.Location = new Point(475, 211);
            txtNum3.Margin = new Padding(3, 2, 3, 2);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(118, 23);
            txtNum3.TabIndex = 9;
            // 
            // txtPotencia
            // 
            txtPotencia.Location = new Point(475, 295);
            txtPotencia.Margin = new Padding(3, 2, 3, 2);
            txtPotencia.Name = "txtPotencia";
            txtPotencia.ReadOnly = true;
            txtPotencia.Size = new Size(110, 23);
            txtPotencia.TabIndex = 10;
            // 
            // frmPotencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Margin = new Padding(3, 2, 3, 2);
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