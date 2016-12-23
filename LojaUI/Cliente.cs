using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto
{
    public class Cliente
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { Nome = value; }
        }

        private string cc;
        public string CC
        {
            get { return cc; }
            set { cc = value; }
        }

        private int nif;
        public int Nif
        {
            get { return nif; }
            set { nif = value; }
        }

        private string morada;
        public string Morada
        {
            get { return morada; }
            set { morada = value; }
        }

        private int telemovel;
        public int Telemovel
        {
            get { return telemovel; }
            set { telemovel = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private Cartao_de_Cliente cartao;
        public Cartao_de_Cliente Cartao
        {
            get { return cartao; }
            set { cartao = value; }
        }



        public Cliente(string nome, string cc, int NIF, string morada, int tlm, string email)
        {
            this.nome = nome;
            this.CC = cc;
            this.nif = NIF;
            this.morada = morada;
            this.telemovel = tlm;
            this.email = email;
            this.cartao = new Cartao_de_Cliente();
        }
    }
}
