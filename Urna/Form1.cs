using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urna
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        public void BlockTeclado(bool isBloqueado = false)
        {
            pbxImagem.Enabled = isBloqueado;
            txbDescricao.Enabled = isBloqueado;

            btnConfirma.Enabled = isBloqueado;
            btnCorrige.Enabled = isBloqueado;
            btnBranco.Enabled = isBloqueado;

            button0.Enabled = isBloqueado;
            button1.Enabled = isBloqueado;
            button2.Enabled = isBloqueado;
            button3.Enabled = isBloqueado;
            button4.Enabled = isBloqueado;
            button5.Enabled = isBloqueado;
            button6.Enabled = isBloqueado;
            button7.Enabled = isBloqueado;
            button8.Enabled = isBloqueado;
            button9.Enabled = isBloqueado;
        }

        private void Form1_Load(object sender, EventArgs e) { BlockTeclado(false); }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            lblNome.Text = txtNumero.Text;
            txtNumero.Enabled = false;
            btnIniciar.Enabled = false;

            BlockTeclado(true);
        }

        

        
    }
}
