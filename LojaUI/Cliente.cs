using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CC { get; set; }
        public int Nif { get; set; }
        public string Morada { get; set; }
        public int Telemovel { get; set; }
        public string Email { get; set; }
        public Cartao_de_Cliente Cartao { get; set; }



        public Cliente(string nome, string cc, int NIF, string morada, int tlm, string email)
        {
            this.Nome = nome;
            this.CC = cc;
            this.Nif = NIF;
            this.Morada = morada;
            this.Telemovel = tlm;
            this.Email = email;
            this.Cartao = new Cartao_de_Cliente();
        }
    }
}
