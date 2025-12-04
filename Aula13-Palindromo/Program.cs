//Exercício Palindromo - Aula 13
//Exemplos de palindromo Arara, Ovo etc

Console.WriteLine("Insira uma palavra: ");
string palavra = Console.ReadLine().ToLower();
string palavraInvertida = "";

for (int i = palavra.Length -1; i >= 0; i--)
{
    palavraInvertida += palavra[i];
}

if (palavraInvertida == palavra)
{
    Console.WriteLine("PALINDROMO!");
}
else
{
    Console.WriteLine("é só uma palavra mesmo!");
}