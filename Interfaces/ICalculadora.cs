using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace decola_tech_poo.Interfaces
{
    public interface ICalculadora  // por convenção sempre se coloca o "I" de interface
    {
       int Somar(int numero1, int numero2); 
       int Subtrair(int numero1, int numero2); 
       int Multiplicar(int numero1, int numero2);  // método sem corpo é obrigatório implementar
       int Dividir(int numero1, int numero2)  // métodos com corpo são opcionais para implementação
       {
            return numero1 / numero2;
       } 
    }
}