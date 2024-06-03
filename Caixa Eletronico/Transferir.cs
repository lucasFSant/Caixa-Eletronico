using Caixa_Eletronico.Classes;
using System;
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
    public partial class Transferir : Form
    {
        Singleton s;
        public Transferir()
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

        private void btTransferir_Click(object sender, EventArgs e)
        {
            double valor = (double)numTransferir.Value;
            Conta destino = s.BuscarConta(txtDestino.Text);
            if (destino != null)
            {
                if(s.conta_logada.Transferir(destino, valor))
                {
                    MessageBox.Show("Transferência Realizada com Sucesso");
                }
                else
                {
                    MessageBox.Show("N deu certo, burrokkk");
                }
            }
        }

        private void Transferir_Load(object sender, EventArgs e)
        {

        }
    }
}
