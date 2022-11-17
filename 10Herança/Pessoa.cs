using System;

class People
{
  // Atributos
  protected string name;
  protected int age;

  // Método
  protected void messagePeople()
  {
    Console.WriteLine($"Nome: {name}");
    Console.WriteLine($"Idade: {age}");
  }


}