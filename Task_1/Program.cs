// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Задайте размеры массива");
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
double [,] array = new double [m,n];

double RandomNumber()
{
    int x  = new Random().Next(1,11);
    double y = new Random().NextDouble();
    double result = x + y;
    return Math.Round(result,1);
}

while(i < m)
{
     int j =0;
    while(j < n)
    {
        array[i,j] = RandomNumber();
        Console.Write($"{array[i,j]} ");
        j++;
    }
    Console.WriteLine();
    i++;
}
