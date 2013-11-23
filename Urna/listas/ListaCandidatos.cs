using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urna.entidades;

namespace Urna.sistema
{
    class ListaCandidatos
    {
        private DeputadoEst[] depEst = new DeputadoEst[4];
        private DeputadoFed[] depFed = new DeputadoFed[4];
        private Governador[] gov = new Governador[4];
        private Presidente[] pres = new Presidente[4];
        private Senador[] sen = new Senador[4];

        private string cod;

        public ListaCandidatos()
        {
            depEst[0] = new DeputadoEst("Branco", "00000", 0);
            depEst[1] = new DeputadoEst("João Mentira", "11111", 0);
            depEst[2] = new DeputadoEst("Zé Preguiça", "22222", 0);
            depEst[3] = new DeputadoEst("Falastrão da Silva", "33333", 0);

            depFed[0] = new DeputadoFed("Branco", "0000", 0);
            depFed[1] = new DeputadoFed("Falsino Soares", "1111", 0);
            depFed[2] = new DeputadoFed("Edu Ente Souto", "2222", 0);
            depFed[3] = new DeputadoFed("Medonho Lopes", "3333", 0);

            sen[0] = new Senador("Branco", "000", 0);
            sen[1] = new Senador("Bizoño Ordoñez", "111", 0);
            sen[2] = new Senador("Cretino Sérgio", "222", 0);
            sen[3] = new Senador("Jacques Pertallón", "333", 0);

            gov[0] = new Governador("Branco", "00", 0);
            gov[1] = new Governador("Álvaro Senvergoña", "11", 0);
            gov[2] = new Governador("Nestor Quindo", "22", 0);
            gov[3] = new Governador("Thaís Condendo", "33", 0);

            pres[0] = new Presidente("Branco", "00", 0);
            pres[1] = new Presidente("Vouty Hubá", "11", 0);
            pres[2] = new Presidente("Dilma Figa Ruçefi", "22", 0);
            pres[3] = new Presidente("Luís Ignácio Mula da Silva", "33", 0);
        } // ListaCandidatos();

        public string MyCod
        {
            get { return cod; }
            set { cod = value; }
        } // MyCod

        public bool IsCodeValidDE()
        {
            bool valid = false;

            for (int i = 0; i < depEst.Length; i++)
            {
                if (cod.Equals(depEst[i].MyNumero)) { valid = true; break; }
            }

            return valid;
        } // IsCodeValidDE();

        public bool IsCodeValidDF()
        {
            bool valid = false;

            for (int i = 0; i < depFed.Length; i++)
            {
                if (cod.Equals(depFed[i].MyNumero)) { valid = true; break; }
            }

            return valid;
        } // IsCodeValidDF();

        public bool IsCodeValidSen()
        {
            bool valid = false;

            for (int i = 0; i < sen.Length; i++)
            {
                if (cod.Equals(sen[i].MyNumero)) { valid = true; break; }
            }

            return valid;
        } // IsCodeValidSen();

        public bool IsCodeValidGov()
        {
            bool valid = false;

            for (int i = 0; i < gov.Length; i++)
            {
                if (cod.Equals(gov[i].MyNumero)) { valid = true; break; }
            }

            return valid;
        } // IsCodeValidGov();

        public bool IsCodeValidPres()
        {
            bool valid = false;

            for (int i = 0; i < pres.Length; i++)
            {
                if (cod.Equals(pres[i].MyNumero)) { valid = true; break; }
            }

            return valid;
        } // IsCodeValidPres();

        public string NomeDE()
        {
            string nome = "";

            for (int i = 0; i < depEst.Length; i++)
            {
                if (cod.Equals(depEst[i].MyNumero)) { nome = depEst[i].MyNome; break; }
            }

            return nome;
        } // NomeDE();

        public string NomeDF()
        {
            string nome = "";

            for (int i = 0; i < depFed.Length; i++)
            {
                if (cod.Equals(depFed[i].MyNumero)) { nome = depFed[i].MyNome; break; }
            }

            return nome;
        } // NomeDF();

        public string NomeSen()
        {
            string nome = "";

            for (int i = 0; i < sen.Length; i++)
            {
                if (cod.Equals(sen[i].MyNumero)) { nome = sen[i].MyNome; break; }
            }

            return nome;
        } // NomeSen();

