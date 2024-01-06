using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using decola_tech_poo.Interfaces;

namespace decola_tech_poo.Models
{
    public class Calculadora : ICalculadora  // implementando a interface calculadora (não é herdar)
    {
        public int Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;      
        }

        public int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;       
        }

        public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;     
        }

        public int Subtrair(int numero1, int numero2)
        {
            return numero1 - numero2;     
        }
    }
}