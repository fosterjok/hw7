// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int m=3, n= 4;
int [,] array = new int [m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j]= new Random().Next(20);
        Console.Write($"{array[i,j]} ");
    } Console.WriteLine();
}
int sum1=0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        sum1=sum1+array[i,j];
    } Console.WriteLine();
    Console.Write($"Среднее арифм строк : {(double)sum1/n}\n");
}

int sum2=0;
for (int j = 0; j < n; j++)
{
    for (int i = 0; i < m;i++)
    {
        sum2=sum2+array[i,j];
    } Console.WriteLine();
    Console.Write($"Среднее арифм столбцов : {(double)sum2/m}\n");
}
