using decola_tech_poo.Models;
using decola_tech_poo.Interfaces;

ICalculadora calculadora = new Calculadora();  // criando uma calculadora que utiliza a interface calculadora
Console.WriteLine(calculadora.Multiplicar(3, 9));















/*
Computador computador = new Computador();
Console.WriteLine(computador.ToString());
*/


/*
Pessoa pessoa1 = new Pessoa("Michele");
Aluno aluno1 = new Aluno("Jean");
aluno1.Apresentar();
*/


/*
Corrente corrente = new Corrente();
corrente.Creditar(500);
corrente.ExibirSaldo();
*/


/*
// EXEMPLO HERANÇA
Aluno aluno1 = new Aluno
{
    Nome = "Michele",
    Idade = 29,
    Email = "micheledarosa.dev@gmail.com",
    Nota = 10
};
aluno1.Apresentar();

Professor professor1 = new Professor
{
    Nome = "Jean",
    Idade = 23,
    Salario = 1000   
};
professor1.Apresentar();
*/


/*
ContaCorrente c1 = new ContaCorrente(123, 1000);

c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();
*/


/*
Pessoa p1 = new Pessoa();
p1.Nome = "Michele";
p1.Idade = 29;

p1.Apresentar();
*/