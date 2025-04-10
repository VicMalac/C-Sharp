/*Escreva uma função em C# que receba como parâmetro um inteiro N e retorne um array
com todos os divisores de N.me}");*/

Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

if  (numero % 2 == 0)
{
    Console.WriteLine("Seu numero é divisível por 2");
}
else if (numero % 3 == 0)
{
    Console.WriteLine("Seu numero é divisível por 3");
}
else if (numero % 5 == 0)
{
    Console.WriteLine("Seu numero é divisível por 5");
}
else if (numero % 7 == 0)
{
    Console.WriteLine("Seu numero é divisível por 7");
}
else
{
    Console.WriteLine("Seu número não divisível por nenhum número primo menor que 10");
}