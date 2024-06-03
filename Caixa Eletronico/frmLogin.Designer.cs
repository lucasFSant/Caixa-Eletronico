namespace Caixa_Eletronico
{
    partial class frmLogin
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
            txtConta = new TextBox();
            bttAcessar = new Button();
            bttVoltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F);
            label1.Location = new Point(209, 205);
            label1.Name = "label1";
            label1.Size = new Size(95, 38);
            label1.TabIndex = 0;
            label1.Text = "Conta:";
            // 
            // txtConta
            // 
            txtConta.Font = new Font("Segoe UI", 16.2F);
            txtConta.Location = new Point(310, 205);
            txtConta.Name = "txtConta";
            txtConta.Size = new Size(189, 43);
            txtConta.TabIndex = 1;
            // 
            // bttAcessar
            // 
            bttAcessar.BackColor = SystemColors.MenuHighlight;
            bttAcessar.Font = new Font("Segoe UI", 16.2F);
            bttAcessar.Location = new Point(326, 329);
            bttAcessar.Name = "bttAcessar";
            bttAcessar.Size = new Size(158, 70);
            bttAcessar.TabIndex = 2;
            bttAcessar.Text = "Acessar";
            bttAcessar.UseVisualStyleBackColor = false;
            bttAcessar.Click += bttAcessar_Click;
            // 
            // bttVoltar
            // 
            bttVoltar.BackColor = SystemColors.MenuHighlight;
            bttVoltar.Font = new Font("Segoe UI", 16.2F);
            bttVoltar.Location = new Point(12, 12);
            bttVoltar.Name = "bttVoltar";
            bttVoltar.Size = new Size(158, 70);
            bttVoltar.TabIndex = 3;
            bttVoltar.Text = "Voltar";
            bttVoltar.UseVisualStyleBackColor = false;
            bttVoltar.Click += bttVoltar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(bttVoltar);
            Controls.Add(bttAcessar);
            Controls.Add(txtConta);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "frmLogin";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bttAcessar;
        private Button bttVoltar;
        private TextBox txtConta;
    }
}