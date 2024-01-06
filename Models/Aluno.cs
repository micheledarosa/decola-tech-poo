using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace decola_tech_poo.Models
{
    public class Aluno : Pessoa  // herança
    {
        public Aluno()  // não é obrigatório passar o nome
        {
        }

        public Aluno(string nome) : base(nome)
        {
        }

        public double Nota { get; set; }

        public override void Apresentar()  // override = sobrescreva
        {
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} anos e sou um aluno nota {Nota}.");
        }
    }
}