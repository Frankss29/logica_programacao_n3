//EXERCÍCIOS - AULA 10

//1)Crie um programa que peça ao usuário uma senha. O programa deve permitir até 3 tentativas. 
//A senha correta é "12345". 
//Se o usuário digitar a senha correta E tiver mais de 18 anos (idade informada previamente), o acesso é liberado. 
//Caso contrário, o programa informa que o acesso foi negado. 

const int QTD_TENTATIVA=3;
string entradaUser;
int senhaValida = 12345;

Console.WriteLine(" Informe sua idade: ");
entradaUser = Console.ReadLine();
int.TryParse(entradaUser, out int idade);

if (idade >= 18)
{
    Console.WriteLine(" Informe a senha: ");
    entradaUser = Console.ReadLine();
    int.TryParse(entradaUser, out int senha);

    if (senha == senhaValida)
    {

        Console.WriteLine("ACESSO LIBERADO");
        Console.WriteLine("----------------");
        Console.WriteLine("Bem-Vindo!!");

    }
    else if (senha != senhaValida)
    {

        for (int contador = 0; contador < 3; contador++)
        {

            Console.WriteLine(" Senha incorreta informe novamente: ");
        }

    }
}else{
    Console.WriteLine("VOLTE QUANDO TIVER 18 ANOS");
}






