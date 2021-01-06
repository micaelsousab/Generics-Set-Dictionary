using Generics.Services;
using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generics
            // Generics permite que classes, interfaces e métodos possam ser 
            // Parametrizados por tipo. 

            // Beneficios
            // Reuso
            // Type safety 
            // Perfomarce

            // Exemplo de Generic do tipo string
            PrintService<string> _printServiceString = new PrintService<string>();

            Console.Write("How many values: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Value {i + 1}: ");
                string x = Console.ReadLine();

                _printServiceString.AddValue(x);
            }

            _printServiceString.Print();
            Console.Write("\n\nFirst: " + _printServiceString.First() + "\n\n");


            // Exemplo de Generic do tipo double
            PrintService<double> _printServiceDouble = new PrintService<double>();

            Console.Write("How many values: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Value {i + 1}: ");
                double x = double.Parse(Console.ReadLine());

                _printServiceDouble.AddValue(x);
            }

            _printServiceDouble.Print();
            Console.Write("\n\nFirst: " + _printServiceDouble.First() + "\n\n");
        }
    }
}
