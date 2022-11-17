using System;

class Aluno
{

  // Atributos
  public string name;
  public double gradeOne, gradeTwo;

  // Média
  public double average()
  {
    return (gradeOne+gradeTwo)/2;
  }

  // Situação
  public string situation(double average)
  {
    return average >= 7 ? "Aprovado" : "Reprovado";
  }

  // Mensagem
  public void message()
  {
    // Obter a média
    double getAverage = average();

    // Obter a situação
    string getSituation = situation(getAverage);

    // Mensagem
    Console.WriteLine($"{name} está {getSituation}, com média {getAverage}");
  }

}