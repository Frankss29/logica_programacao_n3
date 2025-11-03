//AULA 3 - OPERADORES 

/*int x = 1;
int y = 1;
int z = 2;

double resultado = ((x + y) * z)/3;

resultado += 100;

Console.WriteLine("Helo, Wolrd!");
Console.WriteLine("Olá, Mundo!");
Console.WriteLine(resultado <100);

Console.WriteLine("\n-----\n");

string nome = "Franciele";
string sobrenome = "Santos";
Console.WriteLine(nome+sobrenome);

//TABELA ASCII OS RESULTADOS APRESENTADOS SÃO O VALOR DO CARACTER NA TABELA ASCII 
//EX: CARACTER A É IGUAL 65 E O CARACTER a É IGUAL 97
char letraA= 'a';
char letraB = 'A';
Console.WriteLine(letraA+ 0);
Console.WriteLine(letraB+ 0);

Console.WriteLine("\n-----\n");

Console.WriteLine("Escreva seu nome:");
string nomeUsuario = Console.ReadLine();
//Console.WriteLine("O seu nome é:" + nomeUsuario);
/*Console.WriteLine("Qual a sua idade?");
string idadeUsuarioString= Console.ReadLine();

Console.WriteLine("Em qual ano você nasceu?");
string anoNascimentoUsuario= Console.ReadLine();
int idadeUsuario = 2025 - int.Parse(anoNascimentoUsuario);
Console.WriteLine("O seu nome é:" + nomeUsuario);
Console.WriteLine("Sua idade é " + idadeUsuario);*/


/*Exercicios
//1)Peça para o usuário inserir dois números inteiros e mostre-os no Console.
Console.WriteLine("Digite um Número?");
string Numero1Usuario = Console.ReadLine();
Console.WriteLine("Digite outro Número?");
string Numero2Usuario = Console.ReadLine();
Console.WriteLine("Você digitou estes números: " + Numero1Usuario);
Console.WriteLine("Você digitou estes números: " + Numero2Usuario);

Console.WriteLine("\n-----\n");
//2)Peça para o usuário inserir dois números inteiros, mostre a soma dos números informados no Console.

Console.WriteLine("Digite um Número?");
string Numero3Usuario = Console.ReadLine();
Console.WriteLine("Digite outro Número?");
string Numero4Usuario = Console.ReadLine();
int SomaNumeros = int.Parse(Numero3Usuario) + int.Parse(Numero4Usuario);
Console.WriteLine("A soma dos números é:"+SomaNumeros);

Console.WriteLine("\n-----\n");
//3)Peça para o usuário inserir dois números inteiros, mostre a subtração dos números informados no Console.

Console.WriteLine("Digite um Número?");
string Numero5Usuario = Console.ReadLine();
Console.WriteLine("Digite outro Número?");
string Numero6Usuario = Console.ReadLine();
int SubtracacaoNumeros = int.Parse(Numero5Usuario) - int.Parse(Numero6Usuario);
Console.WriteLine("A subtração dos números é:" + SubtracacaoNumeros);

Console.WriteLine("\n-----\n");
//4)Peça para o usuário inserir dois números inteiros, mostre a multiplicação dos números informados no Console.

Console.WriteLine("Digite um Número?");
string Numero7Usuario = Console.ReadLine();
Console.WriteLine("Digite outro Número?");
string Numero8Usuario = Console.ReadLine();
int MultiplicacaoNumeros = int.Parse(Numero7Usuario) * int.Parse(Numero8Usuario);
Console.WriteLine("A multiplicação dos números é:" + MultiplicacaoNumeros);

Console.WriteLine("\n-----\n");
//5)Peça para o usuário inserir dois números inteiros, mostre a divisão dos números informados no 
//Console (Cuidado com o tipo na hora de mostrar o resultado).

Console.WriteLine("Digite um Número?");
string Numero9Usuario = Console.ReadLine();
Console.WriteLine("Digite outro Número?");
string Numero10Usuario = Console.ReadLine();
int DivisãoNumeros = int.Parse(Numero9Usuario) / int.Parse(Numero10Usuario);
Console.WriteLine("A divisão dos números é:" + DivisãoNumeros);*/

//RESOLUÇÃO DO PROFESSOR 
//1)Peça para o usuário inserir dois números inteiros e mostre-os no Console.

//int n1;
//int n2;

//Console.WriteLine("Informe um número inteiro");
//n1= int.Parse(Console.ReadLine());

//Console.WriteLine("Informe outro número inteiro");
//n2 = int.Parse(Console.ReadLine());

//Console.WriteLine("Os números informado são:" + n1 + " e " + n2 + ".");

//2)Peça para o usuário inserir dois números inteiros, mostre a soma dos números informados no Console.

//string n1, n2;
//Console.WriteLine("Informe um numero inteiro:");
//n1=Console.ReadLine();
//Console.WriteLine("Informe outro numero inteiro:");
//n2 = Console.ReadLine();

//int n1int = int.Parse(n1);
//int n2int = int.Parse(n2);
//int soma = n1int + n2int;
//Console.WriteLine("O resultado da soma é: " + soma);

//3)Peça para o usuário inserir dois números inteiros, mostre a subtração dos números informados no Console.

//Console.WriteLine("Informe um numero inteiro:");
//int n1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Informe outro numero inteiro:");
//int n2 = int.Parse(Console.ReadLine());
//Console.WriteLine("O valor sa subtração é: " + (n1-n2));


//4)Peça para o usuário inserir dois números inteiros, mostre a multiplicação dos números informados no Console.

//Console.WriteLine("Informe um numero inteiro:");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine("Informe outro numero inteiro:");
//n *= int.Parse(Console.ReadLine());
//Console.WriteLine("O valor da multiplicação é: " + n);


//5)Peça para o usuário inserir dois números inteiros, mostre a divisão dos números informados no 
//Console (Cuidado com o tipo na hora de mostrar o resultado).

Console.WriteLine("Informe um numero inteiro:");
double n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Informe outro numero inteiro:");
double n2 = double.Parse(Console.ReadLine());

double divisao = (n1 / n2);
Console.WriteLine("O valor da multiplicação é: " + divisao);