# Módulo - Criar código legível com convenções, espaço em branco e comentários em C#

## Aprendizados
- escolher um nome descritivo para variáveis que descrevam sua finalidade e intenção;
- usar comentários de código para instruir temporariamente o compilador a ignorar linhas de código;
- usar comentários de código para descrever uma finalidade ou requisitos de nível superior para uma passagem de código;
- escrever código que use espaço em branco de modo eficaz para transmitir a relação de linhas de código.

## Desafio
Neste desafio, você usará as técnicas aprendidas neste módulo. Seu objetivo é fazer melhorias em um código mal formatado e mal comentado para melhorar sua legibilidade.

Código Ilegível:

```
string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new String(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");
```
