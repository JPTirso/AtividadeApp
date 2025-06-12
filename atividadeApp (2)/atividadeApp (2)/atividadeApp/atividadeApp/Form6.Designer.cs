namespace atividadeApp
{
    partial class frmCirculo
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
            lblRaio = new Label();
            lblArea = new Label();
            btnConversorC = new Button();
            btnLimparC = new Button();
            btnVoltarC = new Button();
            txtRaio = new TextBox();
            txtArea = new TextBox();
            SuspendLayout();
            // 
            // lblRaio
            // 
            lblRaio.AutoSize = true;
            lblRaio.Location = new Point(86, 84);
            lblRaio.Name = "lblRaio";
            lblRaio.Size = new Size(216, 20);
            lblRaio.TabIndex = 0;
            lblRaio.Text = "Informe o raio da circunferecia:";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(86, 186);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(163, 20);
            lblArea.TabIndex = 1;
            lblArea.Text = "A area do seu circulo é:";
            // 
            // btnConversorC
            // 
            btnConversorC.Location = new Point(86, 476);
            btnConversorC.Name = "btnConversorC";
            btnConversorC.Size = new Size(145, 61);
            btnConversorC.TabIndex = 2;
            btnConversorC.Text = "Converter";
            btnConversorC.UseVisualStyleBackColor = true;
            btnConversorC.Click += btnConversorC_Click;
            // 
            // btnLimparC
            // 
            btnLimparC.Location = new Point(357, 476);
            btnLimparC.Name = "btnLimparC";
            btnLimparC.Size = new Size(145, 61);
            btnLimparC.TabIndex = 3;
            btnLimparC.Text = "Limpar";
            btnLimparC.UseVisualStyleBackColor = true;
            btnLimparC.Click += btnLimparC_Click;
            // 
            // btnVoltarC
            // 
            btnVoltarC.Location = new Point(628, 476);
            btnVoltarC.Name = "btnVoltarC";
            btnVoltarC.Size = new Size(145, 61);
            btnVoltarC.TabIndex = 4;
            btnVoltarC.Text = "Voltar";
            btnVoltarC.UseVisualStyleBackColor = true;
            btnVoltarC.Click += btnVoltarC_Click;
            // 
            // txtRaio
            // 
            txtRaio.Location = new Point(543, 77);
            txtRaio.Name = "txtRaio";
            txtRaio.Size = new Size(125, 27);
            txtRaio.TabIndex = 5;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(543, 179);
            txtArea.Name = "txtArea";
            txtArea.ReadOnly = true;
            txtArea.Size = new Size(125, 27);
            txtArea.TabIndex = 6;
            // 
            // frmCirculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(txtArea);
            Controls.Add(txtRaio);
            Controls.Add(btnVoltarC);
            Controls.Add(btnLimparC);
            Controls.Add(btnConversorC);
            Controls.Add(lblArea);
            Controls.Add(lblRaio);
            Name = "frmCirculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Area da circunferencia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRaio;
        private Label lblArea;
        private Button btnConversorC;
        private Button btnLimparC;
        private Button btnVoltarC;
        private TextBox txtRaio;
        private TextBox txtArea;
    }
}