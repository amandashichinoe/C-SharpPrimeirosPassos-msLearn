using System;

namespace arraysAndForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //Executando um loop em uma matriz usando o foreach
            string[] names = { "Bob", "Conrad", "Grant" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("--------------");

            //Criando e inicializando uma matriz de int
            int[] inventory = { 200, 450, 700, 175, 250 };
            //Adicionando uma instrução foreach para iterar na matriz e adicionar uma variável para somar o valor de cada elemento na matriz
            int sum = 0;
            foreach (int items in inventory)
            {
                sum += items;
            }
            //Exibindo valor final da soma
            Console.WriteLine($"We have {sum} items in inventory.");

            Console.WriteLine("--------------");

            //Criando e adicionando uma variável para armazenar o número do compartimento atual e exibir o total atual, o código anterior fica:
            int[] inventory2 = { 200, 450, 700, 175, 250 };
            int sum2 = 0;
            int bin = 0;
            foreach (int items in inventory2)
            {
                sum2 += items;
                bin++;
                Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum2})");
            }
            Console.WriteLine($"We have {sum2} items in inventory.");
            
            Console.WriteLine("--------------");

            //DESAFIO

            string [] id = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

            foreach(string items in id){
                if(items.StartsWith("B"))
                {
                    Console.WriteLine(items);
                }    
            }
        }
    }
}
