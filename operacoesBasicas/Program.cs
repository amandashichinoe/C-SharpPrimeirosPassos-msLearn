using System;

namespace operacoesBasicas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adição simples e conversão de dados implícita
            int firstNumber = 12;
            int secondNumber = 7;
            Console.WriteLine(firstNumber + secondNumber);

            Console.WriteLine("-----------------");

            //misturando tipos de dados
            string firstName = "Bob";
            int widgetsSold = 7;
            Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets."); 
            Console.WriteLine(firstName + " sold " + (widgetsSold +7) + " widgets.");
            
            Console.WriteLine("-----------------");

            //Operadores matemáticos
            int sum = 7 + 5;
            int difference = 7 - 5;
            int product = 7 * 5;
            int quotient  = 7 / 5;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);

            Console.WriteLine("-----------------");

            //Adicionando código para executar a divisão usando dados decimais literais
            decimal decimalQuotient = 7.0m/5;
            Console.WriteLine("Decimal quotient: " + decimalQuotient);

            //decimal decimalQuotient = 7 / 5.0m;
            //decimal decimalQuotient = 7.0m / 5.0m;

            Console.WriteLine("-----------------");

            int first = 7;
            int second = 5;
            decimal quotient1 = (decimal)first / (decimal)second;
            Console.WriteLine(quotient1);

            Console.WriteLine("-----------------");

            //Escrever código para determinar o resto após a divisão de int
            Console.WriteLine("Modulus of 200 / 5 : " + (200 % 5)); 
            Console.WriteLine("Modulus of 7 / 5: " + (7 % 5));

            Console.WriteLine("-----------------");

            //Incrementar e decrementar valores
            int value = 1;
            value = value + 1;
            Console.WriteLine("First increment: " + value);
            value +=1;
            Console.WriteLine("Second increment: " + value);
            value ++;
            Console.WriteLine("Third increment: " + value);
            value = value -1;
            Console.WriteLine("First decrement: " + value);
            value -=1;
            Console.WriteLine("Second decrement: " + value);
            value --;
            Console.WriteLine("Third decrement: " + value);

            Console.WriteLine("-----------------");

            //Usando o operador de incremento antes e depois do valor
            int value2 = 1;
            value2++;
            Console.WriteLine("First: " + value2);
            Console.WriteLine("Second: " + value2++); 
            Console.WriteLine("Third: " + value2);
            Console.WriteLine("Fourth: " + (++value2));

            Console.WriteLine("-----------------");

            //Desafio
            int fahrenheit = 94;
            decimal celsius = ((fahrenheit-32m)*5m/9m);
            Console.WriteLine("The temperature is " + celsius + " Celsius");
            //(32 °F − 32) × 5/9 = 0 °C
        }
    }
}
