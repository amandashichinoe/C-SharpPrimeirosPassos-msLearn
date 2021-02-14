﻿using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            //DESAFIO 

            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            // Your code goes here

            if(daysUntilExpiration==0)
            {
                Console.WriteLine("Your subscription has expired.");
            }
            else if(daysUntilExpiration==1)
            {
                discountPercentage = 20;
                Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
            }
            else if(daysUntilExpiration<=5){
                discountPercentage = 10;
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
            }
            else if(daysUntilExpiration<=10)
            {
                Console.WriteLine("Your subscription will expire soon.  Renew now!");
            }

            /* outra solução

            if(daysUntilExpiration==0)
            {
                Console.WriteLine("Your subscription has expired.");
            }
            else if(daysUntilExpiration==1)
            {
                Console.WriteLine("Your subscription expires within a day!");
                discountPercentage = 20;
            }
            else if(daysUntilExpiration<=5){
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
                discountPercentage = 10;
            }
            else if(daysUntilExpiration<=10)
            {
                Console.WriteLine("Your subscription will expire soon.  Renew now!");
            }
            if (discountPercentage > 0)
            {
                Console.WriteLine($"Renew now and save {discountPercentage}%.");
            }
            */
        }
    }
}
