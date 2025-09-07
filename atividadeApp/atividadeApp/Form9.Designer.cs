namespace atividadeApp
{
    partial class frmLivros
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
            btnVoltarL = new Button();
            btnLimparL = new Button();
            btnConverterL = new Button();
            lblPreco = new Label();
            lblLivros = new Label();
            txtPreco = new TextBox();
            txtLivros = new TextBox();
            SuspendLayout();
            // 
            // btnVoltarL
            // 
            btnVoltarL.Location = new Point(656, 469);
            btnVoltarL.Margin = new Padding(3, 4, 3, 4);
            btnVoltarL.Name = "btnVoltarL";
            btnVoltarL.Size = new Size(145, 61);
            btnVoltarL.TabIndex = 13;
            btnVoltarL.Text = "Voltar";
            btnVoltarL.UseVisualStyleBackColor = true;
            btnVoltarL.Click += btnVoltarL_Click;
            // 
            // btnLimparL
            // 
            btnLimparL.Location = new Point(385, 469);
            btnLimparL.Margin = new Padding(3, 4, 3, 4);
            btnLimparL.Name = "btnLimparL";
            btnLimparL.Size = new Size(145, 61);
            btnLimparL.TabIndex = 12;
            btnLimparL.Text = "Limpar";
            btnLimparL.UseVisualStyleBackColor = true;
            btnLimparL.Click += btnLimparL_Click;
            // 
            // btnConverterL
            // 
            btnConverterL.Location = new Point(114, 469);
            btnConverterL.Margin = new Padding(3, 4, 3, 4);
            btnConverterL.Name = "btnConverterL";
            btnConverterL.Size = new Size(145, 61);
            btnConverterL.TabIndex = 11;
            btnConverterL.Text = "Converter";
            btnConverterL.UseVisualStyleBackColor = true;
            btnConverterL.Click += btnConverterL_Click;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(114, 179);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(84, 20);
            lblPreco.TabIndex = 10;
            lblPreco.Text = "Preço total:";
            // 
            // lblLivros
            // 
            lblLivros.AutoSize = true;
            lblLivros.Location = new Point(114, 77);
            lblLivros.Name = "lblLivros";
            lblLivros.Size = new Size(205, 20);
            lblLivros.TabIndex = 9;
            lblLivros.Text = "Digite a quantidade de livros:";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(571, 172);
            txtPreco.Margin = new Padding(3, 4, 3, 4);
            txtPreco.Name = "txtPreco";
            txtPreco.ReadOnly = true;
            txtPreco.Size = new Size(114, 27);
            txtPreco.TabIndex = 8;
            // 
            // txtLivros
            // 
            txtLivros.Location = new Point(571, 70);
            txtLivros.Margin = new Padding(3, 4, 3, 4);
            txtLivros.Name = "txtLivros";
            txtLivros.Size = new Size(114, 27);
            txtLivros.TabIndex = 7;
            // 
            // frmLivros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnVoltarL);
            Controls.Add(btnLimparL);
            Controls.Add(btnConverterL);
            Controls.Add(lblPreco);
            Controls.Add(lblLivros);
            Controls.Add(txtPreco);
            Controls.Add(txtLivros);
            Name = "frmLivros";
            Text = "Preço de livros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltarL;
        private Button btnLimparL;
        private Button btnConverterL;
        private Label lblPreco;
        private Label lblLivros;
        private TextBox txtPreco;
        private TextBox txtLivros;
    }
}