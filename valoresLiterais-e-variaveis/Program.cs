using System;

namespace valoresLiterais_e_variaveis
{
    class Program
    {
        static void Main()
        {
            //Armazenar e recuperar dados usando valores literais e variáveis em C#

            //Exercicio Valores Literais
            //Gravando um literal char no console
            Console.WriteLine('b');
            //Gravando um literal int no console
            Console.WriteLine(123);
            //Gravando um literal decimal no console
            Console.WriteLine(12.3m);
            //Gravando um literal bool no console
            Console.WriteLine(true);
            Console.WriteLine(false);

            Console.WriteLine("-------------");
            //Configurando e obtendo valores de variáveis
            //Recuperar um valor armazenado na variável
            string firstName;
            firstName = "Bob";
            Console.WriteLine(firstName);

            Console.WriteLine("-------------");
            //Retribuir o valor de uma variável
            //string firstName;
            firstName = "Bob";
            Console.WriteLine(firstName);
            firstName = "Beth";
            Console.WriteLine(firstName);
            firstName = "Conrad";
            Console.WriteLine(firstName);
            firstName = "Grant";
            Console.WriteLine(firstName);

            Console.WriteLine("-------------");
            //DESAFIO

            string name = "Bob";
            int message = 3;
            decimal temperature = 34.4m;

            Console.Write("Hello, ");
            Console.Write(name);
            Console.Write("! You have ");
            Console.Write(message);
            Console.Write(" in your inbox. The temperature is ");
            Console.Write(temperature);
            Console.Write(" celsius");

        }
    }
}
