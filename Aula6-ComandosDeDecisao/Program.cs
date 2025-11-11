//AULA 6 COMANDO DE DECISÃO - IF/ELSE
//DEFINIR AS CONSTANTES
const int DEZOITO = 18;
const int ZERO = 0;


//Escrevendo no console pedido a idade do usuario 
Console.WriteLine("Qual a sua idade?");

//Ler resposta do usuario
string resposta  = Console.ReadLine();

// TRYPARSE tente converte este valor se for valido/verdadeiro(bool)
//Tenta transformar a string resposta em um int idade,
//atribui o resultado a uma varoavel bool
bool ehValido = int.TryParse(resposta, out int result);

//Verifica se a tentativa de parse funcionou
if(ehValido)

{ 

//  Verifica se a idade é maior ou igual a 18
int idade =int.Parse(resposta);

if (idade >= DEZOITO)
{
    Console.WriteLine("Usuario é maior de idade");
}

    //  Verifica se a idade é valida
    else if (idade<ZERO)
{
    Console.WriteLine("Idade invalida");
}
else 
{
    //Se for valida e menor que 18
    Console.WriteLine("Usuario é menor de idade");
}

}
else
{
    Console.WriteLine("Valor informado não corresponde a um número inteiro");
}
