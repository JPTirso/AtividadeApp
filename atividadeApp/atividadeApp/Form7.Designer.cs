namespace atividadeApp
{
    partial class frmNotas
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
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            txtNota1 = new TextBox();
            txtMediaN = new TextBox();
            btnConverterN = new Button();
            btnLimparN = new Button();
            btnVoltarN = new Button();
            lblNota1 = new Label();
            lblNota2 = new Label();
            lblNota3 = new Label();
            lblMediaN = new Label();
            SuspendLayout();
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(401, 125);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(109, 23);
            txtNota2.TabIndex = 0;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(401, 173);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(109, 23);
            txtNota3.TabIndex = 1;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(401, 82);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(109, 23);
            txtNota1.TabIndex = 2;
            // 
            // txtMediaN
            // 
            txtMediaN.Location = new Point(401, 219);
            txtMediaN.Name = "txtMediaN";
            txtMediaN.ReadOnly = true;
            txtMediaN.Size = new Size(109, 23);
            txtMediaN.TabIndex = 3;
            // 
            // btnConverterN
            // 
            btnConverterN.Location = new Point(104, 369);
            btnConverterN.Name = "btnConverterN";
            btnConverterN.Size = new Size(126, 44);
            btnConverterN.TabIndex = 4;
            btnConverterN.Text = "Converter";
            btnConverterN.UseVisualStyleBackColor = true;
            btnConverterN.Click += btnConverterN_Click;
            // 
            // btnLimparN
            // 
            btnLimparN.Location = new Point(277, 369);
            btnLimparN.Name = "btnLimparN";
            btnLimparN.Size = new Size(126, 44);
            btnLimparN.TabIndex = 5;
            btnLimparN.Text = "Limpar";
            btnLimparN.UseVisualStyleBackColor = true;
            // 
            // btnVoltarN
            // 
            btnVoltarN.Location = new Point(458, 369);
            btnVoltarN.Name = "btnVoltarN";
            btnVoltarN.Size = new Size(126, 44);
            btnVoltarN.TabIndex = 6;
            btnVoltarN.Text = "Voltar";
            btnVoltarN.UseVisualStyleBackColor = true;
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Location = new Point(135, 92);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(86, 15);
            lblNota1.TabIndex = 7;
            lblNota1.Text = "Digite a nota 1:";
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Location = new Point(136, 136);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(86, 15);
            lblNota2.TabIndex = 8;
            lblNota2.Text = "Digite a nota 2:";
            // 
            // lblNota3
            // 
            lblNota3.AutoSize = true;
            lblNota3.Location = new Point(136, 181);
            lblNota3.Name = "lblNota3";
            lblNota3.Size = new Size(86, 15);
            lblNota3.TabIndex = 9;
            lblNota3.Text = "Digite a nota 3:";
            // 
            // lblMediaN
            // 
            lblMediaN.AutoSize = true;
            lblMediaN.Location = new Point(94, 227);
            lblMediaN.Name = "lblMediaN";
            lblMediaN.Size = new Size(116, 15);
            lblMediaN.TabIndex = 10;
            lblMediaN.Text = "A média poderada é:";
            // 
            // frmNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMediaN);
            Controls.Add(lblNota3);
            Controls.Add(lblNota2);
            Controls.Add(lblNota1);
            Controls.Add(btnVoltarN);
            Controls.Add(btnLimparN);
            Controls.Add(btnConverterN);
            Controls.Add(txtMediaN);
            Controls.Add(txtNota1);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Name = "frmNotas";
            Text = "Média das Notas";
            Load += frmNotas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNota2;
        private TextBox txtNota3;
        private TextBox txtNota1;
        private TextBox txtMediaN;
        private Button btnConverterN;
        private Button btnLimparN;
        private Button btnVoltarN;
        private Label lblNota1;
        private Label lblNota2;
        private Label lblNota3;
        private Label lblMediaN;
    }
}