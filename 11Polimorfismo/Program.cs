using System;

class Program
{
  static void Main()
  {
    // Instânciar Estagiário
    Imposto objetoE = new Estagiario();
    objetoE.valeAlimentacao(1000);
    objetoE.valeTransporte(1000);
    Console.WriteLine("------------------------");

    // Instânciar Gerente
    Imposto objetoG = new Gerente();
    objetoG.valeAlimentacao(5000);
    objetoG.valeTransporte(5000);
    Console.WriteLine("------------------------");

    // Instânciar Atendente
    Imposto objetoA = new Atendente();
    objetoA.valeAlimentacao(2000);
    objetoA.valeTransporte(2000);
    Console.WriteLine("------------------------");
  }
}