﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa_Eletronico
{
    public partial class a : Form
    {
        Singleton s;
        public a()
        {
            InitializeComponent();
            s = Singleton.Instance;
        }

        private void bttVoltar_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Show();
            this.Hide();
        }

        private void btDepositar_Click(object sender, EventArgs e)
        {
            double valor = (double)numDepositar.Value;
            if (s.conta_logada.Depositar(valor))
            {
                MessageBox.Show("Depósito Realizado com Sucesso");
            }
            else
            {
                MessageBox.Show("N deu certo, burrokkk");
            }
        }
    }
}
