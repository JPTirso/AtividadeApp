namespace atividadeApp
{
    partial class frmSN
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
            lblSF = new Label();
            lblIdade = new Label();
            lblSexo = new Label();
            lblNome = new Label();
            btnVoltarSN = new Button();
            btnLimparSN = new Button();
            btnConverterSN = new Button();
            txtSF = new TextBox();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            txtSexo = new TextBox();
            labelMensagem = new Label();
            txtMensagem = new TextBox();
            SuspendLayout();
            // 
            // lblSF
            // 
            lblSF.AutoSize = true;
            lblSF.Location = new Point(225, 269);
            lblSF.Name = "lblSF";
            lblSF.Size = new Size(124, 20);
            lblSF.TabIndex = 21;
            lblSF.Text = "Digite seu salario";
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(225, 208);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(121, 20);
            lblIdade.TabIndex = 20;
            lblIdade.Text = "Digite sua idade:";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(224, 144);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(153, 20);
            lblSexo.TabIndex = 19;
            lblSexo.Text = "Digite seu sexo (M/F):";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(225, 86);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(121, 20);
            lblNome.TabIndex = 18;
            lblNome.Text = "Digite seu nome:";
            // 
            // btnVoltarSN
            // 
            btnVoltarSN.Location = new Point(593, 462);
            btnVoltarSN.Margin = new Padding(3, 4, 3, 4);
            btnVoltarSN.Name = "btnVoltarSN";
            btnVoltarSN.Size = new Size(144, 59);
            btnVoltarSN.TabIndex = 17;
            btnVoltarSN.Text = "Voltar";
            btnVoltarSN.UseVisualStyleBackColor = true;
            btnVoltarSN.Click += btnVoltarSN_Click;
            // 
            // btnLimparSN
            // 
            btnLimparSN.Location = new Point(387, 462);
            btnLimparSN.Margin = new Padding(3, 4, 3, 4);
            btnLimparSN.Name = "btnLimparSN";
            btnLimparSN.Size = new Size(144, 59);
            btnLimparSN.TabIndex = 16;
            btnLimparSN.Text = "Limpar";
            btnLimparSN.UseVisualStyleBackColor = true;
            btnLimparSN.Click += btnLimparSN_Click;
            // 
            // btnConverterSN
            // 
            btnConverterSN.Location = new Point(189, 462);
            btnConverterSN.Margin = new Padding(3, 4, 3, 4);
            btnConverterSN.Name = "btnConverterSN";
            btnConverterSN.Size = new Size(144, 59);
            btnConverterSN.TabIndex = 15;
            btnConverterSN.Text = "Converter";
            btnConverterSN.UseVisualStyleBackColor = true;
            btnConverterSN.Click += btnConverterSN_Click;
            // 
            // txtSF
            // 
            txtSF.Location = new Point(528, 262);
            txtSF.Margin = new Padding(3, 4, 3, 4);
            txtSF.Name = "txtSF";
            txtSF.Size = new Size(124, 27);
            txtSF.TabIndex = 14;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(528, 79);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(124, 27);
            txtNome.TabIndex = 13;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(528, 201);
            txtIdade.Margin = new Padding(3, 4, 3, 4);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(124, 27);
            txtIdade.TabIndex = 12;
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(528, 137);
            txtSexo.Margin = new Padding(3, 4, 3, 4);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(124, 27);
            txtSexo.TabIndex = 11;
            // 
            // labelMensagem
            // 
            labelMensagem.AutoSize = true;
            labelMensagem.Location = new Point(224, 337);
            labelMensagem.Name = "labelMensagem";
            labelMensagem.Size = new Size(0, 20);
            labelMensagem.TabIndex = 23;
            // 
            // txtMensagem
            // 
            txtMensagem.Location = new Point(337, 318);
            txtMensagem.Margin = new Padding(3, 4, 3, 4);
            txtMensagem.Multiline = true;
            txtMensagem.Name = "txtMensagem";
            txtMensagem.ReadOnly = true;
            txtMensagem.Size = new Size(221, 71);
            txtMensagem.TabIndex = 22;
            // 
            // frmSN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(labelMensagem);
            Controls.Add(txtMensagem);
            Controls.Add(lblSF);
            Controls.Add(lblIdade);
            Controls.Add(lblSexo);
            Controls.Add(lblNome);
            Controls.Add(btnVoltarSN);
            Controls.Add(btnLimparSN);
            Controls.Add(btnConverterSN);
            Controls.Add(txtSF);
            Controls.Add(txtNome);
            Controls.Add(txtIdade);
            Controls.Add(txtSexo);
            Name = "frmSN";
            Text = "Form10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSF;
        private Label lblIdade;
        private Label lblSexo;
        private Label lblNome;
        private Button btnVoltarSN;
        private Button btnLimparSN;
        private Button btnConverterSN;
        private TextBox txtSF;
        private TextBox txtNome;
        private TextBox txtIdade;
        private TextBox txtSexo;
        private Label labelMensagem;
        private TextBox txtMensagem;
    }
}