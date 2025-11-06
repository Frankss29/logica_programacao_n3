//REVISÃO DOS EXERCÍCIOS - PARA FIXAÇÃO 

//1)Peça para o usuário inserir dois números inteiros e mostre-os no Console.
//2)Peça para o usuário inserir dois números inteiros, mostre a soma dos números informados no Console.
//3)Peça para o usuário inserir dois números inteiros, mostre a subtração dos números informados no Console.
//4)Peça para o usuário inserir dois números inteiros, mostre a multiplicação dos números informados no Console.
//5)Peça para o usuário inserir dois números inteiros, mostre a divisão dos números informados no Console
//(Cuidado com o tipo na hora de mostrar o resultado).


//Exercício 1

//Declaração das variaveis que usaremos para fazer o exercicio
int n1;
int n2;
int resultado;

////Escrevi uma mensagem no console
//Console.WriteLine("Insira um número inteiro: ");
////li o conteudo de uma linha, quando o usuario apertou a tecla ENTER, teremos que converter utilizando 
////o PARSE pois o que o usuario digitou esta no formato tipo TEXTO e temos que transforma em numero inteiro
//n1 = int.Parse(Console.ReadLine());


//Console.WriteLine("Insira outro número inteiro:");
//n2 = int.Parse(Console.ReadLine());

////Mostrar os dois números no Console
//Console.WriteLine("Você digitou estes números: " + n1 + " e " + n2);


//Exercício 2 - SOMA

//Console.WriteLine("Insira um número inteiro: ");
//n1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Insira outro número inteiro:");
//n2 = int.Parse(Console.ReadLine());

//resultado = n1 + n2;

//Console.WriteLine("Esta é soma dos números: " + resultado );

//Exercício 3 - SUBTRAÇÃO

//Console.WriteLine("Insira um número inteiro: ");
//n1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Insira outro número inteiro:");
//n2 = int.Parse(Console.ReadLine());

//resultado = n1 - n2;

//Console.WriteLine("Esta é a subtração dos números: " + resultado);

//Exercício 4 - MULTIPLICAÇÃO
Console.WriteLine("Insira um número inteiro: ");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Insira outro número inteiro:");
n2 = int.Parse(Console.ReadLine());

resultado = n1 * n2;

Console.WriteLine("Esta é a multiplicação dos números: " + resultado);

//Exercício 5 - DIVISÃO (USAR DOUBLE POIS NA DIVISÃO DEMOS NUMEROS QUEBRADOS)