//Exercício de Comando de Decisão SWITCH CASE

//Exercício 1) Faça uma votação com SWITCH CASE o minimo de usuarios para votar é 5.

int votoUrso = 0;
int votoLobo = 0;
int votoLeopardo = 0;


//Mostrar as opções de Voto
Console.WriteLine("Vote para escolher o mascote do Time de Futebol ");
Console.WriteLine("escolha 1 para Urso");
Console.WriteLine("escolha 2 para Leopardo");
Console.WriteLine("escolha 0 para Lobo");

Console.WriteLine("\n-----\n");

//Voto 1
//Pedir para Votar
Console.WriteLine("Escolha o seu voto 1,2 OU 3:");
string entrada1 = Console.ReadLine();
char voto1 = entrada1[0];

//Exibir o voto 
switch (voto1)
{
   case '1':
        votoUrso++;
        break;


   case '2':
        votoLobo++;
        break;

    case '3':
        votoLeopardo++;
        break;

    default:    
        break;
}

Console.WriteLine("\n-----\n");

//Voto 2
Console.WriteLine("Escolha o seu voto 1,2 OU 3:");
string entrada2 = Console.ReadLine();


char voto2 = entrada2[0];

//Exibir o voto 
switch (voto2)
{
    case '1':
        votoUrso++;
        break;


    case '2':
        votoLobo++;
        break;

    case '3':
        votoLeopardo++;
        break;

    default:
        break;
}

Console.WriteLine("\n-----\n");

//Voto 3
Console.WriteLine("Escolha o seu voto 1,2 OU 3:");
string entrada3 = Console.ReadLine();


char voto3 = entrada3[0];

//Exibir o voto 
switch (voto3)
{
    case '1':
        votoUrso++;
        break;


    case '2':
        votoLobo++;
        break;

    case '3':
        votoLeopardo++;
        break;

    default:
        break;
}

Console.WriteLine("\n-----\n");

//Voto 4

Console.WriteLine("Escolha o seu voto 1,2 OU 3:");
string entrada4 = Console.ReadLine();


char voto4 = entrada4[0];

//Exibir o voto 
switch (voto4)
{
    case '1':
        votoUrso++;
        break;


    case '2':
        votoLobo++;
        break;

    case '3':
        votoLeopardo++;
        break;

    default:
        break;
}

Console.WriteLine("\n-----\n");

//Voto 5

Console.WriteLine("Escolha o seu voto 1,2 OU 3:");
string entrada5 = Console.ReadLine();


char voto5 = entrada5[0];

//Exibir o voto 
switch (voto5)
{
    case '1':
        votoUrso++;
        break;


    case '2':
        votoLobo++;
        break;

    case '3':
        votoLeopardo++;
        break;

    default:
        break;
}

//Quem tem Mais Votos


Console.WriteLine("Resultados da votação:");
Console.WriteLine("\n-----\n");

//Console.WriteLine("Votos do Urso: " + votoUrso + " votos ");
//Console.WriteLine("Votos do Lobo: " + votoLobo + " votos ");
//Console.WriteLine("Votos do Leopardo: " + votoLeopardo + " votos ");

int vencedor = 0;

if (vencedor < votoUrso)
{
    vencedor= votoUrso;
}
if (vencedor < votoLobo)
{
    vencedor=votoLobo;
}
if (vencedor < votoLeopardo)
{
    vencedor = votoLeopardo;
}
if(vencedor == votoUrso)
{
    Console.WriteLine(" O Urso é o Vencedor com " + votoUrso + " Votos ");
}

if (vencedor == votoLobo)
{
    Console.WriteLine(" O Lobo é o Vencedor com " + votoLobo + " Votos ");
}

if (vencedor == votoLeopardo)
{
    Console.WriteLine(" O Leopardo é o Vencedor com " + votoLobo + " Votos ");
}








