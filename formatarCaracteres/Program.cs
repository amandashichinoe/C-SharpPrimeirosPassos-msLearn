using System;

namespace formatarCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {     
            //Concatenar diversas variáveis e cadeias de caracteres literais
            string firstName = "Bob";
            string greeting = "Hello";
            string message = greeting + " " + firstName + "!";
            Console.WriteLine(message);

            //Evitando variáveis intermediárias
            Console.WriteLine(greeting + " " + firstName + "!");

            Console.WriteLine("---------------- \n");
            //Interpolação de cadeia de caracteres
            string message1 = greeting + " " + firstName + "!";
            string message2 = $"{greeting} {firstName}!";

            //string firstName = "Bob";
            string message3 = $"Hello {firstName}!";
            Console.WriteLine(message3);

            Console.WriteLine("---------------- \n");
            //string firstName = "Bob";
            //string greeting = "Hello";
            string message4 = $"{greeting} {firstName}!";
            Console.WriteLine(message4);

            //Evitando variáveis intermediárias
            Console.WriteLine($"{greeting} {firstName}!");

            Console.WriteLine("---------------- \n");

            //Combinando literais textuais e interpolação de cadeia de caracteres
            string projectName1 = "First-Project";
            Console.WriteLine($@"C:\Output\{projectName1}\Data");

            Console.WriteLine("---------------- \n");
            
            //DESAFIO
            string projectName = "ACME";

            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

            Console.WriteLine($@"View English output
                C:\Exercise\{projectName}\data.txt
                ");

            Console.WriteLine($@"{russianMessage}
                C:\Exercise\{projectName}\ru-RU\data.txt");

            /*outra solução
            string projectName = "ACME";
            string englishLocation = $@"c:\Exercise\{ projectName}\data.txt";
            Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");
                        
            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
            Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");*/
        }
    }
}
