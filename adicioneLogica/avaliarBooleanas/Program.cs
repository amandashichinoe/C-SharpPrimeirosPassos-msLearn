using System;

namespace avaliarBooleanas
{
    class Program
    {
        static void Main(string[] args)
        {   /* DESAFIO 1 - Cara ou Coroa */

            Random moeda = new Random();
            int resultado = moeda.Next(0,2);
            Console.WriteLine((resultado == 0) ? "heads" : "tails");

            //Outra solução possível
            Random coin = new Random();
            Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");

            //DESAFIO 2 - Permissões complicadas
            //solução 1
            string permission = "Admin|Manager";
            int level = 53;

            if(level > 55){
                Console.WriteLine("Welcome, Super Admin user.");
            }
            else if(permission.Contains("Admin") && level <=55)
            {
                Console.WriteLine("Welcome, Admin user.");
            }
            else if(permission.Contains("Manager")&& level >=20)
            {
                Console.WriteLine("Contact an Admin for access.");
            }
            else if(permission.Contains("Manager") && level < 20)
            {
                Console.WriteLine("You do not have privileges.");
            }
            else if(!permission.Contains("Admin") || !permission.Contains("Manager"))
            {
                Console.WriteLine("You do not have privileges.");
            }

            //solução 2 
            /*
            string permission = "Admin|Manager";
            int level = 53;

            if (permission.Contains("Admin"))
            {
                if (level > 55)
                {
                    Console.WriteLine("Welcome, Super Admin user.");
                }
                else
                {
                    Console.WriteLine("Welcome, Admin user.");
                }
            }
            else if (permission.Contains("Manager"))
            {
                if (level >= 20)
                {
                    Console.WriteLine("Contact an Admin for access.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient privileges.");
                }
            }
            else
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }
            */
        }
    }
}
