/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака. */

void Zadacha1()
{
    Console.Write("Введите количество строк двумерного массива: ");
    int rowCount = int.Parse(Console.ReadLine());

    Console.Write("Введите количество столбцов двумерного массива: ");
    int columnCount = int.Parse(Console.ReadLine());

    double[,] array = FillArray(rowCount, columnCount);
    PrintArray(array);

    double[,] FillArray(int rows, int columns)
    {
        double[,] filledArray = new double[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                filledArray[i, j] = new Random().NextDouble() * 100;
                filledArray[i, j] = Math.Round(filledArray[i, j], 1);
            }
        }
        return filledArray;
    }
}
Zadacha1();

void PrintArray(double[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"\t{inputArray[i, j]}");
        }
        Console.Write(" ]");
        Console.WriteLine();
    }
}