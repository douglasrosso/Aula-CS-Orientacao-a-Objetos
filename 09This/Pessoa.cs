using System;

class Pessoa
{
  // Atributo 
  private string name = "Ana";

  // Construtor
  public Pessoa(string name)
  {

    // Chamar um argumento
    Console.WriteLine(name);

    // Chamar um atributo
    Console.WriteLine(this.name);
  
  }

}