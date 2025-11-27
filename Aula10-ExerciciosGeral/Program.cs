//EXERCÍCIOS - AULA 10

//1)Crie um programa que peça ao usuário uma senha. O programa deve permitir até 3 tentativas. 
//A senha correta é "12345". 
//Se o usuário digitar a senha correta E tiver mais de 18 anos (idade informada previamente), o acesso é liberado. 
//Caso contrário, o programa informa que o acesso foi negado. 

//const int QTD_TENTATIVA=3;
//const int senhaValida = 12345;
//string entradaUser;

//Console.WriteLine(" Informe sua idade: ");
//entradaUser = Console.ReadLine();
//int.TryParse(entradaUser, out int idade);

//if (idade >= 18)
//{
//    Console.WriteLine(" Informe a senha: ");
//    entradaUser = Console.ReadLine();
//    int.TryParse(entradaUser, out int senha);

//    if (senha == senhaValida)
//    {

//        Console.WriteLine("ACESSO LIBERADO");
//        Console.WriteLine("----------------");
//        Console.WriteLine("Bem-Vindo!!");

//    }
//    else 
//    {
//        int tentativaRestantes = QTD_TENTATIVA - 1;

//        while(senha != senhaValida && tentativaRestantes > 0 )
//        {

//            Console.WriteLine(" Senha incorreta informe novamente: ");
//            entradaUser = Console.ReadLine();
//            int.TryParse(entradaUser, out senha);
//            tentativaRestantes--;  

//        }if (senha==senhaValida)
//        {
//            Console.WriteLine("ACESSO LIBERADO");
//            Console.WriteLine("----------------");
//            Console.WriteLine("Bem-Vindo!!");

//        }
//        else
//        {
//            Console.WriteLine("ACESSO NEGADO VOCÊ EXCEDEU NÚMEROS DE TENTATIVAS DE SENHA ");
//        }

//    }
//}else{
//    Console.WriteLine("VOLTE QUANDO TIVER 18 ANOS");
//}

//Exercício 2 – Números Pares e Ímpares 
//Peça ao usuário um número inteiro positivo. O programa deve imprimir todos os números de 1 até esse número. 
//Para cada número, informe se ele é par ou ímpar. 
//Se o número for par e múltiplo de 5 ao mesmo tempo, destaque com a mensagem "Par e múltiplo de 5". 


//Console.WriteLine("Insirar um número inteiro e positivo: ");
//bool inteiro = int.TryParse(Console.ReadLine(), out int numero);

//if (inteiro && numero > 0)
//{
//    for (int contador = 1; contador <= numero; contador++)
//    {
//        bool par = contador % 2 == 0;
//        bool multiplo5 = contador % 5 == 0;

//        if (par && multiplo5)
//        {
//            Console.WriteLine(contador + " é par e múltiplo de 5. ");
//        }
//        else if (par && !multiplo5)
//        {
//            Console.WriteLine(contador + " é par.");
//        }
//        else
//        {
//            Console.WriteLine(contador + " é impar.");
//        }

//    }
// }
//else
//{
//    Console.WriteLine("O número informado não é válido");
//}


//Exercício 3 – Caixa Registradora 
//Simule uma caixa registradora simples. 
//O programa deve pedir o valor de cada produto até que o usuário digite 0 para encerrar. 
//Ao final, mostre o total da compra. 
//Se o total for maior que R$ 100 OU o cliente tiver um cupom de desconto
//(informado como CUPOM10), aplique 10% de desconto. 

const string CUPOM10 = "CUPOM10";
double valor = -1;
double total = 0;

while (valor != 0)
{
    Console.WriteLine("Insira o valor do produto:");
    valor = double.Parse(Console.ReadLine());
    if (valor > 0)
    {
        total += valor;
    }
}

Console.WriteLine("Insira o cupom de desconto:");
string cupom = Console.ReadLine();

if (cupom == CUPOM10 || total > 100)
{
    Console.WriteLine("O valor total com 10% de desconto é R$ " + (total * 0.9));
}
else
{
    Console.WriteLine("O valor total é R$ " + total);
}