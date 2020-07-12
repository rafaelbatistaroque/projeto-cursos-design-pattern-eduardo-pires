using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escolha aoperação:");
            Console.WriteLine("------------------");
            Console.WriteLine("Criacionais");
            Console.WriteLine("------------------");
            Console.WriteLine("1 - Abstract Factory");
            Console.WriteLine("2 - Method Factory");
            Console.WriteLine("3 - Singleton");
            Console.WriteLine("------------------");

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    ExecucaoAbstractFactory.Executar();
                        break;
                default:
                    break;
            }

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
