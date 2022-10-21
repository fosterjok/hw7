// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
//возвращает значение этого элемента или же указание, что такого элемента нет.

int m=3, n= 4;
int [,] array = new int [m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j]= new Random().Next(-90,100);
        Console.Write($"{array[i,j]} ");
    } Console.WriteLine();
}

int a ;
Console.Write($"Введите первую позицию: ");
int.TryParse(Console.ReadLine()!, out a);
int b;
Console.Write($"Введите второую позицию: ");
int.TryParse(Console.ReadLine()!, out b);

if ( a>= array.GetLength(0) || b>= array.GetLength(1))
Console.Write("Элемента нет");
else
Console.Write($"{array[a,b]}");