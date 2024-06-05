namespace Caixa_Eletronico
{
    partial class Extrato
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
            bttVoltar = new Button();
            dataGridExtrato = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridExtrato).BeginInit();
            SuspendLayout();
            // 
            // bttVoltar
            // 
            bttVoltar.BackColor = SystemColors.MenuHighlight;
            bttVoltar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttVoltar.Location = new Point(465, 109);
            bttVoltar.Margin = new Padding(3, 2, 3, 2);
            bttVoltar.Name = "bttVoltar";
            bttVoltar.Size = new Size(197, 85);
            bttVoltar.TabIndex = 0;
            bttVoltar.Text = "Voltar";
            bttVoltar.UseVisualStyleBackColor = false;
            bttVoltar.Click += bttVoltar_Click;
            // 
            // dataGridExtrato
            // 
            dataGridExtrato.BackgroundColor = SystemColors.MenuHighlight;
            dataGridExtrato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridExtrato.GridColor = SystemColors.HighlightText;
            dataGridExtrato.Location = new Point(43, 46);
            dataGridExtrato.Margin = new Padding(3, 2, 3, 2);
            dataGridExtrato.Name = "dataGridExtrato";
            dataGridExtrato.RowHeadersWidth = 51;
            dataGridExtrato.Size = new Size(373, 244);
            dataGridExtrato.TabIndex = 1;
            // 
            // Extrato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(700, 338);
            Controls.Add(dataGridExtrato);
            Controls.Add(bttVoltar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Extrato";
            Text = "Extrato";
            Load += Extrato_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridExtrato).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button bttVoltar;
        private DataGridView dataGridExtrato;
    }
}