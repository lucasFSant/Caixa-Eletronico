namespace Caixa_Eletronico
{
    partial class frmPrincipal
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
            label1 = new Label();
            bttVoltarLogin = new Button();
            bttDepositar = new Button();
            bttSacar = new Button();
            bttTransferir = new Button();
            bttExtrato = new Button();
            lblSaldo = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F);
            label1.Location = new Point(499, 26);
            label1.Name = "label1";
            label1.Size = new Size(72, 30);
            label1.TabIndex = 0;
            label1.Text = "Saldo:";
            // 
            // bttVoltarLogin
            // 
            bttVoltarLogin.BackColor = SystemColors.MenuHighlight;
            bttVoltarLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttVoltarLogin.Location = new Point(26, 20);
            bttVoltarLogin.Margin = new Padding(3, 2, 3, 2);
            bttVoltarLogin.Name = "bttVoltarLogin";
            bttVoltarLogin.Size = new Size(141, 42);
            bttVoltarLogin.TabIndex = 1;
            bttVoltarLogin.Text = "Voltar";
            bttVoltarLogin.UseVisualStyleBackColor = false;
            bttVoltarLogin.Click += bttVoltarLogin_Click;
            // 
            // bttDepositar
            // 
            bttDepositar.BackColor = SystemColors.MenuHighlight;
            bttDepositar.Font = new Font("Segoe UI", 16.2F);
            bttDepositar.Location = new Point(290, 82);
            bttDepositar.Margin = new Padding(3, 2, 3, 2);
            bttDepositar.Name = "bttDepositar";
            bttDepositar.Size = new Size(145, 51);
            bttDepositar.TabIndex = 2;
            bttDepositar.Text = "Depositar";
            bttDepositar.UseVisualStyleBackColor = false;
            bttDepositar.Click += bttDepositar_Click;
            // 
            // bttSacar
            // 
            bttSacar.BackColor = SystemColors.MenuHighlight;
            bttSacar.Font = new Font("Segoe UI", 16.2F);
            bttSacar.Location = new Point(290, 137);
            bttSacar.Margin = new Padding(3, 2, 3, 2);
            bttSacar.Name = "bttSacar";
            bttSacar.Size = new Size(145, 44);
            bttSacar.TabIndex = 3;
            bttSacar.Text = "Sacar";
            bttSacar.UseVisualStyleBackColor = false;
            bttSacar.Click += bttSacar_Click_1;
            // 
            // bttTransferir
            // 
            bttTransferir.BackColor = SystemColors.MenuHighlight;
            bttTransferir.Font = new Font("Segoe UI", 16.2F);
            bttTransferir.Location = new Point(290, 185);
            bttTransferir.Margin = new Padding(3, 2, 3, 2);
            bttTransferir.Name = "bttTransferir";
            bttTransferir.Size = new Size(145, 51);
            bttTransferir.TabIndex = 4;
            bttTransferir.Text = "Transferir";
            bttTransferir.UseVisualStyleBackColor = false;
            bttTransferir.Click += bttTransferir_Click_1;
            // 
            // bttExtrato
            // 
            bttExtrato.BackColor = SystemColors.MenuHighlight;
            bttExtrato.Font = new Font("Segoe UI", 16.2F);
            bttExtrato.Location = new Point(290, 241);
            bttExtrato.Margin = new Padding(3, 2, 3, 2);
            bttExtrato.Name = "bttExtrato";
            bttExtrato.Size = new Size(145, 58);
            bttExtrato.TabIndex = 5;
            bttExtrato.Text = "Ver Extrato";
            bttExtrato.UseVisualStyleBackColor = false;
            bttExtrato.Click += bttExtrato_Click;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 16.2F);
            lblSaldo.Location = new Point(577, 26);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(0, 30);
            lblSaldo.TabIndex = 6;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(700, 338);
            Controls.Add(lblSaldo);
            Controls.Add(bttExtrato);
            Controls.Add(bttTransferir);
            Controls.Add(bttSacar);
            Controls.Add(bttDepositar);
            Controls.Add(bttVoltarLogin);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bttVoltarLogin;
        private Button bttDepositar;
        private Button bttSacar;
        private Button bttTransferir;
        private Button bttExtrato;
        private Label lblSaldo;
    }
}