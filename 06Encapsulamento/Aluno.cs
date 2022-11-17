using System;

class Aluno
{

  // Atributos
  private double gradeOne, gradeTwo;

  // Média
  private double average()
  {
    return (gradeOne + gradeTwo) / 2;
  }

  // Mensagem
  public void message()
  {
    Console.Write("informe a primeira nota: ");
    gradeOne = Convert.ToInt32(Console.ReadLine());

    Console.Write("informe a segunda nota: ");
    gradeTwo = Convert.ToInt32(Console.ReadLine());

    Console.Write($"A média é {average()}");
  }
}