using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace decola_tech_poo.Models
{
    public class Professor : Pessoa  
    {
        public Professor()
        {
        }

        public Professor(string nome) : base(nome)  // como se estivesse utilizando o nome da classe pai(pessoa)
        {
        }

        public decimal Salario { get; set; }

        public sealed override void Apresentar()  // método sealed = não pode sobrescrever esse método
        {
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} anos, sou um professor e ganho R${Salario}.");
        }
    }
}