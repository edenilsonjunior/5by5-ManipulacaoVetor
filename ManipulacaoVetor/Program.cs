/*
 2- faça um programa que leia size numeros inteiros e faça os seguintes itens:
	A) Imprima o vetor lido
	B) Imprima o vetor de trás para frente
	C) Imprima até a metade do vetor
	D) Guarde os valores impares em um novo vetor sem os valores 0
	E) Guarde os valores pares em um novo vetor sem os valores 0
 */



Console.WriteLine("=====Numeros pares e impares=====");

// Variavel que representa o tamanho dos vetores para evitar redundancia na repeticao do tamanho e facilidade de mudança do tamanho dos vetores
int size = 10;

// vetor principal
int[] numeros = new int[size];

// vetores de pares e impares e seus respectivos indices
int[] pares = new int[size];
int[] impares = new int[size];
int qntPares = 0, qntImpares = 0;

// Leitura
for (int i = 0; i < size; i++)
{
    Console.Write($"Digite o numero({i}): ");
    numeros[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("=============================");


Console.WriteLine("A) Vetor lido:");
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Array[{i}]={numeros[i]}");
}
Console.WriteLine("=============================");


Console.WriteLine("B) Vetor lido ao contrário:");
for (int i = size-1; i >= 0; i--)
{
    Console.WriteLine($"Array[{i}]={numeros[i]}");
}
Console.WriteLine("=============================");


Console.WriteLine("C) Vetor lido pela metade:");
for (int i = 0; i < (size / 2); i++)
{
    Console.WriteLine($"Array[{i}]={numeros[i]}");
}

// Guardando os valores pares e impares em seus respectivos vetores (em ordem de Inserção)
for (int i = 0; i < size; i++)
{
    if (numeros[i] % 2 == 0)
    {
        pares[qntPares++] = numeros[i];
    }
    else
    {
        impares[qntImpares++] = numeros[i];
    }
}
Console.WriteLine("=============================");

if (qntPares > 0){
    Console.WriteLine("Valores pares:");

    for (int i = 0; i < qntPares; i++)
    {
        Console.Write($"{pares[i]} ");
    }
}

Console.WriteLine("\n=============================");

if (qntImpares > 0)
{
    Console.WriteLine("Valores impares:");

    for (int i = 0; i < qntImpares; i++)
    {
        Console.Write($"{impares[i]} ");
    }
}

Console.WriteLine("\n=============================");

Console.Write("\nDigite qualquer tecla para sair: ");
Console.ReadKey();
