using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace decola_tech_poo.Models
{
    public class Pessoa
    {
        public Pessoa() // construtor
        {

        }
        public Pessoa(string nome)  // construtor
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        public virtual void Apresentar()  // virtual = polimorfismo (pode sobrescrever o método apresentar)
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}