        public string NomeGov()
        {
            string nome = "";

            for (int i = 0; i < gov.Length; i++)
            {
                if (cod.Equals(gov[i].MyNumero)) { nome = gov[i].MyNome; break; }
            }

            return nome;
        } // NomeGov();

        public string NomePres()
        {
            string nome = "";

            for (int i = 0; i < pres.Length; i++)
            {
                if (cod.Equals(pres[i].MyNumero)) { nome = pres[i].MyNome; break; }
            }

            return nome;
        } // NomePres();

        public string NumeroDE()
        {
            string numero = "";

            for (int i = 0; i < depEst.Length; i++)
            {
                if (cod.Equals(depEst[i].MyNumero)) { numero = depEst[i].MyNumero; break; }
            }

            return numero;
        } // NumeroDE();

        public string NumeroDF()
        {
            string numero = "";

            for (int i = 0; i < depFed.Length; i++)
            {
                if (cod.Equals(depFed[i].MyNumero)) { numero = depFed[i].MyNumero; break; }
            }

            return numero;
        } // NumeroDF();

        public string NumeroSen()
        {
            string numero = "";

            for (int i = 0; i < sen.Length; i++)
            {
                if (cod.Equals(sen[i].MyNumero)) { numero = sen[i].MyNumero; break; }
            }

            return numero;
        } // NumeroSen();

        public string NumeroGov()
        {
            string numero = "";

            for (int i = 0; i < gov.Length; i++)
            {
                if (cod.Equals(gov[i].MyNumero)) { numero = gov[i].MyNumero; break; }
            }

            return numero;
        } // NumeroGov();

        public string NumeroPres()
        {
            string numero = "";

            for (int i = 0; i < pres.Length; i++)
            {
                if (cod.Equals(pres[i].MyNumero)) { numero = pres[i].MyNumero; break; }
            }

            return numero;
        } // NumeroPres();

        public int VotosDE()
        {
            int voto = 0;

            for (int i = 0; i < depEst.Length; i++)
            {
                if (cod.Equals(depEst[i].MyNumero)) { voto = depEst[i].MyVotos; break; }
            }

            return voto;
        } // VotosDE();

        public int VotosDF()
        {
            int voto = 0; ;

            for (int i = 0; i < depFed.Length; i++)
            {
                if (cod.Equals(depFed[i].MyNumero)) { voto = depFed[i].MyVotos; break; }
            }

            return voto;
        } // VotosDF();

        public int VotosSen()
        {
            int voto = 0;

            for (int i = 0; i < sen.Length; i++)
            {
                if (cod.Equals(sen[i].MyNumero)) { voto = sen[i].MyVotos; break; }
            }

            return voto;
        } // VotosSen();

        public int VotosGov()
        {
            int voto = 0;

            for (int i = 0; i < gov.Length; i++)
            {
                if (cod.Equals(gov[i].MyNumero)) { voto = gov[i].MyVotos; break; }
            }

            return voto;
        } // VotosGov();

        public int VotosPres()
        {
            int voto = 0;

            for (int i = 0; i < pres.Length; i++)
            {
                if (cod.Equals(pres[i].MyNumero)) { voto = pres[i].MyVotos; break; }
            }

            return voto;
        } // VotosPres();

        public void SomaVotosDE(string value)
        {
            for (int i = 0; i < depEst.Length; i++)
            {
                if (value.Equals(depEst[i].MyNumero)) { depEst[i].IncrementaVotos(); break; }
            }
        } // SomaVotosDE();

        public void SomaVotosDF(string value)
        {
            for (int i = 0; i < depFed.Length; i++)
            {
                if (value.Equals(depFed[i].MyNumero)) { depFed[i].IncrementaVotos(); break; }
            }
        } // SomaVotosDF();

        public void SomaVotosSen(string value)
        {
            for (int i = 0; i < sen.Length; i++)
            {
                if (value.Equals(sen[i].MyNumero)) { sen[i].IncrementaVotos(); break; }
            }
        } // SomaVotosSen();

        public void SomaVotosGov(string value)
        {
            for (int i = 0; i < gov.Length; i++)
            {
                if (value.Equals(gov[i].MyNumero)) { gov[i].IncrementaVotos(); break; }
            }
        } // SomaVotosGov();

        public void SomaVotosPres(string value)
        {
            for (int i = 0; i < pres.Length; i++)
            {
                if (value.Equals(pres[i].MyNumero)) { pres[i].IncrementaVotos(); break; }
            }
        } // SomaVotosPres();
    }
}
