namespace Caixa_Eletronico
{
    partial class Sacar
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
            btSacar = new Button();
            label1 = new Label();
            numSacar = new NumericUpDown();
            label2 = new Label();
            bttVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)numSacar).BeginInit();
            SuspendLayout();
            // 
            // btSacar
            // 
            btSacar.BackColor = SystemColors.MenuHighlight;
            btSacar.Font = new Font("Segoe UI", 16.2F);
            btSacar.Location = new Point(290, 211);
            btSacar.Margin = new Padding(3, 2, 3, 2);
            btSacar.Name = "btSacar";
            btSacar.Size = new Size(150, 55);
            btSacar.TabIndex = 0;
            btSacar.Text = "Sacar";
            btSacar.UseVisualStyleBackColor = false;
            btSacar.Click += btSacar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 10);
            label1.Name = "label1";
            label1.Size = new Size(88, 41);
            label1.TabIndex = 1;
            label1.Text = "Sacar";
            // 
            // numSacar
            // 
            numSacar.Font = new Font("Segoe UI", 16.2F);
            numSacar.Location = new Point(338, 129);
            numSacar.Margin = new Padding(3, 2, 3, 2);
            numSacar.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numSacar.Name = "numSacar";
            numSacar.Size = new Size(131, 36);
            numSacar.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F);
            label2.Location = new Point(255, 130);
            label2.Name = "label2";
            label2.Size = new Size(67, 30);
            label2.TabIndex = 3;
            label2.Text = "Valor:";
            // 
            // bttVoltar
            // 
            bttVoltar.BackColor = SystemColors.MenuHighlight;
            bttVoltar.Font = new Font("Segoe UI", 16.2F);
            bttVoltar.Location = new Point(10, 9);
            bttVoltar.Margin = new Padding(3, 2, 3, 2);
            bttVoltar.Name = "bttVoltar";
            bttVoltar.Size = new Size(124, 62);
            bttVoltar.TabIndex = 4;
            bttVoltar.Text = "Voltar";
            bttVoltar.UseVisualStyleBackColor = false;
            bttVoltar.Click += bttVoltar_Click;
            // 
            // Sacar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(700, 338);
            Controls.Add(bttVoltar);
            Controls.Add(label2);
            Controls.Add(numSacar);
            Controls.Add(label1);
            Controls.Add(btSacar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Sacar";
            Text = "Sacar";
            ((System.ComponentModel.ISupportInitialize)numSacar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSacar;
        private Label label1;
        private NumericUpDown numSacar;
        private Label label2;
        private Button bttVoltar;
    }
}