# Módulo: Avaliar expressões Booleanas para tomar decisões em C#

## Desafio 1
Lançar uma moeda para exibir heads ou tails.

* Use a classe Random para gerar um valor. Com base no valor, use o operador condicional para exibir heads ou tails.
* As chances de que o resultado seja cara ou coroa devem ser de 50% cada.
* Você deve ser capaz de realizar o resultado desejado em três linhas de código ou menos.

## Desafio 2
Neste desafio, você implementará regras de negócios que restringem o acesso a usuários com base nas respectivas permissões e nível. 
Você exibirá uma mensagem diferente para cada usuário, dependendo das respectivas permissões e nível.
Regras de negócios:
1. Se o usuário for um administrador com um nível maior que 55, exiba a mensagem:
`Welcome, Super Admin user.`
2. Se o usuário for um administrador com um nível menor ou igual a 55, exiba a mensagem:
`Welcome, Admin user.`
3. Se o usuário for um gerente com um nível maior ou igual a 20, exiba a mensagem:
`Contact an Admin for access.`
4. Se o usuário for um gerente com um nível menor que 20, exiba a mensagem:
`You do not have sufficient privileges.`
5.  Se o usuário não for um administrador nem um gerente, exiba a mensagem:
  `You do not have sufficient privileges.`