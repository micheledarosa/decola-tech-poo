using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace decola_tech_poo.Models
{
    public abstract class Conta  // classe abstrata - serve apenas como modelo para ser herdado
    {
        protected decimal saldo { get; set; }  // protegido de alterações externas, mas as classes filhas podem alterar

        public abstract void Creditar(decimal valor);  // quem herdar da classe conta, terá que implementar o método (polimorfismo)

        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo é: {saldo}.");
        }
    }
}