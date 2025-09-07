namespace atividadeApp
{
    partial class frmCardapio
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
            btnVoltarC = new Button();
            btnLimparC = new Button();
            btnConverterC = new Button();
            lblLanche = new Label();
            lblCodigo = new Label();
            txtLanche = new TextBox();
            txtCodigo = new TextBox();
            SuspendLayout();
            // 
            // btnVoltarC
            // 
            btnVoltarC.Location = new Point(656, 469);
            btnVoltarC.Margin = new Padding(3, 4, 3, 4);
            btnVoltarC.Name = "btnVoltarC";
            btnVoltarC.Size = new Size(145, 61);
            btnVoltarC.TabIndex = 13;
            btnVoltarC.Text = "Voltar";
            btnVoltarC.UseVisualStyleBackColor = true;
            btnVoltarC.Click += btnVoltarC_Click;
            // 
            // btnLimparC
            // 
            btnLimparC.Location = new Point(385, 469);
            btnLimparC.Margin = new Padding(3, 4, 3, 4);
            btnLimparC.Name = "btnLimparC";
            btnLimparC.Size = new Size(145, 61);
            btnLimparC.TabIndex = 12;
            btnLimparC.Text = "Limpar";
            btnLimparC.UseVisualStyleBackColor = true;
            btnLimparC.Click += btnLimparC_Click;
            // 
            // btnConverterC
            // 
            btnConverterC.Location = new Point(114, 469);
            btnConverterC.Margin = new Padding(3, 4, 3, 4);
            btnConverterC.Name = "btnConverterC";
            btnConverterC.Size = new Size(145, 61);
            btnConverterC.TabIndex = 11;
            btnConverterC.Text = "Converter";
            btnConverterC.UseVisualStyleBackColor = true;
            btnConverterC.Click += btnConverterC_Click;
            // 
            // lblLanche
            // 
            lblLanche.AutoSize = true;
            lblLanche.Location = new Point(114, 179);
            lblLanche.Name = "lblLanche";
            lblLanche.Size = new Size(95, 20);
            lblLanche.TabIndex = 10;
            lblLanche.Text = "Seu lanche é:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(114, 77);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(180, 20);
            lblCodigo.TabIndex = 9;
            lblCodigo.Text = "Insira o codigo do lanche:";
            // 
            // txtLanche
            // 
            txtLanche.Location = new Point(571, 172);
            txtLanche.Margin = new Padding(3, 4, 3, 4);
            txtLanche.Name = "txtLanche";
            txtLanche.ReadOnly = true;
            txtLanche.Size = new Size(114, 27);
            txtLanche.TabIndex = 8;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(571, 70);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(114, 27);
            txtCodigo.TabIndex = 7;
            // 
            // frmCardapio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnVoltarC);
            Controls.Add(btnLimparC);
            Controls.Add(btnConverterC);
            Controls.Add(lblLanche);
            Controls.Add(lblCodigo);
            Controls.Add(txtLanche);
            Controls.Add(txtCodigo);
            Name = "frmCardapio";
            Text = "Cardapio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltarC;
        private Button btnLimparC;
        private Button btnConverterC;
        private Label lblLanche;
        private Label lblCodigo;
        private TextBox txtLanche;
        private TextBox txtCodigo;
    }
}