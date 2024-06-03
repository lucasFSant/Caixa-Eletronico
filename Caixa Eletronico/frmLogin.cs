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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Caixa_Eletronico
{
    public partial class frmLogin : Form
    {
        Singleton s;
        public frmLogin()
        {
            s = Singleton.Instance;
            InitializeComponent();
        }

        public string a;

        private void bttAcessar_Click(object sender, EventArgs e)
        {
            Conta c = s.BuscarConta(txtConta.Text);
            if (c != null)
            {
                frmPrincipal frm = new frmPrincipal();
                s.conta_logada = c;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("A conta procurada não existe.");
            }
        }

        private void bttVoltar_Click(object sender, EventArgs e)
        {
            FrmInicial frm = new FrmInicial();
            frm.Show();
            this.Hide();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
