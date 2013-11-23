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
        private ListaEleitores listaEleitores = new ListaEleitores();
        private ListaCandidatos listaCandidatos = new ListaCandidatos();
        private Eleitor eleitor = new Eleitor();
        private Presidente pres = new Presidente();
        private Senador sen = new Senador();
        private Governador gov = new Governador();
        private DeputadoFed depFed = new DeputadoFed();
        private DeputadoEst depEst = new DeputadoEst();

        private int indexName = 0;
        private string nomeE;
        private string nomeP;
        private string numeroP;
        private int votosP;
        private string[,] pilantraList = new string[5,2]
                                        {
                                            {"Presidente: XX", "2"},
                                            {"Senador: XXX", "3"},
                                            {"Governador: XX", "2"},
                                            {"Deputado Estadual: XXXXX", "5"},
                                            {"Deputado Federal: XXXX", "4"}
                                        };

        public string MyNomeP
        {
            get { return nomeP; }
            set { nomeP = value; }
        } // MyNomeP
        
        public string MyNumeroP
        {
            get { return numeroP; }
            set { numeroP = value; }
        } // MyNumeroP

        public int MyVotosP
        {
            get { return votosP; }
            set { votosP = value; }
        } // MyVotosP

        
        public Tela() { InitializeComponent(); }

        public void NoBlockKeyboard(bool isBloqueado = false)
        {
            txtNumero.Enabled = !isBloqueado;
            btnIniciar.Enabled = !isBloqueado;

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
        } // NoBlockKeyboard();

        private void Form1_Load(object sender, EventArgs e)
        {
            NoBlockKeyboard(false);

            //pilantraList[0] = "Presidente: XX";
            //pilantraList[1] = "Senador: XXX";
            //pilantraList[2] = "Governador: XX";
            //pilantraList[3] = "Deputado Estadual: XXXXX";
            //pilantraList[4] = "Deputado Federal: XXXX";
        } // Form1_Load();

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            listaEleitores.MyCod = txtNumero.Text;

            if (listaEleitores.IsCodeValid() == true)
            {
                nomeE = listaEleitores.NomeEleitor();

                lblNome.Text = "Nome: " + nomeE;
                lblPilantra.Text = pilantraList[indexName, 0];

                NoBlockKeyboard(true);
            }
            else { MessageBox.Show("Código de eleitor invalido.\n"
                + "\n*N°: 12345 - Nome: Super Mario"
                + "\n*N°: 54321 - Nome: Seu Madruga"
                + "\n*N°: 11223 - Nome: Dick Vigarista"
                + "\n*N°: 34455 - Nome: E.T. Bilú", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // btnIniciar_Click();

        private void button0_Click(object sender, EventArgs e) { txbDescricao.Text = txbDescricao.Text + "0"; VerificaDigitos(); }

        private void button1_Click(object sender, EventArgs e) { txbDescricao.Text = txbDescricao.Text + "1"; VerificaDigitos(); }

        private void button2_Click(object sender, EventArgs e) { txbDescricao.Text = txbDescricao.Text + "2"; VerificaDigitos(); }

        private void button3_Click(object sender, EventArgs e) { txbDescricao.Text = txbDescricao.Text + "3"; VerificaDigitos(); }

        private void button4_Click(object sender, EventArgs e) { txbDescricao.Text = txbDescricao.Text + "4"; VerificaDigitos(); }

        private void button5_Click(object sender, EventArgs e) { txbDescricao.Text = txbDescricao.Text + "5"; VerificaDigitos(); }

        private void button6_Click(object sender, EventArgs e) { txbDescricao.Text = txbDescricao.Text + "6"; VerificaDigitos(); }

        private void button7_Click(object sender, EventArgs e) { txbDescricao.Text = txbDescricao.Text + "7"; VerificaDigitos(); }

        private void button8_Click(object sender, EventArgs e) { txbDescricao.Text = txbDescricao.Text + "8"; VerificaDigitos(); }

        private void button9_Click(object sender, EventArgs e) { txbDescricao.Text = txbDescricao.Text + "9"; VerificaDigitos(); }

        private void btnBranco_Click(object sender, EventArgs e) { txbDescricao.Text = "00"; }

        private void btnCorrige_Click(object sender, EventArgs e) { txbDescricao.Text = ""; }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            listaCandidatos.MyCod = txbDescricao.Text;

            switch (indexName)
            {
                case 0: // Presidente
                    {
                        listaCandidatos.SomaVotosPres(this.MyNumeroP);
                        txbDescricao.Text = "";
                        this.MyNumeroP = "";
                        break;
                    }

                case 1: // Senador
                    {
                        listaCandidatos.SomaVotosSen(this.MyNumeroP);
                        txbDescricao.Text = "";
                        this.MyNumeroP = "";
                        break;
                    }

                case 2: // Governador
                    {
                        listaCandidatos.SomaVotosGov(this.MyNumeroP);
                        txbDescricao.Text = "";
                        this.MyNumeroP = "";
                        break;
                    }

                case 3: // Deputado Estadual
                    {
                        listaCandidatos.SomaVotosDE(this.MyNumeroP);
                        txbDescricao.Text = "";
                        this.MyNumeroP = "";
                        break;
                    }

                case 4: // Deputado Federal
                    {
                        listaCandidatos.SomaVotosDF(this.MyNumeroP);
                        txbDescricao.Text = "";
                        this.MyNumeroP = "";
                        break; 
                    }

                default: { txbDescricao.Text = "Valor invalido."; break; }
            }

            indexName++;
            lblPilantra.Text = pilantraList[indexName, 0];

            if(indexName >= 4)
            {
                indexName = 0;
                lblPilantra.Text = "(Cargo)";
                //txbDescricao.Text = "FIM";
                //MostraTotais();
                NoBlockKeyboard(false);
                txtNumero.Text = "";
            }
        } // btnConfirma_Click();

        public void MostraTotais()
        {
            txbDescricao.Text = "Braco: " + listaEleitores.BrancoTotal()
                                + " Presidente: " + pres.MyVotos
                                + " Senador: " + sen.votos
                                + " Governador: " + listaCandidatos.VotosGov()
                                + " Deputado Estadual: " + listaCandidatos.VotosDE()
                                + " Deputado Federal: " + listaCandidatos.VotosDF()
                                + " Total de votos: ";

            NoBlockKeyboard(false);
            txtNumero.Text = "";
        } // MostraTotais();

        public void VerificaDigitos()
        {
            if(txbDescricao.Text.Length > Int32.Parse(pilantraList[indexName, 1]))
            {

                MessageBox.Show("Numero digitado fora do padrão", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbDescricao.Text = "";
            }

            if (txbDescricao.Text.Length == Int32.Parse(pilantraList[indexName, 1]))
            {
                listaCandidatos.MyCod = txbDescricao.Text;

                if ((lblPilantra.Text == "Presidente: XX") && (listaCandidatos.IsCodeValidPres() == true))
                {
                    this.MyNomeP = listaCandidatos.NomePres();
                    this.MyNumeroP = listaCandidatos.NumeroPres();

                    txbDescricao.Text = "N°: " + numeroP + " Nome: " + nomeP;
                }

                if ((lblPilantra.Text == "Senador: XXX") && (listaCandidatos.IsCodeValidSen() == true))
                {
                    this.MyNomeP = listaCandidatos.NomeSen();
                    this.MyNumeroP = listaCandidatos.NumeroSen();

                    txbDescricao.Text = "N°: " + numeroP + " Nome: " + nomeP;
                }

                if ((lblPilantra.Text == "Governador: XX") && (listaCandidatos.IsCodeValidGov() == true))
                {
                    this.MyNomeP = listaCandidatos.NomeGov();
                    this.MyNumeroP = listaCandidatos.NumeroGov();

                    txbDescricao.Text = "N°: " + numeroP + " Nome: " + nomeP;
                }

                if ((lblPilantra.Text == "Deputado Estadual: XXXXX") && (listaCandidatos.IsCodeValidDE() == true))
                {
                    this.MyNomeP = listaCandidatos.NomeDE();
                    this.MyNumeroP = listaCandidatos.NumeroDE();

                    txbDescricao.Text = "N°: " + numeroP + " Nome: " + nomeP;
                }

                if ((lblPilantra.Text == "Deputado Federal: XXXX") && (listaCandidatos.IsCodeValidDF() == true))
                {
                    this.MyNomeP = listaCandidatos.NomeDF();
                    this.MyNumeroP = listaCandidatos.NumeroDF();

                    txbDescricao.Text = "N°: " + numeroP + " Nome: " + nomeP;
                }
            }
        } // VerificaDigitos();
    }
}
