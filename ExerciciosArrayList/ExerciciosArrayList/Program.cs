using System.Collections;

/*ArrayList list = new ArrayList();

list.Add(12.56);
list.Add("GeeksForGeeks");
list.Add(null);
list.Add('G');
list.Add(1234);

foreach (var item in list)
    Console.WriteLine(item);
*/


// -------------------------------------------------------------------------

/*var list2 = new ArrayList();

list2.Add(1);
list2.Add(2);
list2.Add(3);
list2.Add(4);
list2.Add(5);
list2.Add(6);
list2.Add(7);
list2.Add(8);
list2.Add(9);
//list2.Add(10);

Console.WriteLine("Current capacity: " + list2.Capacity);*/

// -----------------------------------------------------------------------------------------------------------------------------

/*ArrayList list3 = new ArrayList();

list3.Add('G');
list3.Add('E');
list3.Add('E');
list3.Add('K');
list3.Add('S');
list3.Add('F');
list3.Add('O');
list3.Add('R');
list3.Add('G');
list3.Add('E');
list3.Add('E');
list3.Add('K');
list3.Add('S');

Console.WriteLine("Initial number of elements: " + list3.Count);

foreach (var item in list3)
    Console.Write(item);

Console.WriteLine();
Console.WriteLine();


// RemoveAt()
list3.RemoveAt(8);
Console.WriteLine("After RemoveAt() method the " + list3.Count);

foreach (var item in list3)
    Console.Write(item);

Console.WriteLine();
Console.WriteLine();

// RemoveRange()
list3.RemoveRange(1, 3);
Console.WriteLine("After RemoveRange() method the " + list3.Count);

foreach (var item in list3)
    Console.Write(item);

Console.WriteLine();
Console.WriteLine();


// Clear()
list3.Clear();
Console.WriteLine("After Clear() method the " + list3.Count);

foreach (var item in list3)
    Console.Write(item);

Console.WriteLine();
Console.WriteLine();*/

// ------------------------------------------------------------------------------------------------------------------------------

/*
ArrayList list4 = new ArrayList();

list4.Add(1);
list4.Add(6);
list4.Add(40);
list4.Add(10);
list4.Add(5);
list4.Add(3);
list4.Add(2);
list4.Add(4);

foreach (var item in list4)
{
    Console.Write(item);
}

// method sort()

list4.Sort();

Console.WriteLine();
Console.WriteLine("ArrayList after using Sort() method: ");
foreach(var item in list4)
{
    Console.WriteLine(item);
}*/

// --------------------------------------------------------------------------------------------------------------------------------

/*const int tamanho = 20;

string linha;
int[] vetor = new int[tamanho];
int conta = 0;
int numero = 0;

while(conta < tamanho)
{
    linha = Console.ReadLine();
    numero = int.Parse(linha);
    if (numero >= 0)
    {
        conta += 1;
        vetor[conta - 1] = numero;
    }
}

for (int i = tamanho - 1; i >= 0; i--)
{
    Console.WriteLine($"Posição {i} valor {vetor[i]}");
}

conta = tamanho;

while(conta > 0)
{
    conta -= 1;
    Console.WriteLine($"Posição {conta} valor {vetor[conta]}");
}

// soma todos

int soma = 0;

for (int i = 0; i < tamanho; i++)
{
    soma += vetor[i];
}

Console.WriteLine("Soma: " + soma);

soma = 0;
for (int i = 0; i < tamanho; i++)
{
    if (vetor[i] >= 10)
    {
        soma += vetor[i];
    }
}

Console.WriteLine("Soma " + soma);

int tempo = 0;

for (int i = 0; i <= (vetor.Length / 2) - 1; i++)
{
    tempo = vetor[i];
    vetor[i] = vetor[vetor.Length - 1 - i];
    vetor[vetor.Length - 1 - i] = tempo;
}

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine(vetor[i]);
}*/

// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------


/*int[] notas = new int[8];
int soma = 0;
int nota = 0;

for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine("Introduza um valor inteiro de 0 à 20");
    nota = int.Parse(Console.ReadLine());

    if ((nota < 0) || (nota > 20))
    {
        Console.WriteLine("O valor não está entre 0 a 20");
        i--;
    }
    else
    {
        notas[i] = nota;
    }
}

for (int i = 0; i < notas.Length; i++)
{
    soma += notas[i];
}

double media = soma / 8;
int conta = 0;
for (int i = 0; i < notas.Length; i++)
{
    if (notas[i] > media)
        conta += 1;
}

Console.WriteLine("Contagem de numeros acima da média " + conta);

int maior = notas[0];

for (int i = 1; i < notas.Length; i++)
{
    if (notas[i] > maior)
        maior = notas[i];
}

conta = 0;

for (int i = 0; i < notas.Length; i++)
{
    if (notas[i] == maior)
        conta += 1;
}

Console.WriteLine("Contagem de alunos que tiveram a maior nota " + conta);

int menor = notas[0];

for (int i = 1; i < notas.Length; i++)
{
    if (notas[i] < menor)
        menor = notas[i];
}

Console.WriteLine("A menor nota foi " + menor);
Console.WriteLine("Os indices dos alunos que tiveram a menor nota são: ");

for (int i = 0; i < notas.Length; i++)
{
    if (notas[i] == menor)
        Console.WriteLine("Aluno: " + i);
}

conta = 0;

for (int i = 0; i < notas.Length; i++)
{
    if (notas[i] < 10)
        conta += 1;
}

Console.WriteLine("Contagem de alunos que tiveram nota < 10: " + conta);*/

// -------------------------------------------------------------------------------------------------------------------------------------

