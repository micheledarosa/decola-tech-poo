using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace decola_tech_poo.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(decimal valor)  // implementar o método Creditar para obedecer as regras do método abstrato Conta
        {
            saldo += valor;
        }
    }
}