/* Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа
 в промежутке от N до 1. Выполнить с помощью рекурсии. 
  Задача 2.  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
  Задача 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.*/

  Console.Clear();

void Zadacha1()
{
    Console.Write("Введите m:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите n:");
    int n = Convert.ToInt32(Console.ReadLine());
    int Recurs(int m)
    {
        if (m <= n)
        {
            if (m % 2 == 1)
            { return Recurs(m + 1); }

            if (m % 2 == 0)
            {
                Console.WriteLine(m);
                return Recurs(m + 2);
            }

        }
        return m;
    }
    Recurs(m);
}

void Zadacha2()
{
    Console.Write("Введите m:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите n:");
    int n = Convert.ToInt32(Console.ReadLine());
    int summ = 0;
    int Recurs(int m, int n)
    {
        if (m <= n)
        {
            summ += m + Recurs(m + 1, n);
        }
        return summ;
    }
    Console.WriteLine(Recurs(m, n));
}

void Zadacha3()
{
int m = InputIntNumber('m');
int n = InputIntNumber('n');
Console.WriteLine($"A(m,n) = {AckermanFunc(m, n)}");

int AckermanFunc(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    if (numM > 0 && numN == 0)
    {
        return AckermanFunc(numM - 1, 1);
    }
    if (numM > 0 && numN > 0)
    {
        return AckermanFunc(numM - 1, AckermanFunc(numM, numN - 1));
    }
    return AckermanFunc(numN, numM);
}

int InputIntNumber(char ch = ' ')
{
    while (true)
    {
        Console.Write($"Введите число {ch}: ");
        int number = int.Parse(Console.ReadLine() ?? "0");
        while (number > 0)
            return number;
    }
}
}

/* Zadacha1();
Zadacha2();
Zadacha3(); */
Zadacha3();