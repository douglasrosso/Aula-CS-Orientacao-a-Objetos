using System;

class Pessoa
{

  // Método 01
  public void toPresent()
  {
    Console.WriteLine("Olá");
  }

  // Método 02
  public void toPresent(string name)
  {
    Console.WriteLine($"Olá {name}");
  }

  // Método 03
  public void toPresent(string name, int age)
  {
    Console.WriteLine($"Olá {name}, você tem {age} anos");
  }

}