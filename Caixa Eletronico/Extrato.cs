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
    public partial class Extrato : Form
    {
        Singleton s;
        public Extrato()
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

        private void Extrato_Load(object sender, EventArgs e)
        {
            var source = new BindingSource();
            source.DataSource = s.conta_logada.Transacoes;
            dataGridExtrato.DataSource = source;
        }
    }
}
