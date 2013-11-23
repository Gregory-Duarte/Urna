using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urna.entidades;

namespace Urna.sistema
{
    class ListaEleitores
    {
        Eleitor[] listEleitor = new Eleitor[4];

        string cod = "";

        public ListaEleitores()
        {
            listEleitor[0] = new Eleitor("Super Mario", "12345");
            listEleitor[1] = new Eleitor("Seu Madruga", "54321");
            listEleitor[2] = new Eleitor("Dick Vigarista", "11223");
            listEleitor[3] = new Eleitor("E.T. Bilú", "34455");
        }

        public string MyCod
        {
            get { return cod; }
            set { cod = value; }
        } // MyCod

        public bool IsCodeValid()
        {
            bool valid = false;

            for (int i = 0; i < listEleitor.Length; i++)
            {
                if (cod.Equals(listEleitor[i].MyNumero)) { valid = true; break; }
            }

            return valid;
        }

        public string NomeEleitor()
        {
            string nome = "";

            for (int i = 0; i < listEleitor.Length; i++)
            {
                if (cod.Equals(listEleitor[i].MyNumero)) { nome = listEleitor[i].MyNome; break; }
            }

            return nome;
        }

        public int BrancoTotal() 
        {
            int total = 0;

            for (int i = 0; i < this.listEleitor.Length; i++)
            {
                total += listEleitor[i].TotalBrancos();
            }

            return total;
        }

    }
}
