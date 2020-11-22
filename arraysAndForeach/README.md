# Módulo - Armazenar e iterar em sequências de dados usando Matrizes e a instrução foreach em C#

## Aprendizados
- Criar e inicializar uma nova matriz;
- Definir e obter valores em matrizes;
- Iterar em cada elemento de uma matriz usando a instrução foreach.

## Desafio
Nossa equipe detectou um padrão. Pedidos que começam com a letra "B" têm um número de fraudes 25 vezes maior que o normal. Vamos escrever um novo código para gerar a ID de novos pedidos, em que a ID do pedido começa com a letra "B". Isso será usado por nossa equipe de fraudes para investigar ainda mais.
1. Veja os dados da ID de pedido falsa que deve ser usada para inicializar a matriz.
```
B123
C234
A345
C15
B177
G3003
C235
B179
```

1. Use uma instrução foreach para iterar em cada elemento da matriz que você acabou de declarar e inicializar.

2. Avalie cada elemento da matriz. Identifique e imprima para gerar as IDs de pedidos possivelmente fraudulentas procurando os pedidos que começam com a letra "B". A saída deve corresponder ao seguinte:
```
B123
B177
B179
```

3. Para determinar se um elemento começa ou não com a letra "B", use o método String.StartsWith(). 