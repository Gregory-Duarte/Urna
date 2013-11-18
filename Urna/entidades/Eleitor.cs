using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna.entidades
{
    class Eleitor
    {
        private string nome;
        private string numero;
        private bool statusVoto = false;
        private int nulos = 0;

	    private Presidente presidente;
	    private Governador governador;
	    private Senador senador1;
        private Senador senador2;
	    private DeputadoFed deputadoFederal;
        private DeputadoEst deputadoEstadual;

        private bool brancoPresidente = false;
        private bool brancoGovernado = false;
        private bool brancoSenador1 = false;
        private bool brancoSenador2 = false;
        private bool brancoDeputadoFederal = false;
        private bool brancoDeputadoEstadual = false;

        private bool senador1_OK = false;

        public Eleitor(string nome, string numero) 
        {
            this.MyNome = nome;
            this.MyNumero = numero;
        }

        public string MyNome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string MyNumero
        {
            get { return numero; }
            set { numero = value; }
        }

        public bool IsStatusVoto
        {
            get { return statusVoto; }
            set { statusVoto = value; }
        }

        public int MyNulos
        {
            get { return nulos; }
            set { nulos = value; }
        }

        public Presidente Mypresidente
        {
            get { return presidente; }
            set { presidente = value; }
        }

        public Governador MyGovernador
        {
            get { return governador; }
            set { governador = value; }
        }

        public Senador MySenador1
        {
            get { return senador1; }
            set { senador1 = value; }
        }

        public Senador MySenador2
        {
            get { return senador2; }
            set { senador2 = value; }
        }

        public DeputadoFed MyDeputadoFederal
        {
            get { return deputadoFederal; }
            set { deputadoFederal = value; }
        }

        public DeputadoEst MyDeputadoEstadual
        {
            get { return deputadoEstadual; }
            set { deputadoEstadual = value; }
        }

        public bool IsSenador1_OK
        {
            get { return senador1_OK; }
            set { senador1_OK = value; }
        }

        public bool IsBrancoPresidente
        {
            get { return brancoPresidente; }
            set { brancoPresidente = value; }
        }

        public bool IsBrancoGovernado
        {
            get { return brancoGovernado; }
            set { brancoGovernado = value; }
        }

        public bool IsBrancoSenador1
        {
            get { return brancoSenador1; }
            set { brancoSenador1 = value; }
        }

        public bool IsBrancoSenador2
        {
            get { return brancoSenador2; }
            set { brancoSenador2 = value; }
        }

        public bool IsBrancoDeputadoFederal
        {
            get { return brancoDeputadoFederal; }
            set { brancoDeputadoFederal = value; }
        }

        public bool IsBrancoDeputadoEstadual
        {
            get { return brancoDeputadoEstadual; }
            set { brancoDeputadoEstadual = value; }
        }

        public int TotalBrancos()
        {
            int contBranco = 0;

            if (IsBrancoPresidente == false) { contBranco++; }
            if (IsBrancoGovernado == false) { contBranco++; }
            if (IsBrancoSenador1 == false) { contBranco++; }
            if (IsBrancoSenador2 == false) { contBranco++; }
            if (IsBrancoDeputadoFederal == false) { contBranco++; }
            if (IsBrancoDeputadoEstadual == false) { contBranco++; }

            return contBranco;
        }
    }
}
