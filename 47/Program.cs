// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
int m=3, n= 4;
double [,] array = new double [m,n];
int s = 10;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j]= new Random().Next(-90,100)/(double)s;
        Console.Write($"{array[i,j]} ");
    } Console.WriteLine();
}
