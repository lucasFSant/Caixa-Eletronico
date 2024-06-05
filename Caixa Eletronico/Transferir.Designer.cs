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
            btTransferir.Location = new Point(286, 256);
            btTransferir.Margin = new Padding(3, 2, 3, 2);
            btTransferir.Name = "btTransferir";
            btTransferir.Size = new Size(131, 38);
            btTransferir.TabIndex = 0;
            btTransferir.Text = "Transferir";
            btTransferir.UseVisualStyleBackColor = false;
            btTransferir.Click += btTransferir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F);
            label1.Location = new Point(301, 22);
            label1.Name = "label1";
            label1.Size = new Size(103, 30);
            label1.TabIndex = 1;
            label1.Text = "Transferir";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F);
            label2.Location = new Point(211, 128);
            label2.Name = "label2";
            label2.Size = new Size(67, 30);
            label2.TabIndex = 2;
            label2.Text = "Valor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F);
            label3.Location = new Point(116, 180);
            label3.Name = "label3";
            label3.Size = new Size(152, 30);
            label3.TabIndex = 3;
            label3.Text = "Conta destino:";
            // 
            // numTransferir
            // 
            numTransferir.Font = new Font("Segoe UI", 16.2F);
            numTransferir.Location = new Point(290, 128);
            numTransferir.Margin = new Padding(3, 2, 3, 2);
            numTransferir.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numTransferir.Name = "numTransferir";
            numTransferir.Size = new Size(131, 36);
            numTransferir.TabIndex = 4;
            // 
            // txtDestino
            // 
            txtDestino.Font = new Font("Segoe UI", 16.2F);
            txtDestino.Location = new Point(290, 180);
            txtDestino.Margin = new Padding(3, 2, 3, 2);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(132, 36);
            txtDestino.TabIndex = 5;
            // 
            // bttVoltar
            // 
            bttVoltar.BackColor = SystemColors.MenuHighlight;
            bttVoltar.Font = new Font("Segoe UI", 16.2F);
            bttVoltar.Location = new Point(10, 9);
            bttVoltar.Margin = new Padding(3, 2, 3, 2);
            bttVoltar.Name = "bttVoltar";
            bttVoltar.Size = new Size(120, 54);
            bttVoltar.TabIndex = 6;
            bttVoltar.Text = "Voltar";
            bttVoltar.UseVisualStyleBackColor = false;
            bttVoltar.Click += bttVoltar_Click;
            // 
            // Transferir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(700, 338);
            Controls.Add(bttVoltar);
            Controls.Add(txtDestino);
            Controls.Add(numTransferir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btTransferir);
            Margin = new Padding(3, 2, 3, 2);
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