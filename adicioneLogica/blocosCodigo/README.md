# Controlar o escopo da variável e a lógica usando blocos de código em C#

## Desafio

Reescrever e corrigir o código problemático no editor do .NET :

`int[] numbers = { 4, 8, 15, 16, 23, 42 };`
`foreach (int number in numbers)`
`{`
    `int total;`
    `total += number;`
    `if (number == 42)`
    `{`
       `bool found = true;`
    `}`
`}`
`if (found)` 
`{`
    `Console.WriteLine("Set contains 42");`
`}`
`Console.WriteLine($"Total: {total}");`

Depois que ele estiver funcionando, você deverá ver a saída a seguir ao executar o código.

`Set contains 42`
`Total: 108`