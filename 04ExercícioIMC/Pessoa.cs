using System;

class Pessoa
{
  public string name;
  public double weight, height;

  public double calculation()
  {
    return weight / (height * height);
  }

  public string situation(double calculation)
  {
    string retorno;

    if (calculation < 18.5)
    {
      retorno = "Abaixo do peso";
    }
    else if (calculation < 25)
    {
      retorno = "Peso normal";
    }
    else if (calculation < 30)
    {
      retorno = "Acima do peso";
    }
    else if (calculation < 35)
    {
      retorno = "Obesidade 1";
    }
    else if (calculation < 40)
    {
      retorno = "Obesidade 2";
    }
    else
    {
      retorno = "Obesidade 3";
    }
    return retorno;
  }

  public void message()
  {
    double getCalc = calculation();

    string getSituation = situation(getCalc);

    Console.WriteLine($"{name}, está com o IMC de {getCalc.ToString("F")} e está {getSituation}.");
  }
}