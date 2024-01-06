using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace decola_tech_poo.Models
{
    public class Computador : Object // toda classe herda da classe Object, mesmo que não esteja explícito
    {
        public override string ToString()
        {
            return "Método tostring sobrescrito";
        }
    }
}