//  1. Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.


        Console.WriteLine("Задача принимает два числа (A и B) \nи возводит число A в натуральную степень B.");
        Console.Write("Введите число A:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число B:");
        int b = Convert.ToInt32(Console.ReadLine());
        int result = 0;
        int Metod(double result)
        {
            result = Math.Pow(a, b);
            return Convert.ToInt32(result);
        }
        Console.WriteLine($"{Metod(result)}");


