using System;

class Imposto
{
  // Métodos
  // virtual usado para dizer que poderá ser sobrescrito, alterado
  public virtual void valeAlimentacao(double salario)
  {
    Console.WriteLine($"Desconto padrão do vale alimentação R$ {salario * 0.1}");

  }
  public virtual void valeTransporte(double salario)
  {
        Console.WriteLine($"Desconto padrão do vale transporte R$ {salario * 0.06}");

  }
}