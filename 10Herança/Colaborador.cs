using System;
// Não existe herança multipla em C#
class Collaborator : People
{
  //Atributos
  private double wage;
  private int faults;

  // Construtor 
  public Collaborator(string name, int age, int faults, double wage)
  {
    this.name = name;
    this.age = age;
    this.wage = wage;
    this.faults = faults;

    messagePeople();
    messageCollaborator();
  }

  // Método
  private void messageCollaborator()
  {
    Console.WriteLine($"Sálario: {wage}");
    Console.WriteLine($"Faltas: {faults}");
  }
}