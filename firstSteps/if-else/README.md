# Módulo - Adicionar lógica de decisão a seu código usando a instrução if-else em C#

## Aprendizados
- escrever código que avalia condições usando as instruções if-elseif-else;
- criar expressões boolianas para avaliar uma condição;
- combinar expressões boolianas usando operadores lógicos;
- aninhar blocos de código dentro de outros blocos de código.

## Desafio
1. Iniciar com o código:
```
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
```
1. Se a assinatura do usuário expirar em 10 dias ou menos, será exibida a mensagem:
```
Your subscription will expire soon.  Renew now!
```
2. Se a assinatura do usuário expirar em cinco dias ou menos, será exibida a mensagem:
```
Your subscription expires in _ days.
Renew now and save 10%!
```

Certifique-se de substituir _ pelo valor armazenado na variável daysUntilExpiration.

3. Se a assinatura do usuário expirar em um dia, será exibida a mensagem:
```
Your subscription expires within a day!
Renew now and save 20%!
```

4. Se a assinatura do usuário tiver expirado, será exibida a mensagem:
```
Your subscription has expired.
```

5. Se a assinatura do usuário não expirar em 10 dias ou menos, não será exibida nenhuma mensagem.
