INICIO ALGORITIMO

DECLARAÇAO:
num1  (inteiro);
num2  (inteiro);
num3  (inteiro);

ESCREVA ("Digite dois valores iremos mostrar o maior e o menor deles");
LEIA (num1); 
LEIA (num2);

ENQUANTO (num1 < num2 ENTAO ESCREVA "o segundo numero é maior que o segundo");
FIM-ENQUANTO

ENQUANTO (num2 < num1 ENTAO ESCREVA "o primeiro numero é maior que o segundo");
FIM-ENQUANTO

ESCREVA ("Digite mais um valor");
LEIA (num3);

SE (num3 < num2,num1);
  ESCREVA ("o terceiro numero é menor que os dois ultimos");

SENAO (num3 > num2,num1);
  ESCREVA ("o terceiro numero é maior que os dois ultimos");

SENAO
  ESCREVA ("o ultimo numero não é nem maior nem menor que os dois ultimos);

FIM-SE

FIM ALGORITIMO
