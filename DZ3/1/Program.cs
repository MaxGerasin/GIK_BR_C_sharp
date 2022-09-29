/* Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
   Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
   Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. */

Console.Clear();
Console.Write("Введите номер задачи:");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1:
        Console.WriteLine("Является ли оно палиндромом ?");
        Console.Write("Введте пятизначное число:");
        int fiveDig = Convert.ToInt32(Console.ReadLine());
        if (fiveDig < 10000 || fiveDig > 99999)
            Console.Write("Введено не пятизначное число");
        else
        {
            int num1 = fiveDig / 10000;
            int num2 = fiveDig / 1000 % 10;
            int num4 = fiveDig / 10 % 10;
            int num5 = fiveDig % 10;
            if (num1 == num5 && num2 == num4) Console.Write("Число является палиндроном!");
            else Console.Write("Число не является палиндроном!");
        }
        break;

    case 2:
        Console.WriteLine("Координаты двух точек и находит расстояние между ними в 3D пространстве");
        Console.Write("Введите первую кооринату xa:");
        double xa = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите вторую координату ya:");
        double ya = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите третью кооринату za:");
        double za = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите первую кооринату xb:");
        double xb = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите вторую координату yb:");
        double yb = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите третью кооринату zb:");
        double zb = Convert.ToInt32(Console.ReadLine());
        double otvet = Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2);
        double tvet = Convert.ToDouble(Math.Sqrt(otvet));
        Console.WriteLine($"Ответ: {tvet}");
        break;

    case 3:
        Console.WriteLine("Программа которая выдает таблицу кубов от 1 до n:");
        Console.Write("Введите число:");
        double cubing = Convert.ToInt32(Console.ReadLine());
        int count = 1;
        while (cubing >= count)
        {
            Console.WriteLine($"Квадрат = {Math.Pow(count, 3)}");
            count++;
        }
        break;
}