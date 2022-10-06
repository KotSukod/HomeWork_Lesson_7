//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int[,] array = new int[4, 4];
int i = 0;
Console.WriteLine("Введите позицию в массиве: ");
Console.Write("Введите номер строки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Массив:");
while (i < array.GetLength(0))
{
    int j = 0;
    while (j < array.GetLength(1))
    {
        array[i, j] = new Random().Next(1, 21);
        Console.Write($"{array[i, j]} ");
        j++;
    }
    Console.WriteLine();
    i++;
}
if (x < array.GetLength(0))
{
    if (y < array.GetLength(1)) Console.WriteLine($"Элемент массива({x},{y}) равен: {array[x,y]}");
    else Console.WriteLine($"Элемента массива({x},{y}) не существует");
}
else Console.WriteLine($"Элемента массива({x},{y}) не существует");
