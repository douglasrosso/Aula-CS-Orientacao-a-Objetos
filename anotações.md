
-Aloca um padrão do tipo, ano, mês, dia, hora, min, segundo
DateTime

-Inteiro do tipo positivo apenas
uint

-Inteiro do tipo positivo apenas
ulong

-Boolean, true ou false
bool 

-Caracter UTF-16, ou seja uma letra do alfabeto
char

-Valor sem sinal de 8bits, 0 e 255 valor máximo
byte

-Inteiro de 32bits, cujo aceita números positivos e negativos
int

-Inteiro de 64bits, aceita números muito grandes
long

-Números quebrados, decimais
float

-Números quebrados, decimais maiores
double

-Usado para moeda, números quebrados
decimal

-Sequência de ccaracteres UTF-16
string

-C# é uma linguagem estática, pois as variáveis são 
declaradas ja com o tipo dela

-Concatenar
Console.WriteLine($"Olá {name}!");
 ou
Console.WriteLine("Olá " + name);

-Conversão de recebimento de string para number
-int.parse(), transforma em número
int year = int.Parse(Console.ReadLine());

-------------------------------------------------------------------------------

EX1:
class Program
{
  static void Main()
  {
    Console.Write("Digite seu nome: ");
    String name = Console.ReadLine();
    Console.WriteLine($"Olá {name}!");
    Console.Write("Digite o ano do seu nascimento: ");
    int year = int.Parse(Console.ReadLine());
    int age = 2022 - year;
  Console.WriteLine($"Você tem {age} anos.");

    if (age >= 18) {
     Console.WriteLine("Você é maior de idade.");
    }
    else {
      Console.WriteLine("Você é menor de idade");
    }

  }
}

ou

class Program
{
  static void Main()
  {
    string[] names = {"Fredi", "Ana", "Pedro", "João"};  

    foreach (var name in names)
    {
      Console.WriteLine(name);
    }

  }
}

-----------------------------------------------------------------------------

-Array 
string[] names = {"Fredi", "Ana"};

-----------------------------------------------------------------------------

Ex1:
class Program
{
  static void Main()
  {
    string[] names = {"Fredi", "Ana", "Pedro"};  

    for (int i = 0; i < names.Length; i++)
    {
      Console.WriteLine(names[i]);
    }

  }
}
Console ==== 
Fredi
Ana
Pedro
--------------------------------------------------------------------------

-Menu que ignora letras maiusculas
class Program
{
  static void Main()
  {
    string[] names = {"Fredi", "Ana", "Pedro", "João"};  
    if (string.Equals(names[0], "fredi", StringComparison.OrdinalIgnoreCase))
    foreach (var name in names)
    {
      Console.WriteLine(name);
    }
  }
}
Console ==== True
-----------------------------------------------------------------------------

-Verificar ultimo digito, e retornar true ou false
class Program
{
  static void Main()
  {
    string name = "Fredi"; 
    Console.WriteLine(name.EndsWith("a"));
  }
}
Console ==== False
------------------------------------------------------------------------------

-Caso a string contenha o caracter
class Program
{
  static void Main()
  {
    string name = "Fredi"; 
    Console.WriteLine(name.Contains("a"));
  }
}
Console ==== False
------------------------------------------------------------------------------

-caracter separador tanto caracter quanto sinal ou espaço de uma string a outra
class Program
{
  static void Main()
  {
    string name = "Douglas"; 
    string[] names = {"Douglas", "Rosso"};
    Console.WriteLine(string.Join(' ', names));
  }
}
Console ==== Douglas Rosso
--------------------------------------------------------------------------
-Verifica se o número é do tipo number inteiro, e recebe o valor
class Program
{
  static void Main()
  {
    int.TryParse("23", out int x);
    Console.WriteLine(x);
  }

}
Console ===== 23
-------------------------------------------------------
class Program
{
  static void Main()
  {
    if (int.TryParse("23", out int x))
    {
      Console.WriteLine("Verdadeiro");
    } else {
      Console.WriteLine("Falso");
    }
    Console.WriteLine(x);
  }
}
Console ===== True
------------------------------------------------------------------------------
-Transformar uma varialvel(numerica ou demais) para string
class Program
{
  static void Main()
  {
    long l = 19308594287252;
    string s = l.ToString();
    Console.WriteLine(s);
  }
}
-------------------------------------------------------------------------------
-tratamento de excessão / erro
class Program
{
  static void Main()
  {
    //string esta recebendo valor nulo
    string s = null;
    // na hora de validar, vai para o catch
    try
    {
      Console.WriteLine(s.Length);
    }
    catch (System.NullReferenceException)
    {
      Console.WriteLine("Erro de referência nula.");
    }
  }
}
Console ==== Erro de referência nula.
----------------------------------------------------------------

-Limitar numero de casas decimais
double valor =  2.123455909;
MessageBox.Show(valor.ToString("F")); // 2,12COPIAR CÓDIGO
Já o "C", de currency, exibe como se fosse um valor monetário:

-inserir R$
double valor = 2.123455909;
MessageBox.Show(valor.ToString("C")); // R$ 2,12


-Site que mostra a função do array ou de objeto
https://sharplab.io/
