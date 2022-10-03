// 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Программa, которая принимает на вход число и выдаёт сумму цифр в числе");
        Console.Write("Введите число:"); 
        int numSum = Convert.ToInt32(Console.ReadLine());
        int resSum = 0;
        int temp = 0;
        string len = Convert.ToString(numSum);
        int count = 1;
        while (count <= len.Length)
        {
            temp = numSum - numSum % 10;
            resSum = resSum + (numSum - temp);
            numSum /= 10;
            count++;
        }
        Console.WriteLine($"Ответ: {resSum}");