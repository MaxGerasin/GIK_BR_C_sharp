/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
 с наименьшей суммой элементов. */

void Zadacha2()
{
    System.Console.WriteLine("Задайте двумерный массив.Напишите программу,\nкоторая будет находить строку с наименьшей суммой элементов.\n");
    Console.Write("Введите количество строк массива:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов массива:");
    int colums = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, colums];
    FillArray(array);
    PrintArray(array);
    summElement(array);

}
Zadacha2();

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 9);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

void summElement(int[,] array)
{
    int summ = 0;
    int[] element = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ += array[i, j];
        }
        Console.WriteLine($"Cумма {i + 1} строки = {summ}");
        element[i] = summ;
        summ = 0;
    }
    int minValue = element[0];
    int indexMin = 1;
    for (int i = 1; i < element.Length; i++)
    {
        if (minValue > element[i]) { minValue = element[i]; indexMin = i + 1; }
    }
    Console.WriteLine($"Строка {indexMin}, имеет наименьшую сумму элементов");
}