INICIO

DECLARAÇAO:
num1 <- decimal
num2 <- decimal
num3 <- decimal

ESCREVA "Digite dois valores iremos mostrar o maior e o menor deles"
LEIA num1 
LEIA num2

SE num1 <- num2

  ESCREVA (num1 "E menor que " num2)

SENAO num2 <- num1 

  ESCREVA (num2 "E menor que " num2)
  
FIM-SE

ESCREVA "Digite mais um numero"
LEIA num3

SE num3 <- num2,num1
ESCREVA "numero 3 é menor que os dois ultimos"

FIM-SE

SE num3 -> num1,num2
ESCREVA "o numero 3 é o maior
"
FIM-SE

SENAO ESCREVA "o terceiro numero não é nem menos nem maior que os dois ultimos

FIM-SENAO

FIM
