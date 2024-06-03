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
    public partial class frmPrincipal : Form
    {
        Singleton s;
        public frmPrincipal()
        {
            s = Singleton.Instance;
            InitializeComponent();
        }

        private void bttVoltarLogin_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void bttDepositar_Click(object sender, EventArgs e)
        {
            a frm = new a();
            frm.Show();
            this.Hide();
        }

        private void bttSacar_Click(object sender, EventArgs e)
        {
            Sacar frm = new Sacar();
            frm.Show();
            this.Hide();
        }

        private void bttTransferir_Click(object sender, EventArgs e)
        {
            Transferir frm = new Transferir();
            frm.Show();
            this.Hide();
        }

        private void bttSacar_Click_1(object sender, EventArgs e)
        {
            Sacar frm = new Sacar();
            frm.Show();
            this.Hide();
        }

        private void bttTransferir_Click_1(object sender, EventArgs e)
        {
            Transferir frm = new Transferir();
            frm.Show();
            this.Hide();
        }

        private void bttExtrato_Click(object sender, EventArgs e)
        {
            Extrato frm = new Extrato();
            frm.Show();
            this.Hide();
        }

        private void frmPrincipal_Load_1(object sender, EventArgs e)
        {
            lblSaldo.Text = s.conta_logada.Saldo.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
