using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("----------------------------------------------");
    PessoaFisica pf = new PessoaFisica();
    pf.taxaEmprestimo(1000);
    Console.WriteLine("----------------------------------------------");
    PessoaJuridica pj = new PessoaJuridica();
    pj.taxaEmprestimo(1000);
    Console.WriteLine("----------------------------------------------");
  }
}