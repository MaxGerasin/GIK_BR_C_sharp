// 3. Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

 void FillArray(int[] numbers)
 {
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(-9, 10);
    }
 }

 void PrintArray(int[] numbers)
 {
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "   ");
    }
    Console.WriteLine();
 }


void Zadacha3()
{
 int size = 8;
 int[] numbers = new int [size];
 FillArray(numbers);
 PrintArray(numbers);

 for (int i = 1; i < size; i++)
 {
    for (int j = 0; j < size - i; j++)
    {
        if (Math.Abs(numbers[j]) > Math.Abs(numbers[j+1]))
        {
            int temp = numbers[j];
            numbers[j] = numbers[j+1];
            numbers[j+1] = temp;
        }
    }
 }
 PrintArray(numbers);
}
 Zadacha3();
