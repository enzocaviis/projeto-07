static double modulo(double n1) => Math.Abs(n1);
static double raizquadrada(double n1) => Math.Sqrt(n1);
static double potencia(double n1, int n3) => Math.Pow(n1, n3);
static double raizdiversa(double n1, int n3) => Math.Pow(n1, 1.0 / n3);
static double min(double n1, double n2) => Math.Min(n1, n2);
static double max(double n1, double n2) => Math.Max(n1, n2);

int contador = 0, index1 = 0, index2 = 0, n3 = 0;
string? msg1 = "Bem-vindo(a) a classe Math!";
string? msg2 = "Informe o indice da função que você quer ultilizar:\n1-Módulo\n2-Raiz quadrada\n3-Potenciação\n4-Raiz diversa\n5-Menor entre dois numeros\n6-Maior entre dois números\nOpção: ";
string? msg3 = "Informe o indice da ação que você quer executar:\n1-Executar uma nova ação\n2-Sair\nOpçâo: ";
double n1 = 0, n2 = 0;

try
{

    do
    {

        Console.Clear();
        Console.Write($"{msg1}\n{msg2}");
        index1 = int.Parse(Console.ReadLine());

        while (index1 < 1 || index1 > 6)
        {
            Console.Clear();
            Console.Write($"O indice {index1} não é valido informe novamente:\n{msg2}");
            index1 = int.Parse(Console.ReadLine());
        }

        Console.Clear();
        switch (index1)
        {

            case 1:
                Console.Write("Informe um numero para obter seu módulo: ");
                n1 = double.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine($"Resultado:\nMódulo de {n1} = {modulo(n1)}");
                break;

            case 2:
                Console.Write("Informe o radicando da raiz quadrada: ");
                n1 = double.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine($"Resultado:\nRaiz quadrada de {n1} = {raizquadrada(n1)}");
                break;

            case 3:
                Console.Write("Informe a base da potência: ");
                n1 = double.Parse(Console.ReadLine());
                Console.Write("Informe o expoente da potência: ");
                n3 = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine($"Resultado:\n{n1} elevado a {n3}º potencia = {potencia(n1, n3)}");
                break;

            case 4:
                Console.Write("Informe o radicando da raiz: ");
                n1 = double.Parse(Console.ReadLine());
                Console.Write("Informe o indice da raiz: ");
                n3 = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine($"Resultado:\nRaiz {n3}º de {n1} = {raizdiversa(n1, n3)}");
                break;

            case 5:
                Console.Write("Informe o numero 1: ");
                n1 = double.Parse(Console.ReadLine());
                Console.Write("Informe o numero 2: ");
                n2 = double.Parse(Console.ReadLine());
                Console.Clear();
                if (n1 != n2)
                {
                    Console.WriteLine($"Resultado:\nO numero {min(n1, n2)} é menor do que o numero {max(n1, n2)}");
                }
                else
                {
                    Console.WriteLine($"Resultado:\nO numero {n1} é igual ao numero {n2}");
                }
                break;

            case 6:
                Console.Write("Informe o numero 1: ");
                n1 = double.Parse(Console.ReadLine());
                Console.Write("Informe o numero 2: ");
                n2 = double.Parse(Console.ReadLine());
                Console.Clear();
                if (n1 != n2)
                {
                    Console.WriteLine($"Resultado:\nO numero {max(n1, n2)} é maior do que o numero {min(n1, n2)}");
                }
                else
                {
                    Console.WriteLine($"Resultado:\nO numero {n1} é igual ao numero {n2}");
                }
                break;

        }

        Console.Write($"\n{msg3}");
        index2 = int.Parse(Console.ReadLine());

        while (index2 < 1 || index2 > 2)
        {
            Console.Clear();
            Console.Write($"O indece informado {index2} não é valido, informe novamente:\n{msg3}");

        }

        msg1 = "Ola denovo!";

    } while (index2 == 1);

}
catch (Exception ex)
{
    Console.Clear();
    Console.WriteLine($"A informação recebida é invalida\nErro: {ex.Message}");
}

Console.Clear();
Console.WriteLine("Tudo bem, até a proxima!");
