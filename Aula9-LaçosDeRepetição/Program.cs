// AULA 8 - LAÇOS DE REPETIÇÃO - WHILE | DO WHILE | 

//Exercício 1) Faça uma votação com SWITCH CASE o minimo de usuarios para votar é 5.

//const string AMARELO = "AMARELO";
//const string AZUL = "AZUL";
//const string VERDE = "VERDE";

//const string MSG_VOTO = "Qual é o seu voto? (AMARELO, AZUL ou VERDE)";

//string voto;

//int votosAmarelo = 0;
//int votosVerde = 0;
//int votosAzul = 0;
//int abs = 0;
//int cont = 0;

////USANDO FOR 
////for(int cont=0; cont<5; cont++)
//// {

////// Votação
////Console.WriteLine(MSG_VOTO);
////voto = Console.ReadLine();

////// Apuração
////switch (voto)
////{
////    case AMARELO:
////        votosAmarelo++;
////        break;
////    case AZUL:
////        votosAzul++;
////        break;
////    case VERDE:
////        votosVerde++;
////        break;
////    default:
////        abs++;
////        break;
////}

////}

////USANDO DO WHILE
//do
//{
//    // Votação
//    Console.WriteLine(MSG_VOTO);
//    voto = Console.ReadLine();

//    // Apuração
//    switch (voto)
//    {
//        case AMARELO:
//            votosAmarelo++;
//            break;
//        case AZUL:
//            votosAzul++;
//            break;
//        case VERDE:
//            votosVerde++;
//            break;
//        default:
//            abs++;
//            break;
//    }

//    cont++;
//} while (cont < 5);


//// Resultado
//int vencedor = 0;

//if (vencedor < votosAmarelo)
//{
//    vencedor = votosAmarelo;
//}

//if (vencedor < votosAzul)
//{
//    vencedor = votosAzul;
//}

//if (vencedor < votosVerde)
//{
//    vencedor = votosVerde;
//}

//if (vencedor < abs)
//{
//    vencedor = abs;
//}

//if (vencedor == votosAmarelo)
//{
//    Console.WriteLine("O Amarelo é o vencedor.");
//}

//if (vencedor == votosAzul)
//{
//    Console.WriteLine("O Azul é o vencedor.");
//}

//if (vencedor == votosVerde)
//{
//    Console.WriteLine("O Verde é o vencedor.");
//}

//if (vencedor == abs)
//{
//    Console.WriteLine("Não há vencedor dado o número de abstenções.");
//}


//EXERCÍCIOS

//1) Tabuada: Faça um programa que receba um número e, usando
//laços de repetição, calcule e mostre a tabuada desse número. 

//Declaração de Variaveis

//int numeroUser;
//int count = 1;

//Console.WriteLine("Digite um número inteiro: ");
//numeroUser= int.Parse(Console.ReadLine());

//Console.WriteLine("\n-----\n");

//while (count <= 10)
//{
//    int resultado = numeroUser * count;
//    Console.WriteLine(numeroUser + "x"+ count + "=" +resultado);
//    count++;
//}

//2)Validação de Nota: Faça um programa que peça uma nota entre zero e dez.
//Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.


int nota;

Console.WriteLine("Digite uma Nota: ");
nota = int.Parse(Console.ReadLine());

for(int count=0;nota>10; count++)

{

    Console.WriteLine("Nota inválida digite novamente: ");
    
}



