namespace Caixa_Eletronico
{
    partial class Transferir
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
            btTransferir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numTransferir = new NumericUpDown();
            txtDestino = new TextBox();
            bttVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)numTransferir).BeginInit();
            SuspendLayout();
            // 
            // btTransferir
            // 
            btTransferir.BackColor = SystemColors.MenuHighlight;
            btTransferir.Font = new Font("Segoe UI", 16.2F);
            btTransferir.Location = new Point(327, 342);
            btTransferir.Name = "btTransferir";
            btTransferir.Size = new Size(150, 46);
            btTransferir.TabIndex = 0;
            btTransferir.Text = "Transferir";
            btTransferir.UseVisualStyleBackColor = false;
            btTransferir.Click += btTransferir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F);
            label1.Location = new Point(344, 29);
            label1.Name = "label1";
            label1.Size = new Size(133, 38);
            label1.TabIndex = 1;
            label1.Text = "Transferir";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F);
            label2.Location = new Point(241, 171);
            label2.Name = "label2";
            label2.Size = new Size(85, 38);
            label2.TabIndex = 2;
            label2.Text = "Valor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F);
            label3.Location = new Point(132, 240);
            label3.Name = "label3";
            label3.Size = new Size(194, 38);
            label3.TabIndex = 3;
            label3.Text = "Conta destino:";
            // 
            // numTransferir
            // 
            numTransferir.Font = new Font("Segoe UI", 16.2F);
            numTransferir.Location = new Point(332, 171);
            numTransferir.Name = "numTransferir";
            numTransferir.Size = new Size(150, 43);
            numTransferir.TabIndex = 4;
            // 
            // txtDestino
            // 
            txtDestino.Font = new Font("Segoe UI", 16.2F);
            txtDestino.Location = new Point(332, 240);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(150, 43);
            txtDestino.TabIndex = 5;
            // 
            // bttVoltar
            // 
            bttVoltar.BackColor = SystemColors.MenuHighlight;
            bttVoltar.Font = new Font("Segoe UI", 16.2F);
            bttVoltar.Location = new Point(12, 12);
            bttVoltar.Name = "bttVoltar";
            bttVoltar.Size = new Size(116, 54);
            bttVoltar.TabIndex = 6;
            bttVoltar.Text = "Voltar";
            bttVoltar.UseVisualStyleBackColor = false;
            bttVoltar.Click += bttVoltar_Click;
            // 
            // Transferir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(bttVoltar);
            Controls.Add(txtDestino);
            Controls.Add(numTransferir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btTransferir);
            Name = "Transferir";
            Text = "Transferir";
            Load += Transferir_Load;
            ((System.ComponentModel.ISupportInitialize)numTransferir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btTransferir;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numTransferir;
        private TextBox txtDestino;
        private Button bttVoltar;
    }
}