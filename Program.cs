using System;

namespace Calculator
{
    class program
    {
        static void Main(string[]args)
        {
            Menu();
        }
        
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Selecione a função: ");
            Console.WriteLine("1)Somar: ");
            Console.WriteLine("2)Subtrair: ");
            Console.WriteLine("3)Dividir: ");
            Console.WriteLine("4)Multiplicar: ");
            Console.WriteLine("5)Fechar: ");

            Console.WriteLine("----------");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }
        static void Soma()
        {
            Console.Clear();
            
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
           
            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("");
            
            float total = v1 + v2;
            Console.WriteLine("Total: " + total);

            Console.ReadKey();

            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
           
            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("");
            
            float total = v1 - v2;
            Console.WriteLine("Total: " + total);

            Console.ReadKey();

            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
           
            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("");
            
            float total = v1 / v2;
            Console.WriteLine("Total: " + total);

            Console.ReadKey();

            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
           
            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("");
            
            float total = v1 * v2;
            Console.WriteLine("Total: " + total);

            Console.ReadKey();

            Menu();
        }
    }
}

