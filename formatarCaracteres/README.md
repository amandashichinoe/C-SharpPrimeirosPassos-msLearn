# Módulo - Executar formatação de cadeia de caracteres básica em C#

## Aprendizados
- Criar dados de cadeia de caracteres contendo guias, novas linhas e outros caracteres especiais;
- Criar dados de cadeia de caracteres contendo caracteres Unicode;
- Combinar dados de cadeia de caracteres em um novo valor de cadeia de caracteres por meio de concatenação;
- Combinar dados de cadeia de caracteres em um novo valor de cadeia de caracteres por meio de interpolação.

## Desafio

1. Comece a resolver o desafio com as duas linhas de código a seguir:
```
string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
```

2. A variável projectName será usada duas vezes na saída desejada.

3. A variável russianMessage contém a mensagem "Exibir saída russa" em russo. Você precisa usar essa variável em seu código que imprime a mensagem.

4. Você não pode alterar essas duas linhas de código, mas pode adicionar código acima e abaixo de cada linha. Você precisa usar essas duas linhas de código para formar a saída desejada.

5. Você só pode usar o método Console.WriteLine() ou Console.Write() duas vezes.

6. Para concluir esse desafio, seu código deve produzir a saída a seguir.

```
View English output:
        c:\Exercise\ACME\data.txt

Посмотреть русский вывод:
        c:\Exercise\ACME\ru-RU\data.txt
```