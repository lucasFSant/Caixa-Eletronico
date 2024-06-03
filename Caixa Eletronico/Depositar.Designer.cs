namespace Caixa_Eletronico
{
    partial class a
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
            numDepositar = new NumericUpDown();
            label2 = new Label();
            btDepositar = new Button();
            bttVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)numDepositar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F);
            label1.Location = new Point(358, 26);
            label1.Name = "label1";
            label1.Size = new Size(136, 38);
            label1.TabIndex = 0;
            label1.Text = "Depositar";
            // 
            // numDepositar
            // 
            numDepositar.Font = new Font("Segoe UI", 16.2F);
            numDepositar.Location = new Point(339, 176);
            numDepositar.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numDepositar.Name = "numDepositar";
            numDepositar.Size = new Size(221, 43);
            numDepositar.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F);
            label2.Location = new Point(241, 176);
            label2.Name = "label2";
            label2.Size = new Size(85, 38);
            label2.TabIndex = 2;
            label2.Text = "Valor:";
            // 
            // btDepositar
            // 
            btDepositar.BackColor = SystemColors.MenuHighlight;
            btDepositar.Font = new Font("Segoe UI", 16.2F);
            btDepositar.Location = new Point(339, 282);
            btDepositar.Name = "btDepositar";
            btDepositar.Size = new Size(165, 62);
            btDepositar.TabIndex = 3;
            btDepositar.Text = "Depositar";
            btDepositar.UseVisualStyleBackColor = false;
            btDepositar.Click += btDepositar_Click;
            // 
            // bttVoltar
            // 
            bttVoltar.BackColor = SystemColors.MenuHighlight;
            bttVoltar.Font = new Font("Segoe UI", 16.2F);
            bttVoltar.Location = new Point(12, 12);
            bttVoltar.Name = "bttVoltar";
            bttVoltar.Size = new Size(158, 77);
            bttVoltar.TabIndex = 4;
            bttVoltar.Text = "Voltar";
            bttVoltar.UseVisualStyleBackColor = false;
            bttVoltar.Click += bttVoltar_Click;
            // 
            // a
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(bttVoltar);
            Controls.Add(btDepositar);
            Controls.Add(label2);
            Controls.Add(numDepositar);
            Controls.Add(label1);
            Name = "a";
            Text = "Depositar";
            ((System.ComponentModel.ISupportInitialize)numDepositar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numDepositar;
        private Label label2;
        private Button btDepositar;
        private Button bttVoltar;
    }
}