//EXERCÍCIOS DE LÓGICA DE PROGRAMAÇÃO

// EXERCÍCIO 1 - Ler o número inteiro e exibir o valor do dobro.
//Declara variavel Constante
const int DOIS = 2;

////Escrevendo no console uma string pedindo um número
//Console.WriteLine("Digite um Número Inteiro: ");

////Nao preciso ler a resposta do usuario separadamente da conversão 
////string numeroUsuario = Console.ReadLine();

////Lendo a resposta do usuario e Convertendo a string em número
////e fazendo a multiplicação por 2 para mostra o dobro
//int dobro=int.Parse(Console.ReadLine())*DOIS;

////Escrevendo resultado no console
//Console.WriteLine("O Dobro do Número Digitado é: " + dobro);

//-------------------------------------------------------------------------------------

// EXERCÍCIO 2 - leiam o valor do lado de um quadrado, calcule a
// area(lado*lado) e o perimetro(4*lado) e exibir o resultado.
//se o quadrado tem uma area maior que 1000 exibir
//que ele é grande e se for menor exibir que ele é pequeno

//const int QUATRO = 4;
//const int MIL = 1000;

//Console.WriteLine("Informe o valor do lado do quadrado: ");
//int numeroUsuario= int.Parse(Console.ReadLine());
//int area = numeroUsuario*numeroUsuario;
//int perimetro =numeroUsuario*QUATRO;

//if(area>MIL){
//    Console.WriteLine("O seu quadrado é grande tem a Área de " + area + " e o Perímetro é de " + perimetro);
//}
//else
//{
//    Console.WriteLine("O seu quadrado é pequeno tem a Área de " + area + " e o Perímetro é de " + perimetro);
//}

//-------------------------------------------------------------------------------------

// EXERCÍCIO 3 - ler um número inteiro e exibir se ele é impar ou par

Console.WriteLine("Informe um número: ");
int numUsuario =int.Parse(Console.ReadLine());


if (numUsuario%2==0){

    Console.WriteLine( numUsuario + " é um número Par ");

}
else
{
    Console.WriteLine( numUsuario + " é um número Impar ");
}

