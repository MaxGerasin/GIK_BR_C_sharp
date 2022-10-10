// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();
Console.Write("Введите номер задачи: ");
int nom = Convert.ToInt32(Console.ReadLine());
switch (nom)
{
    case 1:
        Console.WriteLine("Алгоритм считает сколько чисел больше 0 ввёл пользователь.");
        int count = 0;
        Console.Write("Введите размер массива:");
        int size = Convert.ToInt32(Console.ReadLine());    
        int[] arrayNm = new int[size];   

        for (int i = 0; i < arrayNm.Length; i++)             
        {
            Console.Write($"Введите {i + 1} число массива:");
            arrayNm[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("[ " + string.Join(", ", arrayNm) + " ]");

        for (int i = 0; i < arrayNm.Length; i++)
        {
            if (arrayNm[i] > 0) count += 1;
        }
        Console.WriteLine($"В данном масcиве {count} элемента-(ов) больше нуля ");
        break;

    case 2:
        Console.WriteLine("Нахождения точки пересечния прямых.");
        Console.Write($"Введите b1 первую координату:");
        double b1 = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Введите k1 вторую координату:");
        double k1 = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Введите b2 третью координату:");
        double b2 = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Введите k2 четвертую координату:");
        double k2 = Convert.ToInt32(Console.ReadLine());

        double x = (b2 - b1) / (k1 - k2);
        double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;

        Console.WriteLine($"Точка пересечения прямых имеет координаты: ({x}, {y})");
        break;
}