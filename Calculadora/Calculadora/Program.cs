using System;

namespace Calculadora
{
    class Program
    {

        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }
        static void Main(string[] args)
        {
            bool escolheuSair = false;

            while (!escolheuSair)
            {

                Console.WriteLine("Seja bem-vindo ao CALC, selecione uma das opções:");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }

                Console.WriteLine(opcao);
                Console.Clear();

            }
        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int primeiroNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int segundoNumero = int.Parse(Console.ReadLine());
            int resultado = primeiroNumero + segundoNumero;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao Menu.");
            Console.ReadLine();
        }
    }
}
