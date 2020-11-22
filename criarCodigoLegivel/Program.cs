using System;

namespace criarCodigoLegivel
{
    class Program
    {
        static void Main(string[] args)
        {
            // DESAFIO

            /*This code converts a message into a char array, reverse the chars and count the number of ocurrences that
            the char 'o' appears in the message, printing the result on the console window*/
            string initialMessage = "The quick brown fox jumps over the lazy dog.";
            char[] message = initialMessage.ToCharArray();
            Array.Reverse(message);
            int occurrences = 0;

            foreach (char letter in message)
            { 
                if (letter == 'o') 
                {
                    occurrences++; 
                } 
            }

            string newmessage = new String(message);

            Console.WriteLine(newmessage);
            Console.WriteLine($"'o' appears {occurrences} times.");
        }
    }
}
