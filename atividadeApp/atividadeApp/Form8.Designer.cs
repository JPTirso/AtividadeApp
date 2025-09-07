namespace atividadeApp
{
    partial class frmJogo
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
            btnVoltarJ = new Button();
            btnLimparJ = new Button();
            btnConverterJ = new Button();
            lblRendat = new Label();
            lblPubt = new Label();
            txtRendat = new TextBox();
            txtPubt = new TextBox();
            SuspendLayout();
            // 
            // btnVoltarJ
            // 
            btnVoltarJ.Location = new Point(656, 469);
            btnVoltarJ.Margin = new Padding(3, 4, 3, 4);
            btnVoltarJ.Name = "btnVoltarJ";
            btnVoltarJ.Size = new Size(145, 61);
            btnVoltarJ.TabIndex = 13;
            btnVoltarJ.Text = "Voltar";
            btnVoltarJ.UseVisualStyleBackColor = true;
            btnVoltarJ.Click += btnVoltarJ_Click;
            // 
            // btnLimparJ
            // 
            btnLimparJ.Location = new Point(385, 469);
            btnLimparJ.Margin = new Padding(3, 4, 3, 4);
            btnLimparJ.Name = "btnLimparJ";
            btnLimparJ.Size = new Size(145, 61);
            btnLimparJ.TabIndex = 12;
            btnLimparJ.Text = "Limpar";
            btnLimparJ.UseVisualStyleBackColor = true;
            btnLimparJ.Click += btnLimparJ_Click;
            // 
            // btnConverterJ
            // 
            btnConverterJ.Location = new Point(114, 469);
            btnConverterJ.Margin = new Padding(3, 4, 3, 4);
            btnConverterJ.Name = "btnConverterJ";
            btnConverterJ.Size = new Size(145, 61);
            btnConverterJ.TabIndex = 11;
            btnConverterJ.Text = "Converter";
            btnConverterJ.UseVisualStyleBackColor = true;
            btnConverterJ.Click += btnConverterJ_Click;
            // 
            // lblRendat
            // 
            lblRendat.AutoSize = true;
            lblRendat.Location = new Point(114, 179);
            lblRendat.Name = "lblRendat";
            lblRendat.Size = new Size(165, 20);
            lblRendat.TabIndex = 10;
            lblRendat.Text = "Renda total desse jogo:";
            // 
            // lblPubt
            // 
            lblPubt.AutoSize = true;
            lblPubt.Location = new Point(114, 77);
            lblPubt.Name = "lblPubt";
            lblPubt.Size = new Size(236, 20);
            lblPubt.TabIndex = 9;
            lblPubt.Text = "Digite o publico total de um jogo:";
            // 
            // txtRendat
            // 
            txtRendat.Location = new Point(571, 172);
            txtRendat.Margin = new Padding(3, 4, 3, 4);
            txtRendat.Name = "txtRendat";
            txtRendat.ReadOnly = true;
            txtRendat.Size = new Size(114, 27);
            txtRendat.TabIndex = 8;
            // 
            // txtPubt
            // 
            txtPubt.Location = new Point(571, 70);
            txtPubt.Margin = new Padding(3, 4, 3, 4);
            txtPubt.Name = "txtPubt";
            txtPubt.Size = new Size(114, 27);
            txtPubt.TabIndex = 7;
            // 
            // frmJogo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnVoltarJ);
            Controls.Add(btnLimparJ);
            Controls.Add(btnConverterJ);
            Controls.Add(lblRendat);
            Controls.Add(lblPubt);
            Controls.Add(txtRendat);
            Controls.Add(txtPubt);
            Name = "frmJogo";
            Text = "Renda de um Jogo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltarJ;
        private Button btnLimparJ;
        private Button btnConverterJ;
        private Label lblRendat;
        private Label lblPubt;
        private TextBox txtRendat;
        private TextBox txtPubt;
    }
}