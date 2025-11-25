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


//Console.WriteLine("Digite uma Nota: ");
//string entradaUser = Console.ReadLine();
//bool valido = int.TryParse(entradaUser, out int nota);//Acrescentei com a correção do Professor

////DOIS PAPE QUE DIZER OU EXEMPLO "NOTA MENOR QUE ZERO OU NOTA MAIOR QUE 10) OU É UM OPERADOR LOGICO

//while (!valido || nota<0 || nota > 10)

//{

//    Console.WriteLine("Nota inválida digite novamente: ");
//    nota = int.Parse(Console.ReadLine());

//}

//Console.WriteLine("\n-----\n");

//3) Controle de peso: Faça um programa que receba a idade e o peso de sete pessoas. Calcule e mostre:  
//A quantidade de pessoas com mais de 90 quilos;
//A média das idades das sete pessoas;


////DECLARAÇÃO DE VARIAVEIS
int peso;
int idade;
// Variaes para guardar os valores pedidos no console
int somaDasIdades = 0;
int pessoasMais90Kg = 0;

for (int count = 1; count <= 7; count++)
{

    Console.Write("Informe a Idade: ");
    idade = int.Parse(Console.ReadLine());
    somaDasIdades = somaDasIdades + idade;
    Console.Write("Informe o Peso (Kg): ");
    peso = int.Parse(Console.ReadLine());

    //Verificar se o peso +90
    if (peso > 90)
    {
        pessoasMais90Kg = pessoasMais90Kg + 1;
    }
    Console.WriteLine("\n-----\n");
}

// 3. RESULTADOS (Após o loop)

double mediaIdades = somaDasIdades / 7;

Console.WriteLine("Quantidade de pessoas com mais de 90 Kg: " + pessoasMais90Kg);

Console.WriteLine(" Média das idades das 7 pessoas: " + mediaIdades);


// LEMBRA NOS PROXIMOS EXERCICIOS DE  VER SE O QUE FOI DIGITADO É VALIDO
//bool valido= int.TryParse(entradaUsuario, out int nota);




