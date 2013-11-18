﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna.entidades
{
    class Presidente
    {
        private int votos = 0;
        private string nome;
        private string numero;

        public Presidente(string nome, string numero)
        {
            this.MyNome = nome;
            this.MyNumero = numero;
        }

        public void IncrementaVotos() { votos++; }

        public int MyVotos
        {
            get { return votos; }
            set { votos = value; }
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
    }
}
