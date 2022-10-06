// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] array = new int[4, 4];
int i = 0;
while (i < array.GetLength(0))
{
    int j = 0;
    while (j < array.GetLength(1))
    {
        array[i, j] = new Random().Next(1, 11);
        Console.Write($"{array[i, j]} ");
        j++;
    }
    Console.WriteLine();
    i++;
}
  int k = 0;
while (k < array.GetLength(1))
{
    i = 0;
    double result =0;
    while (i < array.GetLength(0))
    {   
        result = result + array[i,k];
        i++;
    }
    result = result / array.GetLength(1); 
    Console.WriteLine($"Среднеарифмтическое {k} колонки равно {result}");
    k++;
}