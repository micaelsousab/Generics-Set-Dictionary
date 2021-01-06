using System;
using System.Collections.Generic;

namespace Dictionary_e_SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Dictionary<TKey, TValue>
            // É uma coleção de pares chave / valor
            // Não admite repetições do objeto chave
            // Os elementos são indexados pelo objeto chave (não possuem posição)
            // Acesso, inserção e remoção de elementos são rápidos

            // Instanciando um novo Dictionary com uma Key do tipo string e um Value do tipo string.
            Dictionary<string, string> dicionario = new Dictionary<string, string>();

            // Aqui estou setando a Key 'usuario' com o value 'Micael'.
            dicionario["usuario"] = "Micael";
            dicionario["email"] = "micaelsousabrb@gmail.com";
            dicionario["telefone"] = "+55 81 99846-8571";

            // Como o Dictionary não aceita Keys iguais, o value da Key 'telefone' vai ser substituido pelo value abaixo.
            dicionario["telefone"] = "+55 81 99846-8575";

            dicionario.Remove("usuario");

            if (dicionario.ContainsKey("usuario"))
                Console.WriteLine(dicionario["usuario"]);
            else
                Console.WriteLine("O Dictionary não possui a Key 'usuario'");

            // Também é possível instanciar o Dictionary desta forma:
            Dictionary<int, string> dicionario2 = new Dictionary<int, string>
            {
                [18] = "Micael",
                [25] = "Ana",
                [35] = "Renato"
            };

            // O Console.WriteLine irá imprimir o Value do Dictionary.
            Console.WriteLine(dicionario2[18]);

            Console.WriteLine("Tamanho do Dictionary 2: " + dicionario2.Count);

            Console.WriteLine("Todos os Values do Dictionary 2: ");
            foreach (KeyValuePair<int, string> item in dicionario2)
            {
                Console.WriteLine($"Key {item.Key} = Value {item.Value}");
            }

            // Um exemplo de um Dictionary utilizando listas
            List<string> listaDeStrings = new List<string>()
            {
                "Xbox",
                "PlayStation",
                "Nintendo"
            };

            List<string> listaDeStrings2 = new List<string>()
            {
                "Xiaomi",
                "iPhone",
                "Samsung"
            };

            Dictionary<string, List<string>> dicionarioComLista = new Dictionary<string, List<string>>
            {
                ["Consoles"] = listaDeStrings,
                ["Celulares"] = listaDeStrings2
            };

            foreach (KeyValuePair<string, List<string>> item in dicionarioComLista)
            {
                Console.WriteLine($"Key: {item.Key}, Values: ");

                foreach (string item2 in item.Value)
                {
                    Console.WriteLine(item2);
                }
            }
        }
    }
}
