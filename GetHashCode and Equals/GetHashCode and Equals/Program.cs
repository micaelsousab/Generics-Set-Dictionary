using GetHashCode_and_Equals.Entities;
using System;

namespace GetHashCode_and_Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            // GetHashCode e Equals

            // São operadores da classe Object utilizadas para comparar se um objeto é igual a outro

            // Equals: Lento, 100% de resposta
            // GetHashCode: Rápido, porém resposta não é 100%

            // Os tipos pré-definidos já possuem implementação para essas operações. 
            // Classes e structs personalizados precisam sobrepô-las.

            // Equals é o método que compara se o objeto é igual a outro, retornando true ou false
            string a = "Maria";
            string b = "Alex";

            Console.WriteLine(a.Equals(b));

            string c = "Mike";
            string d = "Mike";

            Console.WriteLine(c.Equals(d));

            // GetHashCode é o método que retorna um número inteiro representando um código gerado a partir das informações do objeto
            Console.WriteLine("\n\n" + a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            Console.WriteLine(c.GetHashCode());
            Console.WriteLine(d.GetHashCode());

            // Regra de ouro do GetHashCode: 
            // Se o código de dois objetos for diferente, então os dois objetos são diferentes
            // Se o código de dois objetos for igual, MUITO PROVAVELMENTE os objetos são iguais (pode haver colisão)

            Client ca = new Client { Name = "Maria", Email = "maria@gmail.com"  };
            Client cb = new Client { Name = "Alex", Email = "maria@gmail.com" };

            Console.WriteLine("\n\n" + ca.Equals(cb));
            Console.WriteLine(ca.GetHashCode());
            Console.WriteLine(cb.GetHashCode());
        }
    }
}
