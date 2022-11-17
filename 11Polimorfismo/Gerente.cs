using System;

class Gerente : Imposto
{
  // Método
  // overrride usado para dizer, que poderá alterar informações
  public override void valeAlimentacao(double salario)
  {
    Console.WriteLine($"Desconto gerente do vale alimentação R$ {salario * 0.15}");
  }
}