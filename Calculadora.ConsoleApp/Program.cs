// Requisito 1: Permitir a adição de dois números. 
// Requisito 2: Permitir a subtração de dois números.
// Requisito 3: Permitir a multiplicação de dois números.
// Requisito 4: Permitir a divisão de dois números.
// Requisito 5: Permitir a execução de múltiplas operações. 

bool deveContinuar = true;

while (deveContinuar)
{
  //Console.Clear();
  Console.WriteLine("--------------------------");
  Console.WriteLine("Calculadora 2026");
  Console.WriteLine("--------------------------");

  Console.WriteLine("1 - Adição");
  Console.WriteLine("2 - Subtração");
  Console.WriteLine("3 - Multiplicação");
  Console.WriteLine("4 - Divisão");
  Console.WriteLine("S - Sair");

  Console.WriteLine();

  Console.WriteLine("Selecione uma opção válida: ");
  string operacaoSelecionada = Console.ReadLine();

  if (operacaoSelecionada == "S")
  {
    deveContinuar = false;
    continue;
  }

  Console.Write("Digite o primeiro número: ");
  string strPrimeiroNumero = Console.ReadLine();

  Console.Write("Digite o segundo número: ");
  string strSegundoNumero = Console.ReadLine();

  Console.WriteLine();

  Console.WriteLine("O primeiro número digitado foi: " + strPrimeiroNumero);
  Console.WriteLine("O segundo número digitado foi: " + strSegundoNumero);

  Console.WriteLine();

  int primeiroNumero = Convert.ToInt32(strPrimeiroNumero);
  int segundoNumero = Convert.ToInt32(strSegundoNumero);

  int resultado;

  if (operacaoSelecionada == "1")
  {
    resultado = primeiroNumero + segundoNumero;
  }

  else if (operacaoSelecionada == "2")
  {
    resultado = primeiroNumero - segundoNumero;
  }

  else if (operacaoSelecionada == "3")
  {
    resultado = primeiroNumero * segundoNumero;
  }

  else
  {
    if (segundoNumero == 0)
    {
      Console.WriteLine("Não é possível realizar uma divisão por 0. Tente novamente!");
      return;
    }

    resultado = primeiroNumero / segundoNumero;
  }

  Console.WriteLine("O resultado da operação é: " + resultado);

  Console.ReadLine();
}