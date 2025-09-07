namespace atividadeApp
{
    partial class frmTemperatura
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
            txtCelsios = new TextBox();
            txtFahrenheit = new TextBox();
            lblCelsios = new Label();
            lblFahrenheit = new Label();
            btnConverter = new Button();
            btnLimpar = new Button();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // txtCelsios
            // 
            txtCelsios.Location = new Point(543, 77);
            txtCelsios.Margin = new Padding(3, 4, 3, 4);
            txtCelsios.Name = "txtCelsios";
            txtCelsios.Size = new Size(114, 27);
            txtCelsios.TabIndex = 0;
            txtCelsios.TextChanged += txtCelsios_TextChanged;
            // 
            // txtFahrenheit
            // 
            txtFahrenheit.Location = new Point(543, 179);
            txtFahrenheit.Margin = new Padding(3, 4, 3, 4);
            txtFahrenheit.Name = "txtFahrenheit";
            txtFahrenheit.ReadOnly = true;
            txtFahrenheit.Size = new Size(114, 27);
            txtFahrenheit.TabIndex = 1;
            // 
            // lblCelsios
            // 
            lblCelsios.AutoSize = true;
            lblCelsios.Location = new Point(86, 84);
            lblCelsios.Name = "lblCelsios";
            lblCelsios.Size = new Size(162, 20);
            lblCelsios.TabIndex = 2;
            lblCelsios.Text = "Digite os graus Celsios:";
            // 
            // lblFahrenheit
            // 
            lblFahrenheit.AutoSize = true;
            lblFahrenheit.Location = new Point(86, 186);
            lblFahrenheit.Name = "lblFahrenheit";
            lblFahrenheit.Size = new Size(193, 20);
            lblFahrenheit.TabIndex = 3;
            lblFahrenheit.Text = "Temperatura em Fahrenheit:";
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(86, 476);
            btnConverter.Margin = new Padding(3, 4, 3, 4);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(145, 61);
            btnConverter.TabIndex = 4;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(357, 476);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(145, 61);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(628, 476);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(145, 61);
            btnVoltar.TabIndex = 6;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmTemperatura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnVoltar);
            Controls.Add(btnLimpar);
            Controls.Add(btnConverter);
            Controls.Add(lblFahrenheit);
            Controls.Add(lblCelsios);
            Controls.Add(txtFahrenheit);
            Controls.Add(txtCelsios);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTemperatura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Conversor de Temperatura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCelsios;
        private TextBox txtFahrenheit;
        private Label lblCelsios;
        private Label lblFahrenheit;
        private Button btnConverter;
        private Button btnLimpar;
        private Button btnVoltar;
    }
}