using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urna.entidades;
using Urna.sistema;

namespace Urna
{
    public partial class Tela : Form
    {
        ListaEleitores eleitorList = new ListaEleitores();
        Eleitor eleitor = new Eleitor();

        public Tela()
        {
            InitializeComponent();
        }

        public void NoBlockKeyboard(bool isBloqueado = false)
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

        private void Form1_Load(object sender, EventArgs e) { NoBlockKeyboard(false); }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            eleitorList.MyCod = txtNumero.Text;

            if (eleitorList.IsCodeValid() == true)
            {
                string nome = eleitorList.NomeEleitor();

                lblNome.Text = "Nome: " + nome;

                txtNumero.Enabled = false;
                btnIniciar.Enabled = false;
                NoBlockKeyboard(true);
            }
            else { MessageBox.Show("Código de eleitor invalido.\n\n*Nome: Super Mario - N°:12345\n*Nome: Seu Madruga - N°: 54321\n*Nome: Dick Vigarista - N°: 11223\n*Nome: E.T. Bilú - N°: 34455\n", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txbDescricao_TextChanged(object sender, EventArgs e) { }

        private void DigitaCandidato(object sender, EventArgs e)
        {
            //if(button0.KeyPress())
            //button0.Name;
        }
       
    }
}
