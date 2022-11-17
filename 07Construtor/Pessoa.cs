using System;

class Pessoa
{
  // Construtores
  public Pessoa()
  {
    // Construtor 1
    Console.WriteLine("Construtor executado");
  }
  public Pessoa(string name)
  {
    // Construtor 2
    Console.WriteLine($"Olá {name}");
  }

}